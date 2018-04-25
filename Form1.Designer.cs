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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCODE));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPredict = new System.Windows.Forms.Button();
            this.resultOutput = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCombineData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.testCsv = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Correction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // btnPredict
            // 
            this.btnPredict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPredict.Location = new System.Drawing.Point(435, 35);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(115, 40);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Predict Group";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // resultOutput
            // 
            this.resultOutput.AllowUserToAddRows = false;
            this.resultOutput.AllowUserToDeleteRows = false;
            this.resultOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultOutput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.CatalogId,
            this.ID,
            this.group,
            this.verified,
            this.Correction});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.resultOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultOutput.Location = new System.Drawing.Point(0, 112);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultOutput.Size = new System.Drawing.Size(898, 527);
            this.resultOutput.TabIndex = 9;
            this.resultOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultOutput_CellContentClick);
            this.resultOutput.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.resultOutput_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Put all Training csvs in Training Folder";
            // 
            // btnCombineData
            // 
            this.btnCombineData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombineData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCombineData.Location = new System.Drawing.Point(285, 35);
            this.btnCombineData.Name = "btnCombineData";
            this.btnCombineData.Size = new System.Drawing.Size(115, 40);
            this.btnCombineData.TabIndex = 12;
            this.btnCombineData.Text = "Combine Data";
            this.btnCombineData.UseVisualStyleBackColor = true;
            this.btnCombineData.Click += new System.EventHandler(this.btnMergeBoth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test csv name:";
            this.label3.Visible = false;
            // 
            // testCsv
            // 
            this.testCsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testCsv.Location = new System.Drawing.Point(127, 78);
            this.testCsv.Name = "testCsv";
            this.testCsv.Size = new System.Drawing.Size(69, 20);
            this.testCsv.TabIndex = 8;
            this.testCsv.Text = "./Merged/combined.csv";
            this.testCsv.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(585, 35);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 40);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Put all Testing csvs in Testing Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "----->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "----->";
            // 
            // Sr
            // 
            this.Sr.HeaderText = "Sr.";
            this.Sr.Name = "Sr";
            this.Sr.ReadOnly = true;
            this.Sr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sr.Width = 38;
            // 
            // CatalogId
            // 
            this.CatalogId.HeaderText = "Catalog ID";
            this.CatalogId.Name = "CatalogId";
            this.CatalogId.ReadOnly = true;
            this.CatalogId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CatalogId.Width = 101;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 34;
            // 
            // group
            // 
            this.group.HeaderText = "Group";
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.group.Width = 65;
            // 
            // verified
            // 
            this.verified.HeaderText = "Verified";
            this.verified.Name = "verified";
            this.verified.Width = 77;
            // 
            // Correction
            // 
            this.Correction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Correction.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Correction.HeaderText = "Correction";
            this.Correction.Items.AddRange(new object[] {
            "",
            "Fabric",
            "Glass",
            "Laminate",
            "Leather",
            "Metal",
            "Mineral",
            "Paint",
            "Plastic",
            "Wood",
            "Emitter",
            "Miscellaneous",
            "SolidSurface",
            "Carpet",
            "Wallpaper"});
            this.Correction.MaxDropDownItems = 14;
            this.Correction.Name = "Correction";
            this.Correction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Correction.Width = 98;
            // 
            // MCODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 639);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCombineData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.testCsv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPredict);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MCODE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCODE Classification";
            this.Load += new System.EventHandler(this.MCODE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.DataGridView resultOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCombineData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox testCsv;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewCheckBoxColumn verified;
        private System.Windows.Forms.DataGridViewComboBoxColumn Correction;
    }
}

