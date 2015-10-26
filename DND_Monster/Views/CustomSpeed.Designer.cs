namespace DND_Monster
{
    partial class CustomSpeed
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
            this.SpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedDescription = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.HoverCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustomCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeedUpDown
            // 
            this.SpeedUpDown.Location = new System.Drawing.Point(56, 7);
            this.SpeedUpDown.Name = "SpeedUpDown";
            this.SpeedUpDown.Size = new System.Drawing.Size(71, 20);
            this.SpeedUpDown.TabIndex = 0;
            // 
            // SpeedDescription
            // 
            this.SpeedDescription.Location = new System.Drawing.Point(12, 63);
            this.SpeedDescription.Name = "SpeedDescription";
            this.SpeedDescription.Size = new System.Drawing.Size(260, 197);
            this.SpeedDescription.TabIndex = 1;
            this.SpeedDescription.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 47);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(12, 9);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.SpeedLabel.TabIndex = 4;
            this.SpeedLabel.Text = "Speed";
            // 
            // HoverCheckBox
            // 
            this.HoverCheckBox.AutoSize = true;
            this.HoverCheckBox.Enabled = false;
            this.HoverCheckBox.Location = new System.Drawing.Point(217, 8);
            this.HoverCheckBox.Name = "HoverCheckBox";
            this.HoverCheckBox.Size = new System.Drawing.Size(55, 17);
            this.HoverCheckBox.TabIndex = 5;
            this.HoverCheckBox.Text = "Hover";
            this.HoverCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(116, 37);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // CustomCancelButton
            // 
            this.CustomCancelButton.Location = new System.Drawing.Point(197, 37);
            this.CustomCancelButton.Name = "CustomCancelButton";
            this.CustomCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CustomCancelButton.TabIndex = 7;
            this.CustomCancelButton.Text = "Cancel";
            this.CustomCancelButton.UseVisualStyleBackColor = true;
            this.CustomCancelButton.Click += new System.EventHandler(this.Cancel);
            // 
            // CustomSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CustomCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HoverCheckBox);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SpeedDescription);
            this.Controls.Add(this.SpeedUpDown);
            this.Name = "CustomSpeed";
            this.Text = "Custom Speed";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label SpeedLabel;
        public System.Windows.Forms.NumericUpDown SpeedUpDown;
        public System.Windows.Forms.RichTextBox SpeedDescription;
        public System.Windows.Forms.CheckBox HoverCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CustomCancelButton;
    }
}