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
            this.NameLabel = new System.Windows.Forms.Label();
            this.Traits = new System.Windows.Forms.ListBox();
            this.TraitDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.SaveTrait = new System.Windows.Forms.Button();
            this.LoadTrait = new System.Windows.Forms.Button();
            this.ListHelperLabel = new System.Windows.Forms.Label();
            this.AbilityName = new System.Windows.Forms.TextBox();
            this.AbilityNameLabel = new System.Windows.Forms.Label();
            this.numberOfLegendaryActions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLegendaryActions)).BeginInit();
            this.SuspendLayout();
            // 
            // LegendaryAbilityName
            // 
            this.LegendaryAbilityName.Location = new System.Drawing.Point(52, 12);
            this.LegendaryAbilityName.Name = "LegendaryAbilityName";
            this.LegendaryAbilityName.Size = new System.Drawing.Size(218, 20);
            this.LegendaryAbilityName.TabIndex = 0;
            this.LegendaryAbilityName.TextChanged += new System.EventHandler(this.UpdateTitle);
            this.LegendaryAbilityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterColon);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // Traits
            // 
            this.Traits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Traits.FormattingEnabled = true;
            this.Traits.Location = new System.Drawing.Point(0, 302);
            this.Traits.Name = "Traits";
            this.Traits.Size = new System.Drawing.Size(379, 160);
            this.Traits.TabIndex = 3;
            this.Traits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TraitsList_KeyDown);
            this.Traits.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RemoveTrait);
            // 
            // TraitDescriptionBox
            // 
            this.TraitDescriptionBox.Location = new System.Drawing.Point(0, 62);
            this.TraitDescriptionBox.Name = "TraitDescriptionBox";
            this.TraitDescriptionBox.Size = new System.Drawing.Size(379, 205);
            this.TraitDescriptionBox.TabIndex = 2;
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
            // ListHelperLabel
            // 
            this.ListHelperLabel.AutoSize = true;
            this.ListHelperLabel.Location = new System.Drawing.Point(257, 278);
            this.ListHelperLabel.Name = "ListHelperLabel";
            this.ListHelperLabel.Size = new System.Drawing.Size(122, 13);
            this.ListHelperLabel.TabIndex = 6;
            this.ListHelperLabel.Text = "Double Click to Remove";
            // 
            // AbilityName
            // 
            this.AbilityName.Location = new System.Drawing.Point(82, 38);
            this.AbilityName.Name = "AbilityName";
            this.AbilityName.Size = new System.Drawing.Size(188, 20);
            this.AbilityName.TabIndex = 1;
            this.AbilityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterColon);
            // 
            // AbilityNameLabel
            // 
            this.AbilityNameLabel.AutoSize = true;
            this.AbilityNameLabel.Location = new System.Drawing.Point(11, 41);
            this.AbilityNameLabel.Name = "AbilityNameLabel";
            this.AbilityNameLabel.Size = new System.Drawing.Size(65, 13);
            this.AbilityNameLabel.TabIndex = 8;
            this.AbilityNameLabel.Text = "Ability Name";
            // 
            // numberOfLegendaryActions
            // 
            this.numberOfLegendaryActions.Location = new System.Drawing.Point(276, 39);
            this.numberOfLegendaryActions.Name = "numberOfLegendaryActions";
            this.numberOfLegendaryActions.Size = new System.Drawing.Size(91, 20);
            this.numberOfLegendaryActions.TabIndex = 9;
            this.numberOfLegendaryActions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Actions";
            // 
            // AddLegendaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfLegendaryActions);
            this.Controls.Add(this.AbilityNameLabel);
            this.Controls.Add(this.ListHelperLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AbilityName);
            this.Controls.Add(this.LoadTrait);
            this.Controls.Add(this.SaveTrait);
            this.Controls.Add(this.TraitDescriptionBox);
            this.Controls.Add(this.Traits);
            this.Controls.Add(this.LegendaryAbilityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddLegendaryForm";
            this.Text = "Add Legendary Action";
            this.Load += new System.EventHandler(this.AddLegendaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLegendaryActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox LegendaryAbilityName;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.ListBox Traits;
        public System.Windows.Forms.RichTextBox TraitDescriptionBox;
        public System.Windows.Forms.Button SaveTrait;
        public System.Windows.Forms.Button LoadTrait;
        public System.Windows.Forms.Label ListHelperLabel;
        public System.Windows.Forms.TextBox AbilityName;
        public System.Windows.Forms.Label AbilityNameLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numberOfLegendaryActions;

    }
}