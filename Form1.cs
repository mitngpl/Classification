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
        public MCODE()
        {
            InitializeComponent();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            btnPredict.Enabled = false;
            if(testCsv.Text.Length==0)
            {
                btnPredict.Enabled = true;
                MessageBox.Show("Test csv name missing!!!");
                return;
            }
            List<string> IDs = new List<string>();
            try
            {
                resultOutput.Rows.Clear();
                using (StreamReader sr = new StreamReader(testCsv.Text))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        string orderId = parts[1];
                        IDs.Add(orderId);

                    }
                }

                Process p = new Process(); // create process (i.e., the python program
                p.StartInfo.FileName = "python.exe";
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false; // make sure we can read the output from stdout
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "Classification_onmergerdata.py " + "\"./" + testCsv.Text + "\"";
                p.StartInfo.CreateNoWindow = true;
                p.Start(); // start the process (the python program)
                StreamReader s = p.StandardOutput;
                String output = s.ReadToEnd();
                string[] r = output.Split(new char[] { ',' }); // get the parameter

                for (int i = 0; i < r.Length; ++i)
                {
                    string Type = "";

                    int index1 = r[i].IndexOf(']');
                    if (index1 != -1)
                    {
                        Type = r[i].Remove(index1, 1);
                    }

                    else if (r[i].IndexOf('[') != -1)
                    {
                        Type = r[i].Remove(r[i].IndexOf('['), 1);
                    }
                    else
                        Type = r[i];

                    string type = GetGroupType(int.Parse(Type));

                    resultOutput.Rows.Add((i + 1).ToString(), IDs[i + 1], type);
                }
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { btnPredict.Enabled = true; }
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

        private void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {
                btnTrain.Enabled = false;
                Process p = new Process(); // create process (i.e., the python program
                p.StartInfo.FileName = "python.exe";
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false; // make sure we can read the output from stdout
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "MergeCSV.py " + "\"./Training/*.csv\"";
                p.Start(); // start the process (the python program)
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnTrain.Enabled = true;
            }
        }
    }
}
