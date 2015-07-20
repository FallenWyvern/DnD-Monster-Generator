namespace DND_Monster
{
    partial class AddAbilityForm
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
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.AbilityNameTextBox = new System.Windows.Forms.TextBox();
            this.AbilityName = new System.Windows.Forms.Label();
            this.AbilityDescription = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionTextBox.Location = new System.Drawing.Point(0, 95);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(284, 166);
            this.DescriptionTextBox.TabIndex = 0;
            this.DescriptionTextBox.Text = "";
            // 
            // AbilityNameTextBox
            // 
            this.AbilityNameTextBox.Location = new System.Drawing.Point(83, 45);
            this.AbilityNameTextBox.Name = "AbilityNameTextBox";
            this.AbilityNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.AbilityNameTextBox.TabIndex = 1;
            this.AbilityNameTextBox.TextChanged += new System.EventHandler(this.UpdatePopOutTitle);
            // 
            // AbilityName
            // 
            this.AbilityName.AutoSize = true;
            this.AbilityName.Location = new System.Drawing.Point(12, 48);
            this.AbilityName.Name = "AbilityName";
            this.AbilityName.Size = new System.Drawing.Size(65, 13);
            this.AbilityName.TabIndex = 2;
            this.AbilityName.Text = "Ability Name";
            // 
            // AbilityDescription
            // 
            this.AbilityDescription.AutoSize = true;
            this.AbilityDescription.Location = new System.Drawing.Point(2, 79);
            this.AbilityDescription.Name = "AbilityDescription";
            this.AbilityDescription.Size = new System.Drawing.Size(60, 13);
            this.AbilityDescription.TabIndex = 3;
            this.AbilityDescription.Text = "Description";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(197, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // AddAbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AbilityDescription);
            this.Controls.Add(this.AbilityName);
            this.Controls.Add(this.AbilityNameTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddAbilityForm";
            this.Text = "AddAbilityForm";
            this.Load += new System.EventHandler(this.AddAbilityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox AbilityNameTextBox;
        private System.Windows.Forms.Label AbilityName;
        private System.Windows.Forms.Label AbilityDescription;
        private System.Windows.Forms.Button SaveButton;
    }
}