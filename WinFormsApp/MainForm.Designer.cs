using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class MainForm
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
            this.NumericUpDown = new NumericUpDown();
            this.RandomButton = new Button();
            this.Label = new Label();
            ((System.ComponentModel.ISupportInitialize)this.NumericUpDown).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new Point(12, 12);
            this.NumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new Size(120, 23);
            this.NumericUpDown.TabIndex = 0;
            this.NumericUpDown.ValueChanged += this.NumericUpDown_ValueChanged;
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new Point(154, 57);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new Size(75, 23);
            this.RandomButton.TabIndex = 2;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += this.RandomButton_Click;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new Font("Segoe UI", 16F);
            this.Label.Location = new Point(165, 9);
            this.Label.Name = "Label";
            this.Label.Size = new Size(64, 30);
            this.Label.TabIndex = 3;
            this.Label.Text = "Label";
            this.Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(241, 92);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.NumericUpDown);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)this.NumericUpDown).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private NumericUpDown NumericUpDown;
        private Button RandomButton;
        private Label Label;
    }
}
