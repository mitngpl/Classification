using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCODE_Classification
{
    public partial class MCODE : Form
    {
        private DataTable dt { get; set; }
        public MCODE()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        private void MCODE_Load(object sender, EventArgs e)
        {
            // If folder doesn't exists create.
            System.IO.Directory.CreateDirectory("Training");
            System.IO.Directory.CreateDirectory("Testing");
            System.IO.Directory.CreateDirectory("Merged");
        }
        private void resultOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                resultOutput.CommitEdit(DataGridViewDataErrorContexts.Commit);

                //Check the value of cell
                if ((bool)resultOutput.CurrentCell.Value == true)
                {
                    resultOutput.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
                else
                {
                    resultOutput.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }
        private void btnPredict_Click(object sender, EventArgs e)
        {
            DisableAllButtons();

            resultOutput.Rows.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
            //  get all lines of csv file
            string[] str = File.ReadAllLines(testCsv.Text);

            // get the column header means first line
            string[] temp = str[0].Split(',');

            // creates columns of gridview as per the header name
            foreach (string t in temp)
            {
                dt.Columns.Add(t, typeof(string));
            }

            List<string> identifications = new List<string>();
            // now retrive the record from second line and add it to datatable
            for (int i = 1; i < str.Length; i++)
            {
                string[] t = str[i].Split(',');
                dt.Rows.Add(t);
                if ("0" == dt.Rows[i - 1]["Verified"].ToString())
                    identifications.Add(dt.Rows[i - 1]["CatalogID"].ToString() + "," + dt.Rows[i - 1]["ID"].ToString() + "," + dt.Rows[i - 1]["Verified"].ToString());

            }

            List<string> arguments = new List<string>();
            arguments.Add("\"./Merged/combined.csv\"");

            String output = ExecutePython("Classify.py", arguments, true);

            string[] r = output.Split(new char[] { ',' });

            for (int i = 0; i < r.Length; ++i)
            {
                string Type = "";
                if (r[i].IndexOf(']') != -1)
                {
                    Type = r[i].Remove(r[i].IndexOf(']'), 1);
                }
                else if (r[i].IndexOf('[') != -1)
                {
                    Type = r[i].Remove(r[i].IndexOf('['), 1);
                }
                else
                    Type = r[i];

                string type = GetGroupType(int.Parse(Type));
                string[] t = identifications[i].Split(',');

                DataGridViewComboBoxCell combo = new DataGridViewComboBoxCell();
                resultOutput.Rows.Add((i + 1).ToString(), t[0], t[1], type);
            }

            EnableAllButtons();
        }
        private void btnMergeBoth_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            resultOutput.Rows.Clear();
            MergeTraining();
            MergeTesting();
            
            //Merge Both
            List<string> arguments = new List<string>();
            arguments.Add("\"./Merged/*.csv\"");
            ExecutePython("MergeCSV.py", arguments);
            EnableAllButtons();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (resultOutput.Rows.Count != 0)
            {
                DisableAllButtons();

                foreach (DataGridViewRow row in resultOutput.Rows)
                {
                    bool val = false;

                    if (null != row.Cells["verified"].Value)
                    {
                        val = (bool)row.Cells["verified"].Value;
                        dt.Rows[row.Index]["verified"] = val == true ? "1":"0" ;
                        dt.Rows[row.Index]["Group"] = row.Cells["group"].Value.ToString();
                    }
                    else
                    {
                        DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)row.Cells["Correction"];
                        if (cbCell.Selected)
                        {
                            dt.Rows[row.Index]["verified"] = "1";
                            dt.Rows[row.Index]["Group"] = cbCell.Value.ToString();
                        }
                    }
                }
                string csvData = DataTableToCSV(dt);

                StreamWriter myStream = new StreamWriter("./Merged/combined.csv", false);
                myStream.Write(csvData);
                myStream.Close();
                resultOutput.Rows.Clear();
                EnableAllButtons();
            }

        }
        private String ExecutePython(string pythonScriptName, List<string> args, bool bReturnOutput = false)
        {
            String returnOutput = "";
            try
            {
                //Create process
                Process p = new Process();
                p.StartInfo.FileName = "python.exe";
                p.StartInfo.RedirectStandardOutput = true;

                // make sure we can read the output from stdout
                p.StartInfo.UseShellExecute = false;

                p.StartInfo.CreateNoWindow = true;

                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                string arguments = "";
                foreach (string str in args)
                    arguments += " " + str;

                p.StartInfo.Arguments = pythonScriptName + " " + arguments;

                p.Start(); // start the process (the python program)

                if (bReturnOutput)
                {
                    StreamReader s = p.StandardOutput;
                    String output = s.ReadToEnd();
                    returnOutput = output;
                }
                p.WaitForExit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return returnOutput;
        }
        private string DataTableToCSV(DataTable datatable, char seperator = ',')
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < datatable.Columns.Count; i++)
            {
                sb.Append(datatable.Columns[i]);
                if (i < datatable.Columns.Count - 1)
                    sb.Append(seperator);
            }
            sb.AppendLine();
            foreach (DataRow dr in datatable.Rows)
            {
                for (int i = 0; i < datatable.Columns.Count; i++)
                {
                    sb.Append(dr[i].ToString());

                    if (i < datatable.Columns.Count - 1)
                        sb.Append(seperator);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        private string GetGroupType(int i)
        {
            string type = "none";

            switch (i)
            {
                case 0:
                    type = "Fabric";
                    break;
                case 1:
                    type = "Glass";
                    break;
                case 2:
                    type = "Laminate";
                    break;
                case 3:
                    type = "Leather";
                    break;
                case 4:
                    type = "Metal";
                    break;
                case 5:
                    type = "Mineral";
                    break;
                case 6:
                    type = "Paint";
                    break;
                case 7:
                    type = "Plastic";
                    break;
                case 8:
                    type = "Wood";
                    break;
                case 9:
                    type = "Emitter";
                    break;
                case 10:
                    type = "Miscellaneous";
                    break;
                case 11:
                    type = "SolidSurface";
                    break;
                case 12:
                    type = "Carpet";
                    break;
                case 13:
                    type = "Wallpaper";
                    break;
                default:
                    type = "none";
                    break;

            }
            return type;
        }
        private void MergeTraining()
        {
            List<string> arguments = new List<string>();
            arguments.Add("\"./Training/*.csv\"");
            arguments.Add(" \"1\"");
            arguments.Add("\"./Merged/combined_train.csv\"");
            ExecutePython("MergeCSV.py", arguments);
        }
        private void MergeTesting()
        {
            List<string> arguments = new List<string>();
            arguments.Add("\"./Testing/*.csv\"");
            arguments.Add(" \"0\"");
            arguments.Add("\"./Merged/combined_test.csv\"");
            ExecutePython("MergeCSV.py", arguments);
        }
        private void DisableAllButtons()
        {
            Cursor.Current = Cursors.WaitCursor;
            btnPredict.Enabled = false;
            btnConfirm.Enabled = false;
            btnCombineData.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btnPredict.Enabled = true;
            btnConfirm.Enabled = true;
            btnCombineData.Enabled = true;
            Cursor.Current = Cursors.Default;

        }

        private void resultOutput_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
    }
}
