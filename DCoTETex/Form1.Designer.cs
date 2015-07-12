namespace DCoTETex
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvLogArea = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.fbInstallDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tbInstallDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.tbDDSDir = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbFiles = new System.Windows.Forms.ProgressBar();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.cbLogEnabled = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbHeader.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLogArea
            // 
            this.lvLogArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLogArea.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvLogArea.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvLogArea.Location = new System.Drawing.Point(323, 19);
            this.lvLogArea.Name = "lvLogArea";
            this.lvLogArea.Size = new System.Drawing.Size(285, 186);
            this.lvLogArea.TabIndex = 1;
            this.lvLogArea.UseCompatibleStateImageBehavior = false;
            this.lvLogArea.View = System.Windows.Forms.View.Details;
            this.lvLogArea.Resize += new System.EventHandler(this.lvLogArea_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 280;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(12, 390);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(614, 16);
            this.pbProgress.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pbProgress, "Current file progress");
            // 
            // tbInstallDir
            // 
            this.tbInstallDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInstallDir.Location = new System.Drawing.Point(132, 19);
            this.tbInstallDir.Name = "tbInstallDir";
            this.tbInstallDir.ReadOnly = true;
            this.tbInstallDir.Size = new System.Drawing.Size(435, 20);
            this.tbInstallDir.TabIndex = 0;
            this.tbInstallDir.Text = "S:\\Games\\Call Of Cthulhu DCoTE\\";
            this.toolTip1.SetToolTip(this.tbInstallDir, "This should be you install directory ending with \\Call Of Cthulhu DCoTE\\");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DCoTE Install Directory";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(573, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 20);
            this.button4.TabIndex = 2;
            this.button4.Text = "...";
            this.toolTip1.SetToolTip(this.button4, "Pick a directory");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(491, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Scan ...";
            this.toolTip1.SetToolTip(this.button5, "Scan Install dir for input files");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gbHeader
            // 
            this.gbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeader.Controls.Add(this.tbDDSDir);
            this.gbHeader.Controls.Add(this.button6);
            this.gbHeader.Controls.Add(this.label4);
            this.gbHeader.Controls.Add(this.button5);
            this.gbHeader.Controls.Add(this.tbInstallDir);
            this.gbHeader.Controls.Add(this.button4);
            this.gbHeader.Controls.Add(this.label3);
            this.gbHeader.Location = new System.Drawing.Point(12, 12);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(614, 105);
            this.gbHeader.TabIndex = 7;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Configuration";
            // 
            // tbDDSDir
            // 
            this.tbDDSDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDDSDir.Location = new System.Drawing.Point(131, 45);
            this.tbDDSDir.Name = "tbDDSDir";
            this.tbDDSDir.ReadOnly = true;
            this.tbDDSDir.Size = new System.Drawing.Size(435, 20);
            this.tbDDSDir.TabIndex = 4;
            this.tbDDSDir.Text = "S:\\dds\\";
            this.toolTip1.SetToolTip(this.tbDDSDir, "The base directory for texure export/import");
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(572, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 20);
            this.button6.TabIndex = 6;
            this.button6.Text = "...";
            this.toolTip1.SetToolTip(this.button6, "Pick a directory");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DDS file Directory";
            // 
            // pbFiles
            // 
            this.pbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiles.Location = new System.Drawing.Point(12, 369);
            this.pbFiles.Name = "pbFiles";
            this.pbFiles.Size = new System.Drawing.Size(614, 16);
            this.pbFiles.TabIndex = 8;
            this.toolTip1.SetToolTip(this.pbFiles, "Total progress");
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.cbLogEnabled);
            this.gbMain.Controls.Add(this.btnImport);
            this.gbMain.Controls.Add(this.btnExport);
            this.gbMain.Controls.Add(this.lbFiles);
            this.gbMain.Controls.Add(this.lvLogArea);
            this.gbMain.Enabled = false;
            this.gbMain.Location = new System.Drawing.Point(12, 123);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(614, 240);
            this.gbMain.TabIndex = 10;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Texture Import/Export";
            // 
            // cbLogEnabled
            // 
            this.cbLogEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLogEnabled.AutoSize = true;
            this.cbLogEnabled.Checked = true;
            this.cbLogEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLogEnabled.Location = new System.Drawing.Point(480, 215);
            this.cbLogEnabled.Name = "cbLogEnabled";
            this.cbLogEnabled.Size = new System.Drawing.Size(127, 17);
            this.cbLogEnabled.TabIndex = 5;
            this.cbLogEnabled.Text = "Log Enabled (Slower)";
            this.toolTip1.SetToolTip(this.cbLogEnabled, "Log actions to screen much slower)");
            this.cbLogEnabled.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(241, 211);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.toolTip1.SetToolTip(this.btnImport, "Import DDS texures into selected files");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(6, 211);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.toolTip1.SetToolTip(this.btnExport, "Export DDS textures found in selected files");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFiles.Location = new System.Drawing.Point(6, 19);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFiles.Size = new System.Drawing.Size(310, 186);
            this.lbFiles.TabIndex = 2;
            this.toolTip1.SetToolTip(this.lbFiles, "Select files to Export/Import");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 410);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.pbFiles);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.pbProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DCoTETex 1.01";
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLogArea;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.FolderBrowserDialog fbInstallDir;
        private System.Windows.Forms.TextBox tbInstallDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.TextBox tbDDSDir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbFiles;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox cbLogEnabled;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

