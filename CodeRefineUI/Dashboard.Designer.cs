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
            regexPatternOptions = new ComboBox();
            SuspendLayout();
            // 
            // selectedLocation
            // 
            selectedLocation.Location = new Point(12, 93);
            selectedLocation.Name = "selectedLocation";
            selectedLocation.Size = new Size(995, 55);
            selectedLocation.TabIndex = 0;
            // 
            // browseFiles
            // 
            browseFiles.Location = new Point(1013, 93);
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
            regexPatternLabel.Location = new Point(12, 171);
            regexPatternLabel.Name = "regexPatternLabel";
            regexPatternLabel.Size = new Size(242, 48);
            regexPatternLabel.TabIndex = 5;
            regexPatternLabel.Text = "Regex pattern";
            // 
            // processFiles
            // 
            processFiles.Location = new Point(12, 322);
            processFiles.Name = "processFiles";
            processFiles.Size = new Size(251, 67);
            processFiles.TabIndex = 7;
            processFiles.Text = "Process files";
            processFiles.UseVisualStyleBackColor = true;
            processFiles.Click += processFiles_Click;
            // 
            // regexPatternOptions
            // 
            regexPatternOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            regexPatternOptions.FormattingEnabled = true;
            regexPatternOptions.Items.AddRange(new object[] { "(\\w+)\\.Image = \\(\\(System\\.Drawing\\.Image\\)", "(\\w+)\\.Icon = \\(\\(System\\.Drawing\\.Icon\\)" });
            regexPatternOptions.Location = new Point(12, 238);
            regexPatternOptions.Name = "regexPatternOptions";
            regexPatternOptions.Size = new Size(995, 56);
            regexPatternOptions.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 419);
            Controls.Add(regexPatternOptions);
            Controls.Add(processFiles);
            Controls.Add(regexPatternLabel);
            Controls.Add(selectedLocationLabel);
            Controls.Add(browseFiles);
            Controls.Add(selectedLocation);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            MaximizeBox = false;
            MaximumSize = new Size(1284, 475);
            Name = "Dashboard";
            Text = "Dashboard";
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
        private ComboBox regexPatternOptions;
    }
}
