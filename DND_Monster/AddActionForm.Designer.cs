namespace DND_Monster
{
    partial class AddActionForm
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
            this.ReactionSave = new System.Windows.Forms.Button();
            this.AttackTypeDropdown = new System.Windows.Forms.ComboBox();
            this.AttackType = new System.Windows.Forms.Label();
            this.AttackBonusUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttackToHitBonus = new System.Windows.Forms.Label();
            this.RangeUpDownClose = new System.Windows.Forms.NumericUpDown();
            this.HitDamageEffect = new System.Windows.Forms.TextBox();
            this.AttackHitEffect = new System.Windows.Forms.Label();
            this.AttackNameField = new System.Windows.Forms.TextBox();
            this.AttackName = new System.Windows.Forms.Label();
            this.AttackTargetField = new System.Windows.Forms.TextBox();
            this.AttackTarget = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.RangeUpDownFar = new System.Windows.Forms.NumericUpDown();
            this.Reach = new System.Windows.Forms.Label();
            this.ReachUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttackRange = new System.Windows.Forms.Label();
            this.HitDamageType = new System.Windows.Forms.ComboBox();
            this.HitDiceBonusDamage = new System.Windows.Forms.NumericUpDown();
            this.HitDiceType = new System.Windows.Forms.ComboBox();
            this.HitNumberOfDice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AttackAbilityDescription = new System.Windows.Forms.Label();
            this.ActionName = new System.Windows.Forms.Label();
            this.AttackAbilityNameField = new System.Windows.Forms.TextBox();
            this.AttackAbilityDescriptionField = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReactionName = new System.Windows.Forms.TextBox();
            this.ReactionDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttackBonusUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeUpDownClose)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeUpDownFar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReachUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitDiceBonusDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitNumberOfDice)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReactionSave
            // 
            this.ReactionSave.Location = new System.Drawing.Point(118, 289);
            this.ReactionSave.Name = "ReactionSave";
            this.ReactionSave.Size = new System.Drawing.Size(75, 23);
            this.ReactionSave.TabIndex = 0;
            this.ReactionSave.Text = "Save";
            this.ReactionSave.UseVisualStyleBackColor = true;
            this.ReactionSave.Click += new System.EventHandler(this.Save);
            // 
            // AttackTypeDropdown
            // 
            this.AttackTypeDropdown.FormattingEnabled = true;
            this.AttackTypeDropdown.Items.AddRange(new object[] {
            "Melee Weapon Attack",
            "Ranged Weapon Attack",
            "Melee or Ranged Weapon Attack"});
            this.AttackTypeDropdown.Location = new System.Drawing.Point(49, 29);
            this.AttackTypeDropdown.Name = "AttackTypeDropdown";
            this.AttackTypeDropdown.Size = new System.Drawing.Size(239, 21);
            this.AttackTypeDropdown.TabIndex = 1;
            // 
            // AttackType
            // 
            this.AttackType.AutoSize = true;
            this.AttackType.Location = new System.Drawing.Point(3, 32);
            this.AttackType.Name = "AttackType";
            this.AttackType.Size = new System.Drawing.Size(31, 13);
            this.AttackType.TabIndex = 2;
            this.AttackType.Text = "Type";
            // 
            // AttackBonusUpDown
            // 
            this.AttackBonusUpDown.Location = new System.Drawing.Point(50, 56);
            this.AttackBonusUpDown.Name = "AttackBonusUpDown";
            this.AttackBonusUpDown.Size = new System.Drawing.Size(43, 20);
            this.AttackBonusUpDown.TabIndex = 2;
            // 
            // AttackToHitBonus
            // 
            this.AttackToHitBonus.AutoSize = true;
            this.AttackToHitBonus.Location = new System.Drawing.Point(3, 58);
            this.AttackToHitBonus.Name = "AttackToHitBonus";
            this.AttackToHitBonus.Size = new System.Drawing.Size(37, 13);
            this.AttackToHitBonus.TabIndex = 4;
            this.AttackToHitBonus.Text = "Bonus";
            // 
            // RangeUpDownClose
            // 
            this.RangeUpDownClose.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RangeUpDownClose.Location = new System.Drawing.Point(50, 188);
            this.RangeUpDownClose.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RangeUpDownClose.Name = "RangeUpDownClose";
            this.RangeUpDownClose.Size = new System.Drawing.Size(70, 20);
            this.RangeUpDownClose.TabIndex = 10;
            this.RangeUpDownClose.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // HitDamageEffect
            // 
            this.HitDamageEffect.Location = new System.Drawing.Point(50, 136);
            this.HitDamageEffect.Name = "HitDamageEffect";
            this.HitDamageEffect.Size = new System.Drawing.Size(238, 20);
            this.HitDamageEffect.TabIndex = 8;
            // 
            // AttackHitEffect
            // 
            this.AttackHitEffect.AutoSize = true;
            this.AttackHitEffect.Location = new System.Drawing.Point(3, 126);
            this.AttackHitEffect.Name = "AttackHitEffect";
            this.AttackHitEffect.Size = new System.Drawing.Size(40, 13);
            this.AttackHitEffect.TabIndex = 8;
            this.AttackHitEffect.Text = "On Hit:";
            // 
            // AttackNameField
            // 
            this.AttackNameField.Location = new System.Drawing.Point(50, 3);
            this.AttackNameField.Name = "AttackNameField";
            this.AttackNameField.Size = new System.Drawing.Size(238, 20);
            this.AttackNameField.TabIndex = 0;
            // 
            // AttackName
            // 
            this.AttackName.AutoSize = true;
            this.AttackName.Location = new System.Drawing.Point(3, 6);
            this.AttackName.Name = "AttackName";
            this.AttackName.Size = new System.Drawing.Size(35, 13);
            this.AttackName.TabIndex = 10;
            this.AttackName.Text = "Name";
            // 
            // AttackTargetField
            // 
            this.AttackTargetField.Location = new System.Drawing.Point(49, 82);
            this.AttackTargetField.Name = "AttackTargetField";
            this.AttackTargetField.Size = new System.Drawing.Size(238, 20);
            this.AttackTargetField.TabIndex = 3;
            // 
            // AttackTarget
            // 
            this.AttackTarget.AutoSize = true;
            this.AttackTarget.Location = new System.Drawing.Point(3, 85);
            this.AttackTarget.Name = "AttackTarget";
            this.AttackTarget.Size = new System.Drawing.Size(41, 13);
            this.AttackTarget.TabIndex = 12;
            this.AttackTarget.Text = "Target:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(296, 287);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RangeUpDownFar);
            this.tabPage1.Controls.Add(this.Reach);
            this.tabPage1.Controls.Add(this.ReachUpDown);
            this.tabPage1.Controls.Add(this.AttackRange);
            this.tabPage1.Controls.Add(this.HitDamageType);
            this.tabPage1.Controls.Add(this.HitDiceBonusDamage);
            this.tabPage1.Controls.Add(this.HitDiceType);
            this.tabPage1.Controls.Add(this.HitNumberOfDice);
            this.tabPage1.Controls.Add(this.AttackName);
            this.tabPage1.Controls.Add(this.AttackTarget);
            this.tabPage1.Controls.Add(this.AttackTargetField);
            this.tabPage1.Controls.Add(this.AttackTypeDropdown);
            this.tabPage1.Controls.Add(this.AttackType);
            this.tabPage1.Controls.Add(this.AttackNameField);
            this.tabPage1.Controls.Add(this.AttackBonusUpDown);
            this.tabPage1.Controls.Add(this.AttackHitEffect);
            this.tabPage1.Controls.Add(this.AttackToHitBonus);
            this.tabPage1.Controls.Add(this.HitDamageEffect);
            this.tabPage1.Controls.Add(this.RangeUpDownClose);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(288, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weapon Attack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "/";
            // 
            // RangeUpDownFar
            // 
            this.RangeUpDownFar.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RangeUpDownFar.Location = new System.Drawing.Point(141, 188);
            this.RangeUpDownFar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RangeUpDownFar.Name = "RangeUpDownFar";
            this.RangeUpDownFar.Size = new System.Drawing.Size(70, 20);
            this.RangeUpDownFar.TabIndex = 11;
            this.RangeUpDownFar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Reach
            // 
            this.Reach.AutoSize = true;
            this.Reach.Location = new System.Drawing.Point(5, 164);
            this.Reach.Name = "Reach";
            this.Reach.Size = new System.Drawing.Size(39, 13);
            this.Reach.TabIndex = 20;
            this.Reach.Text = "Reach";
            // 
            // ReachUpDown
            // 
            this.ReachUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ReachUpDown.Location = new System.Drawing.Point(50, 162);
            this.ReachUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ReachUpDown.Name = "ReachUpDown";
            this.ReachUpDown.Size = new System.Drawing.Size(70, 20);
            this.ReachUpDown.TabIndex = 9;
            this.ReachUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AttackRange
            // 
            this.AttackRange.AutoSize = true;
            this.AttackRange.Location = new System.Drawing.Point(5, 190);
            this.AttackRange.Name = "AttackRange";
            this.AttackRange.Size = new System.Drawing.Size(39, 13);
            this.AttackRange.TabIndex = 18;
            this.AttackRange.Text = "Range";
            // 
            // HitDamageType
            // 
            this.HitDamageType.FormattingEnabled = true;
            this.HitDamageType.Items.AddRange(new object[] {
            "Acid",
            "Bludgeoning",
            "Cold",
            "Fire",
            "Force",
            "Lightning",
            "Necrotic",
            "Piercing",
            "Poison",
            "Psychic",
            "Radiant",
            "Slashing",
            "Thunder"});
            this.HitDamageType.Location = new System.Drawing.Point(196, 108);
            this.HitDamageType.Name = "HitDamageType";
            this.HitDamageType.Size = new System.Drawing.Size(91, 21);
            this.HitDamageType.TabIndex = 7;
            // 
            // HitDiceBonusDamage
            // 
            this.HitDiceBonusDamage.Location = new System.Drawing.Point(149, 110);
            this.HitDiceBonusDamage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.HitDiceBonusDamage.Name = "HitDiceBonusDamage";
            this.HitDiceBonusDamage.Size = new System.Drawing.Size(44, 20);
            this.HitDiceBonusDamage.TabIndex = 6;
            // 
            // HitDiceType
            // 
            this.HitDiceType.FormattingEnabled = true;
            this.HitDiceType.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.HitDiceType.Location = new System.Drawing.Point(93, 109);
            this.HitDiceType.Name = "HitDiceType";
            this.HitDiceType.Size = new System.Drawing.Size(47, 21);
            this.HitDiceType.TabIndex = 5;
            this.HitDiceType.Text = "d4";
            // 
            // HitNumberOfDice
            // 
            this.HitNumberOfDice.Location = new System.Drawing.Point(49, 109);
            this.HitNumberOfDice.Name = "HitNumberOfDice";
            this.HitNumberOfDice.Size = new System.Drawing.Size(38, 20);
            this.HitNumberOfDice.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "+";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AttackAbilityDescription);
            this.tabPage2.Controls.Add(this.ActionName);
            this.tabPage2.Controls.Add(this.AttackAbilityNameField);
            this.tabPage2.Controls.Add(this.AttackAbilityDescriptionField);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(288, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Action";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AttackAbilityDescription
            // 
            this.AttackAbilityDescription.AutoSize = true;
            this.AttackAbilityDescription.Location = new System.Drawing.Point(6, 32);
            this.AttackAbilityDescription.Name = "AttackAbilityDescription";
            this.AttackAbilityDescription.Size = new System.Drawing.Size(60, 13);
            this.AttackAbilityDescription.TabIndex = 8;
            this.AttackAbilityDescription.Text = "Description";
            // 
            // ActionName
            // 
            this.ActionName.AutoSize = true;
            this.ActionName.Location = new System.Drawing.Point(4, 9);
            this.ActionName.Name = "ActionName";
            this.ActionName.Size = new System.Drawing.Size(68, 13);
            this.ActionName.TabIndex = 7;
            this.ActionName.Text = "Action Name";
            // 
            // AttackAbilityNameField
            // 
            this.AttackAbilityNameField.Location = new System.Drawing.Point(75, 6);
            this.AttackAbilityNameField.Name = "AttackAbilityNameField";
            this.AttackAbilityNameField.Size = new System.Drawing.Size(205, 20);
            this.AttackAbilityNameField.TabIndex = 0;
            // 
            // AttackAbilityDescriptionField
            // 
            this.AttackAbilityDescriptionField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AttackAbilityDescriptionField.Location = new System.Drawing.Point(3, 48);
            this.AttackAbilityDescriptionField.Name = "AttackAbilityDescriptionField";
            this.AttackAbilityDescriptionField.Size = new System.Drawing.Size(282, 210);
            this.AttackAbilityDescriptionField.TabIndex = 1;
            this.AttackAbilityDescriptionField.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ReactionName);
            this.tabPage3.Controls.Add(this.ReactionDescription);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(288, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reaction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reaction Name";
            // 
            // ReactionName
            // 
            this.ReactionName.Location = new System.Drawing.Point(91, 4);
            this.ReactionName.Name = "ReactionName";
            this.ReactionName.Size = new System.Drawing.Size(189, 20);
            this.ReactionName.TabIndex = 9;
            // 
            // ReactionDescription
            // 
            this.ReactionDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReactionDescription.Location = new System.Drawing.Point(3, 48);
            this.ReactionDescription.Name = "ReactionDescription";
            this.ReactionDescription.Size = new System.Drawing.Size(282, 210);
            this.ReactionDescription.TabIndex = 10;
            this.ReactionDescription.Text = "";
            // 
            // AddActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 312);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ReactionSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddActionForm";
            this.Text = "Add Actions";
            ((System.ComponentModel.ISupportInitialize)(this.AttackBonusUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeUpDownClose)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeUpDownFar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReachUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitDiceBonusDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitNumberOfDice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReactionSave;
        private System.Windows.Forms.ComboBox AttackTypeDropdown;
        private System.Windows.Forms.Label AttackType;
        private System.Windows.Forms.NumericUpDown AttackBonusUpDown;
        private System.Windows.Forms.Label AttackToHitBonus;
        private System.Windows.Forms.NumericUpDown RangeUpDownClose;
        private System.Windows.Forms.TextBox HitDamageEffect;
        private System.Windows.Forms.Label AttackHitEffect;
        private System.Windows.Forms.TextBox AttackNameField;
        private System.Windows.Forms.Label AttackName;
        private System.Windows.Forms.TextBox AttackTargetField;
        private System.Windows.Forms.Label AttackTarget;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label AttackAbilityDescription;
        private System.Windows.Forms.Label ActionName;
        private System.Windows.Forms.TextBox AttackAbilityNameField;
        private System.Windows.Forms.RichTextBox AttackAbilityDescriptionField;
        private System.Windows.Forms.ComboBox HitDamageType;
        private System.Windows.Forms.NumericUpDown HitDiceBonusDamage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox HitDiceType;
        private System.Windows.Forms.NumericUpDown HitNumberOfDice;
        private System.Windows.Forms.Label AttackRange;
        private System.Windows.Forms.Label Reach;
        private System.Windows.Forms.NumericUpDown ReachUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RangeUpDownFar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReactionName;
        private System.Windows.Forms.RichTextBox ReactionDescription;
    }
}