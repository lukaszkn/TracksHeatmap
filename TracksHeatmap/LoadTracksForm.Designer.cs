namespace TracksHeatmap
{
    partial class LoadTracksForm
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
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.chkLoadForVisibleMap = new System.Windows.Forms.CheckBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDatesBetween = new System.Windows.Forms.CheckBox();
            this.groupBoxSelectFolderFiles = new System.Windows.Forms.GroupBox();
            this.lblFolderOrFiles = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblProgressPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxSelectFolderFiles.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(6, 43);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(225, 23);
            this.btnLoadFolder.TabIndex = 0;
            this.btnLoadFolder.Text = "Select folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(266, 43);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(217, 23);
            this.btnLoadFiles.TabIndex = 1;
            this.btnLoadFiles.Text = "Select files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.chkLoadForVisibleMap);
            this.groupBoxOptions.Controls.Add(this.dtTo);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.dtFrom);
            this.groupBoxOptions.Controls.Add(this.chkDatesBetween);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 101);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(489, 74);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // chkLoadForVisibleMap
            // 
            this.chkLoadForVisibleMap.AutoSize = true;
            this.chkLoadForVisibleMap.Location = new System.Drawing.Point(6, 46);
            this.chkLoadForVisibleMap.Name = "chkLoadForVisibleMap";
            this.chkLoadForVisibleMap.Size = new System.Drawing.Size(174, 17);
            this.chkLoadForVisibleMap.TabIndex = 4;
            this.chkLoadForVisibleMap.Text = "Load tracks for visible map only";
            this.chkLoadForVisibleMap.UseVisualStyleBackColor = true;
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(266, 16);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(107, 20);
            this.dtTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to:";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(127, 16);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(107, 20);
            this.dtFrom.TabIndex = 1;
            // 
            // chkDatesBetween
            // 
            this.chkDatesBetween.AutoSize = true;
            this.chkDatesBetween.Location = new System.Drawing.Point(6, 19);
            this.chkDatesBetween.Name = "chkDatesBetween";
            this.chkDatesBetween.Size = new System.Drawing.Size(123, 17);
            this.chkDatesBetween.TabIndex = 0;
            this.chkDatesBetween.Text = "Between dates from:";
            this.chkDatesBetween.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectFolderFiles
            // 
            this.groupBoxSelectFolderFiles.Controls.Add(this.lblFolderOrFiles);
            this.groupBoxSelectFolderFiles.Controls.Add(this.btnLoadFolder);
            this.groupBoxSelectFolderFiles.Controls.Add(this.btnLoadFiles);
            this.groupBoxSelectFolderFiles.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelectFolderFiles.Name = "groupBoxSelectFolderFiles";
            this.groupBoxSelectFolderFiles.Size = new System.Drawing.Size(489, 83);
            this.groupBoxSelectFolderFiles.TabIndex = 3;
            this.groupBoxSelectFolderFiles.TabStop = false;
            // 
            // lblFolderOrFiles
            // 
            this.lblFolderOrFiles.AutoSize = true;
            this.lblFolderOrFiles.Location = new System.Drawing.Point(8, 19);
            this.lblFolderOrFiles.Name = "lblFolderOrFiles";
            this.lblFolderOrFiles.Size = new System.Drawing.Size(99, 13);
            this.lblFolderOrFiles.TabIndex = 2;
            this.lblFolderOrFiles.Text = "Select folder or files";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(343, 190);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProgressPercent,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 234);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(513, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(23, 17);
            this.lblProgressPercent.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 16);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.Value = 20;
            // 
            // LoadTracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 256);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBoxSelectFolderFiles);
            this.Controls.Add(this.groupBoxOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoadTracksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load tracks";
            this.Load += new System.EventHandler(this.LoadTracksForm_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxSelectFolderFiles.ResumeLayout(false);
            this.groupBoxSelectFolderFiles.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox chkLoadForVisibleMap;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.CheckBox chkDatesBetween;
        private System.Windows.Forms.GroupBox groupBoxSelectFolderFiles;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.Label lblFolderOrFiles;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressPercent;
    }
}