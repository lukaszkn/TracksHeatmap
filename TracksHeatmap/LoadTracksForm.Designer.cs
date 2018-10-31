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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSpeedTo = new System.Windows.Forms.NumericUpDown();
            this.numSpeedFrom = new System.Windows.Forms.NumericUpDown();
            this.chkAvgSpeedBetween = new System.Windows.Forms.CheckBox();
            this.txtMustContain = new System.Windows.Forms.TextBox();
            this.chkFilenameMustContain = new System.Windows.Forms.CheckBox();
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
            this.chkCenterTracks = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedFrom)).BeginInit();
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
            this.groupBoxOptions.Controls.Add(this.chkCenterTracks);
            this.groupBoxOptions.Controls.Add(this.label3);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.numSpeedTo);
            this.groupBoxOptions.Controls.Add(this.numSpeedFrom);
            this.groupBoxOptions.Controls.Add(this.chkAvgSpeedBetween);
            this.groupBoxOptions.Controls.Add(this.txtMustContain);
            this.groupBoxOptions.Controls.Add(this.chkFilenameMustContain);
            this.groupBoxOptions.Controls.Add(this.chkLoadForVisibleMap);
            this.groupBoxOptions.Controls.Add(this.dtTo);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.dtFrom);
            this.groupBoxOptions.Controls.Add(this.chkDatesBetween);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 101);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(489, 153);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "km/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "and";
            // 
            // numSpeedTo
            // 
            this.numSpeedTo.DecimalPlaces = 1;
            this.numSpeedTo.Location = new System.Drawing.Point(242, 95);
            this.numSpeedTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpeedTo.Name = "numSpeedTo";
            this.numSpeedTo.Size = new System.Drawing.Size(59, 20);
            this.numSpeedTo.TabIndex = 9;
            this.numSpeedTo.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // numSpeedFrom
            // 
            this.numSpeedFrom.DecimalPlaces = 1;
            this.numSpeedFrom.Location = new System.Drawing.Point(146, 95);
            this.numSpeedFrom.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numSpeedFrom.Name = "numSpeedFrom";
            this.numSpeedFrom.Size = new System.Drawing.Size(59, 20);
            this.numSpeedFrom.TabIndex = 8;
            // 
            // chkAvgSpeedBetween
            // 
            this.chkAvgSpeedBetween.AutoSize = true;
            this.chkAvgSpeedBetween.Location = new System.Drawing.Point(6, 95);
            this.chkAvgSpeedBetween.Name = "chkAvgSpeedBetween";
            this.chkAvgSpeedBetween.Size = new System.Drawing.Size(127, 17);
            this.chkAvgSpeedBetween.TabIndex = 7;
            this.chkAvgSpeedBetween.Text = "Avg. speed between:";
            this.chkAvgSpeedBetween.UseVisualStyleBackColor = true;
            // 
            // txtMustContain
            // 
            this.txtMustContain.Location = new System.Drawing.Point(146, 69);
            this.txtMustContain.Name = "txtMustContain";
            this.txtMustContain.Size = new System.Drawing.Size(100, 20);
            this.txtMustContain.TabIndex = 6;
            this.txtMustContain.Text = "walk";
            // 
            // chkFilenameMustContain
            // 
            this.chkFilenameMustContain.AutoSize = true;
            this.chkFilenameMustContain.Location = new System.Drawing.Point(6, 71);
            this.chkFilenameMustContain.Name = "chkFilenameMustContain";
            this.chkFilenameMustContain.Size = new System.Drawing.Size(134, 17);
            this.chkFilenameMustContain.TabIndex = 5;
            this.chkFilenameMustContain.Text = "Filename must contain:";
            this.chkFilenameMustContain.UseVisualStyleBackColor = true;
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
            this.btnLoad.Location = new System.Drawing.Point(345, 282);
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
            this.btnCancel.Location = new System.Drawing.Point(426, 282);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
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
            // chkCenterTracks
            // 
            this.chkCenterTracks.AutoSize = true;
            this.chkCenterTracks.Checked = true;
            this.chkCenterTracks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCenterTracks.Location = new System.Drawing.Point(6, 120);
            this.chkCenterTracks.Name = "chkCenterTracks";
            this.chkCenterTracks.Size = new System.Drawing.Size(193, 17);
            this.chkCenterTracks.TabIndex = 12;
            this.chkCenterTracks.Text = "Center tracks on maps after loading";
            this.chkCenterTracks.UseVisualStyleBackColor = true;
            // 
            // LoadTracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 354);
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
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedFrom)).EndInit();
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
        private System.Windows.Forms.CheckBox chkFilenameMustContain;
        private System.Windows.Forms.TextBox txtMustContain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSpeedTo;
        private System.Windows.Forms.NumericUpDown numSpeedFrom;
        private System.Windows.Forms.CheckBox chkAvgSpeedBetween;
        private System.Windows.Forms.CheckBox chkCenterTracks;
    }
}