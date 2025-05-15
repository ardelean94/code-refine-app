using System.Resources;
using CodeRefineUI.Samples.Setup;

namespace CodeRefineUI.Samples
{
    partial class Sandbox
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
            label1 = new CustomLabel();
            button1 = new CustomButton();
            button2 = new CustomButton();
            label2 = new CustomLabel();
            button3 = new CustomButton();
            label3 = new CustomLabel();
            button4 = new CustomButton();
            label4 = new CustomLabel();
            resources = new ResourceManager(typeof(Sandbox));
            imageSetter = new ImageSetter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = ((System.Drawing.Image)resources.GetObject("diskette"));
            label1.Icon = ((System.Drawing.Icon)resources.GetObject("diskette"));
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(115, 48);
            label1.TabIndex = 0;
            label1.Text = "label1";
            imageSetter.SetImageKey(label1);
            // 
            // button1
            // 
            button1.Location = new Point(215, 40);
            button1.Name = "button1";
            button1.Size = new Size(188, 59);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            imageSetter.SetImageKey(button1);
            // 
            // button2
            // 
            button2.Image = ((System.Drawing.Image)resources.GetObject("diskette"));
            button2.Icon = ((System.Drawing.Icon)resources.GetObject("diskette"));
            button2.Location = new Point(215, 131);
            button2.Name = "button2";
            button2.Size = new Size(188, 59);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 131);
            label2.Name = "label2";
            label2.Size = new Size(115, 48);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button3
            // 
            button3.Image = ((System.Drawing.Image)resources.GetObject("diskette"));
            button3.Icon = ((System.Drawing.Icon)resources.GetObject("diskette"));
            button3.Location = new Point(634, 131);
            button3.Name = "button3";
            button3.Size = new Size(188, 59);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            imageSetter.SetImageKey(button3);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 131);
            label3.Image = ((System.Drawing.Image)resources.GetObject("diskette"));
            label3.Icon = ((System.Drawing.Icon)resources.GetObject("diskette"));
            label3.Name = "label3";
            label3.Size = new Size(115, 48);
            label3.TabIndex = 6;
            imageSetter.SetImageKey(label3);
            label3.Text = "label3";
            // 
            // button4
            // 
            button4.Location = new Point(634, 40);
            button4.Name = "button4";
            button4.Size = new Size(188, 59);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = ((System.Drawing.Image)resources.GetObject("diskette"));
            label4.Icon = ((System.Drawing.Icon)resources.GetObject("diskette"));
            label4.Location = new Point(465, 40);
            label4.Name = "label4";
            label4.Size = new Size(115, 48);
            label4.TabIndex = 4;
            label4.Text = "label4";
            imageSetter.SetImageKey(label4);
            // 
            // Sandbox
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 342);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Sandbox";
            Text = "Sandbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomLabel label1;
        private CustomButton button1;
        private CustomButton button2;
        private CustomLabel label2;
        private CustomButton button3;
        private CustomLabel label3;
        private CustomButton button4;
        private CustomLabel label4;
        private ResourceManager resources;
        private ImageSetter imageSetter;
    }
}