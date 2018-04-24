namespace MCODE_Classification
{
    partial class MCODE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCODE));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.testCsv = new System.Windows.Forms.TextBox();
            this.resultOutput = new System.Windows.Forms.DataGridView();
            this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outPut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(340, 47);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(340, 9);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test csv name:";
            // 
            // testCsv
            // 
            this.testCsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testCsv.Location = new System.Drawing.Point(127, 50);
            this.testCsv.Name = "testCsv";
            this.testCsv.Size = new System.Drawing.Size(207, 20);
            this.testCsv.TabIndex = 8;
            // 
            // resultOutput
            // 
            this.resultOutput.AllowUserToAddRows = false;
            this.resultOutput.AllowUserToDeleteRows = false;
            this.resultOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultOutput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.ID,
            this.outPut});
            this.resultOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultOutput.Location = new System.Drawing.Point(0, 89);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.ReadOnly = true;
            this.resultOutput.Size = new System.Drawing.Size(508, 230);
            this.resultOutput.TabIndex = 9;
            // 
            // Sr
            // 
            this.Sr.HeaderText = "Sr.";
            this.Sr.Name = "Sr";
            this.Sr.ReadOnly = true;
            this.Sr.Width = 45;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // outPut
            // 
            this.outPut.HeaderText = "Output";
            this.outPut.Name = "outPut";
            this.outPut.ReadOnly = true;
            this.outPut.Width = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Put all Training csvs in Training Folder";
            // 
            // MCODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.testCsv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnPredict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MCODE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCODE Classification";
            ((System.ComponentModel.ISupportInitialize)(this.resultOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox testCsv;
        private System.Windows.Forms.DataGridView resultOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn outPut;
        private System.Windows.Forms.Label label1;
    }
}

