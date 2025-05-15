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
            browseFolder = new FolderBrowserDialog();
            selectedLocationLabel = new Label();
            patternLabel = new Label();
            patternText = new TextBox();
            textBox1 = new TextBox();
            regexPatternLabel = new Label();
            processFiles = new Button();
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
            // patternLabel
            // 
            patternLabel.AutoSize = true;
            patternLabel.Location = new Point(12, 172);
            patternLabel.Name = "patternLabel";
            patternLabel.Size = new Size(133, 48);
            patternLabel.TabIndex = 3;
            patternLabel.Text = "Pattern";
            // 
            // patternText
            // 
            patternText.Location = new Point(12, 234);
            patternText.Name = "patternText";
            patternText.Size = new Size(995, 55);
            patternText.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(995, 55);
            textBox1.TabIndex = 6;
            // 
            // regexPatternLabel
            // 
            regexPatternLabel.AutoSize = true;
            regexPatternLabel.Location = new Point(12, 324);
            regexPatternLabel.Name = "regexPatternLabel";
            regexPatternLabel.Size = new Size(275, 48);
            regexPatternLabel.TabIndex = 5;
            regexPatternLabel.Text = "Pattern as regex";
            // 
            // processFiles
            // 
            processFiles.Location = new Point(12, 490);
            processFiles.Name = "processFiles";
            processFiles.Size = new Size(251, 67);
            processFiles.TabIndex = 7;
            processFiles.Text = "Process files";
            processFiles.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 650);
            Controls.Add(processFiles);
            Controls.Add(textBox1);
            Controls.Add(regexPatternLabel);
            Controls.Add(patternText);
            Controls.Add(patternLabel);
            Controls.Add(selectedLocationLabel);
            Controls.Add(browseFiles);
            Controls.Add(selectedLocation);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            MaximizeBox = false;
            MaximumSize = new Size(1362, 650);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox selectedLocation;
        private Button browseFiles;
        private FolderBrowserDialog browseFolder;
        private Label selectedLocationLabel;
        private Label patternLabel;
        private TextBox patternText;
        private TextBox textBox1;
        private Label regexPatternLabel;
        private Button processFiles;
    }
}
