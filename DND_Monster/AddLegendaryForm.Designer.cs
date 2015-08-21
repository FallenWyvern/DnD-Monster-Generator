namespace DND_Monster
{
    partial class AddLegendaryForm
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
            this.LegendaryAbilityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Traits = new System.Windows.Forms.ListBox();
            this.TraitDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.SaveTrait = new System.Windows.Forms.Button();
            this.LoadTrait = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LegendaryAbilityName
            // 
            this.LegendaryAbilityName.Location = new System.Drawing.Point(52, 12);
            this.LegendaryAbilityName.Name = "LegendaryAbilityName";
            this.LegendaryAbilityName.Size = new System.Drawing.Size(327, 20);
            this.LegendaryAbilityName.TabIndex = 0;
            this.LegendaryAbilityName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Traits
            // 
            this.Traits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Traits.FormattingEnabled = true;
            this.Traits.Location = new System.Drawing.Point(0, 302);
            this.Traits.Name = "Traits";
            this.Traits.Size = new System.Drawing.Size(379, 160);
            this.Traits.TabIndex = 2;
            this.Traits.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // TraitDescriptionBox
            // 
            this.TraitDescriptionBox.Location = new System.Drawing.Point(0, 62);
            this.TraitDescriptionBox.Name = "TraitDescriptionBox";
            this.TraitDescriptionBox.Size = new System.Drawing.Size(379, 205);
            this.TraitDescriptionBox.TabIndex = 3;
            this.TraitDescriptionBox.Text = "";
            // 
            // SaveTrait
            // 
            this.SaveTrait.Location = new System.Drawing.Point(14, 273);
            this.SaveTrait.Name = "SaveTrait";
            this.SaveTrait.Size = new System.Drawing.Size(75, 23);
            this.SaveTrait.TabIndex = 4;
            this.SaveTrait.Text = "Add Ability";
            this.SaveTrait.UseVisualStyleBackColor = true;
            this.SaveTrait.Click += new System.EventHandler(this.SaveTrait_Click);
            // 
            // LoadTrait
            // 
            this.LoadTrait.Location = new System.Drawing.Point(95, 273);
            this.LoadTrait.Name = "LoadTrait";
            this.LoadTrait.Size = new System.Drawing.Size(75, 23);
            this.LoadTrait.TabIndex = 5;
            this.LoadTrait.Text = "Edit Ability";
            this.LoadTrait.UseVisualStyleBackColor = true;
            this.LoadTrait.Click += new System.EventHandler(this.LoadTrait_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Double Click to Remove";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ability Name";
            // 
            // AddLegendaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadTrait);
            this.Controls.Add(this.SaveTrait);
            this.Controls.Add(this.TraitDescriptionBox);
            this.Controls.Add(this.Traits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LegendaryAbilityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddLegendaryForm";
            this.Text = "Add Legendary Action";
            this.Load += new System.EventHandler(this.AddLegendaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LegendaryAbilityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Traits;
        private System.Windows.Forms.RichTextBox TraitDescriptionBox;
        private System.Windows.Forms.Button SaveTrait;
        private System.Windows.Forms.Button LoadTrait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}