namespace CodeRefineUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selectedLocation = new TextBox();
            browseFiles = new Button();
            browseFolderDialog = new FolderBrowserDialog();
            selectedLocationLabel = new Label();
            regexPatternLabel = new Label();
            processFiles = new Button();
            patternOptions = new ComboBox();
            statusBar = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            conditionLabel = new Label();
            conditionOptions = new ComboBox();
            fileTypeOptions = new ComboBox();
            fileTypeLabel = new Label();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // selectedLocation
            // 
            selectedLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectedLocation.Location = new Point(12, 79);
            selectedLocation.Name = "selectedLocation";
            selectedLocation.Size = new Size(991, 55);
            selectedLocation.TabIndex = 0;
            // 
            // browseFiles
            // 
            browseFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browseFiles.Location = new Point(1009, 79);
            browseFiles.Name = "browseFiles";
            browseFiles.Size = new Size(236, 55);
            browseFiles.TabIndex = 1;
            browseFiles.Text = "Locate Files";
            browseFiles.UseVisualStyleBackColor = true;
            browseFiles.Click += browseFiles_Click;
            // 
            // selectedLocationLabel
            // 
            selectedLocationLabel.AutoSize = true;
            selectedLocationLabel.Location = new Point(12, 28);
            selectedLocationLabel.Name = "selectedLocationLabel";
            selectedLocationLabel.Size = new Size(739, 48);
            selectedLocationLabel.TabIndex = 2;
            selectedLocationLabel.Text = "Select the folder where the files can be found";
            // 
            // regexPatternLabel
            // 
            regexPatternLabel.AutoSize = true;
            regexPatternLabel.Location = new Point(12, 395);
            regexPatternLabel.Name = "regexPatternLabel";
            regexPatternLabel.Size = new Size(271, 48);
            regexPatternLabel.TabIndex = 5;
            regexPatternLabel.Text = "Remove Pattern";
            // 
            // processFiles
            // 
            processFiles.Location = new Point(12, 522);
            processFiles.Name = "processFiles";
            processFiles.Size = new Size(251, 67);
            processFiles.TabIndex = 7;
            processFiles.Text = "Process files";
            processFiles.UseVisualStyleBackColor = true;
            processFiles.Click += processFiles_Click;
            // 
            // patternOptions
            // 
            patternOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patternOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            patternOptions.FormattingEnabled = true;
            patternOptions.Items.AddRange(new object[] { "(\\w+)\\.Image = \\(\\(System\\.Drawing\\.Image\\)", "(\\w+)\\.Icon = \\(\\(System\\.Drawing\\.Icon\\)" });
            patternOptions.Location = new Point(12, 446);
            patternOptions.Name = "patternOptions";
            patternOptions.Size = new Size(995, 56);
            patternOptions.TabIndex = 8;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(24, 24);
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusBar.Location = new Point(0, 621);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1258, 39);
            statusBar.TabIndex = 10;
            statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(95, 32);
            toolStripStatusLabel.Text = "Waiting";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(12, 273);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(388, 48);
            conditionLabel.TabIndex = 11;
            conditionLabel.Text = "When Condition Found";
            // 
            // conditionOptions
            // 
            conditionOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            conditionOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            conditionOptions.FormattingEnabled = true;
            conditionOptions.Items.AddRange(new object[] { ".SetImageKey(" });
            conditionOptions.Location = new Point(12, 324);
            conditionOptions.Name = "conditionOptions";
            conditionOptions.Size = new Size(995, 56);
            conditionOptions.TabIndex = 12;
            // 
            // fileTypeOptions
            // 
            fileTypeOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileTypeOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            fileTypeOptions.FormattingEnabled = true;
            fileTypeOptions.Items.AddRange(new object[] { "*.Designer.cs" });
            fileTypeOptions.Location = new Point(12, 203);
            fileTypeOptions.Name = "fileTypeOptions";
            fileTypeOptions.Size = new Size(995, 56);
            fileTypeOptions.TabIndex = 14;
            // 
            // fileTypeLabel
            // 
            fileTypeLabel.AutoSize = true;
            fileTypeLabel.Location = new Point(12, 152);
            fileTypeLabel.Name = "fileTypeLabel";
            fileTypeLabel.Size = new Size(159, 48);
            fileTypeLabel.TabIndex = 13;
            fileTypeLabel.Text = "File Type";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 660);
            Controls.Add(fileTypeOptions);
            Controls.Add(fileTypeLabel);
            Controls.Add(conditionOptions);
            Controls.Add(conditionLabel);
            Controls.Add(statusBar);
            Controls.Add(patternOptions);
            Controls.Add(processFiles);
            Controls.Add(regexPatternLabel);
            Controls.Add(selectedLocationLabel);
            Controls.Add(browseFiles);
            Controls.Add(selectedLocation);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox selectedLocation;
        private Button browseFiles;
        private FolderBrowserDialog browseFolderDialog;
        private Label selectedLocationLabel;
        private Label regexPatternLabel;
        private Button processFiles;
        private ComboBox patternOptions;
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Label conditionLabel;
        private ComboBox conditionOptions;
        private ComboBox fileTypeOptions;
        private Label fileTypeLabel;
    }
}
