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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SpellcastingLevelLabel = new System.Windows.Forms.Label();
            this.SpellcastingLevel = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Spellslot9 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Spellslot1 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot2 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot3 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot4 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot5 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot6 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot7 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Spellslot8 = new System.Windows.Forms.NumericUpDown();
            this.SpellcastingSave = new System.Windows.Forms.Button();
            this.CastingAbilityLabel = new System.Windows.Forms.Label();
            this.SpellCastingAbility = new System.Windows.Forms.ComboBox();
            this.InnateCheckbox = new System.Windows.Forms.CheckBox();
            this.SpellClassLabel = new System.Windows.Forms.Label();
            this.SpellClass = new System.Windows.Forms.ComboBox();
            this.SpellList = new System.Windows.Forms.ListBox();
            this.AddSpell = new System.Windows.Forms.Button();
            this.SpellNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpellLevelLabel = new System.Windows.Forms.Label();
            this.SpellLevel = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellcastingLevel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionTextBox.Location = new System.Drawing.Point(3, 96);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(499, 260);
            this.DescriptionTextBox.TabIndex = 1;
            this.DescriptionTextBox.Text = "";
            // 
            // AbilityNameTextBox
            // 
            this.AbilityNameTextBox.Location = new System.Drawing.Point(77, 29);
            this.AbilityNameTextBox.Name = "AbilityNameTextBox";
            this.AbilityNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.AbilityNameTextBox.TabIndex = 0;
            this.AbilityNameTextBox.TextChanged += new System.EventHandler(this.UpdatePopOutTitle);
            // 
            // AbilityName
            // 
            this.AbilityName.AutoSize = true;
            this.AbilityName.Location = new System.Drawing.Point(6, 32);
            this.AbilityName.Name = "AbilityName";
            this.AbilityName.Size = new System.Drawing.Size(65, 13);
            this.AbilityName.TabIndex = 2;
            this.AbilityName.Text = "Ability Name";
            // 
            // AbilityDescription
            // 
            this.AbilityDescription.AutoSize = true;
            this.AbilityDescription.Location = new System.Drawing.Point(6, 58);
            this.AbilityDescription.Name = "AbilityDescription";
            this.AbilityDescription.Size = new System.Drawing.Size(60, 13);
            this.AbilityDescription.TabIndex = 3;
            this.AbilityDescription.Text = "Description";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(200, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 385);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Controls.Add(this.DescriptionTextBox);
            this.tabPage1.Controls.Add(this.AbilityDescription);
            this.tabPage1.Controls.Add(this.AbilityName);
            this.tabPage1.Controls.Add(this.AbilityNameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ability";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SpellcastingLevelLabel);
            this.tabPage2.Controls.Add(this.SpellcastingLevel);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.SpellcastingSave);
            this.tabPage2.Controls.Add(this.CastingAbilityLabel);
            this.tabPage2.Controls.Add(this.SpellCastingAbility);
            this.tabPage2.Controls.Add(this.InnateCheckbox);
            this.tabPage2.Controls.Add(this.SpellClassLabel);
            this.tabPage2.Controls.Add(this.SpellClass);
            this.tabPage2.Controls.Add(this.SpellList);
            this.tabPage2.Controls.Add(this.AddSpell);
            this.tabPage2.Controls.Add(this.SpellNameLabel);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.SpellLevelLabel);
            this.tabPage2.Controls.Add(this.SpellLevel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spellcasting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SpellcastingLevelLabel
            // 
            this.SpellcastingLevelLabel.AutoSize = true;
            this.SpellcastingLevelLabel.Location = new System.Drawing.Point(150, 32);
            this.SpellcastingLevelLabel.Name = "SpellcastingLevelLabel";
            this.SpellcastingLevelLabel.Size = new System.Drawing.Size(93, 13);
            this.SpellcastingLevelLabel.TabIndex = 15;
            this.SpellcastingLevelLabel.Text = "Spellcasting Level";
            // 
            // SpellcastingLevel
            // 
            this.SpellcastingLevel.Location = new System.Drawing.Point(153, 48);
            this.SpellcastingLevel.Name = "SpellcastingLevel";
            this.SpellcastingLevel.Size = new System.Drawing.Size(120, 20);
            this.SpellcastingLevel.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Spellslot9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Spellslot8, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(282, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 353);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Spellslot9
            // 
            this.Spellslot9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot9.Location = new System.Drawing.Point(113, 324);
            this.Spellslot9.Name = "Spellslot9";
            this.Spellslot9.Size = new System.Drawing.Size(104, 20);
            this.Spellslot9.TabIndex = 21;
            this.Spellslot9.Tag = "9";
            this.Spellslot9.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "9th Level Slots";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "7th Level Slots";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "6th Level Slots";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "5th Level Slots";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "4th Level Slots";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "3rd Level Slots";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "2nd Level Slots";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "1st Level Slots";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantrips";
            // 
            // Spellslot1
            // 
            this.Spellslot1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot1.Location = new System.Drawing.Point(113, 42);
            this.Spellslot1.Name = "Spellslot1";
            this.Spellslot1.Size = new System.Drawing.Size(104, 20);
            this.Spellslot1.TabIndex = 1;
            this.Spellslot1.Tag = "1";
            this.Spellslot1.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // Spellslot2
            // 
            this.Spellslot2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot2.Location = new System.Drawing.Point(113, 77);
            this.Spellslot2.Name = "Spellslot2";
            this.Spellslot2.Size = new System.Drawing.Size(104, 20);
            this.Spellslot2.TabIndex = 2;
            this.Spellslot2.Tag = "2";
            this.Spellslot2.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // Spellslot3
            // 
            this.Spellslot3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot3.Location = new System.Drawing.Point(113, 112);
            this.Spellslot3.Name = "Spellslot3";
            this.Spellslot3.Size = new System.Drawing.Size(104, 20);
            this.Spellslot3.TabIndex = 3;
            this.Spellslot3.Tag = "3";
            this.Spellslot3.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // Spellslot4
            // 
            this.Spellslot4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot4.Location = new System.Drawing.Point(113, 147);
            this.Spellslot4.Name = "Spellslot4";
            this.Spellslot4.Size = new System.Drawing.Size(104, 20);
            this.Spellslot4.TabIndex = 4;
            this.Spellslot4.Tag = "4";
            this.Spellslot4.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // Spellslot5
            // 
            this.Spellslot5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot5.Location = new System.Drawing.Point(113, 182);
            this.Spellslot5.Name = "Spellslot5";
            this.Spellslot5.Size = new System.Drawing.Size(104, 20);
            this.Spellslot5.TabIndex = 5;
            this.Spellslot5.Tag = "5";
            this.Spellslot5.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // Spellslot6
            // 
            this.Spellslot6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot6.Location = new System.Drawing.Point(113, 217);
            this.Spellslot6.Name = "Spellslot6";
            this.Spellslot6.Size = new System.Drawing.Size(104, 20);
            this.Spellslot6.TabIndex = 6;
            this.Spellslot6.Tag = "6";
            this.Spellslot6.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // Spellslot7
            // 
            this.Spellslot7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot7.Location = new System.Drawing.Point(113, 252);
            this.Spellslot7.Name = "Spellslot7";
            this.Spellslot7.Size = new System.Drawing.Size(104, 20);
            this.Spellslot7.TabIndex = 7;
            this.Spellslot7.Tag = "7";
            this.Spellslot7.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "At Will";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "8th Level Slots";
            // 
            // Spellslot8
            // 
            this.Spellslot8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spellslot8.Location = new System.Drawing.Point(113, 287);
            this.Spellslot8.Name = "Spellslot8";
            this.Spellslot8.Size = new System.Drawing.Size(104, 20);
            this.Spellslot8.TabIndex = 8;
            this.Spellslot8.Tag = "8";
            this.Spellslot8.ValueChanged += new System.EventHandler(this.ChangeSpellLevelMax);
            // 
            // SpellcastingSave
            // 
            this.SpellcastingSave.Location = new System.Drawing.Point(201, 3);
            this.SpellcastingSave.Name = "SpellcastingSave";
            this.SpellcastingSave.Size = new System.Drawing.Size(75, 23);
            this.SpellcastingSave.TabIndex = 12;
            this.SpellcastingSave.Text = "Save";
            this.SpellcastingSave.UseVisualStyleBackColor = true;
            this.SpellcastingSave.Click += new System.EventHandler(this.Save);
            // 
            // CastingAbilityLabel
            // 
            this.CastingAbilityLabel.AutoSize = true;
            this.CastingAbilityLabel.Location = new System.Drawing.Point(3, 78);
            this.CastingAbilityLabel.Name = "CastingAbilityLabel";
            this.CastingAbilityLabel.Size = new System.Drawing.Size(72, 13);
            this.CastingAbilityLabel.TabIndex = 11;
            this.CastingAbilityLabel.Text = "Casting Ability";
            // 
            // SpellCastingAbility
            // 
            this.SpellCastingAbility.FormattingEnabled = true;
            this.SpellCastingAbility.Items.AddRange(new object[] {
            "Intelligence",
            "Wisdom",
            "Charisma",
            "Strength",
            "Dexterity",
            "Constitution"});
            this.SpellCastingAbility.Location = new System.Drawing.Point(3, 94);
            this.SpellCastingAbility.Name = "SpellCastingAbility";
            this.SpellCastingAbility.Size = new System.Drawing.Size(121, 21);
            this.SpellCastingAbility.TabIndex = 10;
            this.SpellCastingAbility.Text = "Intelligence";
            // 
            // InnateCheckbox
            // 
            this.InnateCheckbox.AutoSize = true;
            this.InnateCheckbox.Location = new System.Drawing.Point(160, 96);
            this.InnateCheckbox.Name = "InnateCheckbox";
            this.InnateCheckbox.Size = new System.Drawing.Size(116, 17);
            this.InnateCheckbox.TabIndex = 9;
            this.InnateCheckbox.Text = "Innate Spellcasting";
            this.InnateCheckbox.UseVisualStyleBackColor = true;
            this.InnateCheckbox.CheckedChanged += new System.EventHandler(this.InnateCheckbox_CheckedChanged);
            // 
            // SpellClassLabel
            // 
            this.SpellClassLabel.AutoSize = true;
            this.SpellClassLabel.Location = new System.Drawing.Point(3, 31);
            this.SpellClassLabel.Name = "SpellClassLabel";
            this.SpellClassLabel.Size = new System.Drawing.Size(74, 13);
            this.SpellClassLabel.TabIndex = 8;
            this.SpellClassLabel.Text = "Type of Spells";
            // 
            // SpellClass
            // 
            this.SpellClass.FormattingEnabled = true;
            this.SpellClass.Items.AddRange(new object[] {
            "bard",
            "cleric",
            "druid",
            "paladin",
            "ranger",
            "sorcerer",
            "warlock",
            "wizard"});
            this.SpellClass.Location = new System.Drawing.Point(3, 47);
            this.SpellClass.Name = "SpellClass";
            this.SpellClass.Size = new System.Drawing.Size(121, 21);
            this.SpellClass.TabIndex = 7;
            this.SpellClass.Text = "bard";
            // 
            // SpellList
            // 
            this.SpellList.FormattingEnabled = true;
            this.SpellList.Location = new System.Drawing.Point(3, 186);
            this.SpellList.Name = "SpellList";
            this.SpellList.Size = new System.Drawing.Size(273, 173);
            this.SpellList.TabIndex = 6;
            this.SpellList.DoubleClick += new System.EventHandler(this.SpellListItemRemove);
            // 
            // AddSpell
            // 
            this.AddSpell.Location = new System.Drawing.Point(198, 160);
            this.AddSpell.Name = "AddSpell";
            this.AddSpell.Size = new System.Drawing.Size(75, 23);
            this.AddSpell.TabIndex = 5;
            this.AddSpell.Text = "Add Spell";
            this.AddSpell.UseVisualStyleBackColor = true;
            this.AddSpell.Click += new System.EventHandler(this.AddSpellToList);
            // 
            // SpellNameLabel
            // 
            this.SpellNameLabel.AutoSize = true;
            this.SpellNameLabel.Location = new System.Drawing.Point(212, 121);
            this.SpellNameLabel.Name = "SpellNameLabel";
            this.SpellNameLabel.Size = new System.Drawing.Size(61, 13);
            this.SpellNameLabel.TabIndex = 3;
            this.SpellNameLabel.Text = "Spell Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SpellLevelLabel
            // 
            this.SpellLevelLabel.AutoSize = true;
            this.SpellLevelLabel.Location = new System.Drawing.Point(3, 121);
            this.SpellLevelLabel.Name = "SpellLevelLabel";
            this.SpellLevelLabel.Size = new System.Drawing.Size(59, 13);
            this.SpellLevelLabel.TabIndex = 1;
            this.SpellLevelLabel.Text = "Spell Level";
            // 
            // SpellLevel
            // 
            this.SpellLevel.Location = new System.Drawing.Point(3, 137);
            this.SpellLevel.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpellLevel.Name = "SpellLevel";
            this.SpellLevel.Size = new System.Drawing.Size(56, 20);
            this.SpellLevel.TabIndex = 0;
            // 
            // AddAbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 385);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddAbilityForm";
            this.Text = "Add Abilities";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellcastingLevel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spellslot8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox DescriptionTextBox;
        public System.Windows.Forms.TextBox AbilityNameTextBox;
        public System.Windows.Forms.Label AbilityName;
        public System.Windows.Forms.Label AbilityDescription;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label SpellNameLabel;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label SpellLevelLabel;
        public System.Windows.Forms.NumericUpDown SpellLevel;
        public System.Windows.Forms.Button AddSpell;
        public System.Windows.Forms.ListBox SpellList;
        public System.Windows.Forms.Label CastingAbilityLabel;
        public System.Windows.Forms.ComboBox SpellCastingAbility;
        public System.Windows.Forms.CheckBox InnateCheckbox;
        public System.Windows.Forms.Label SpellClassLabel;
        public System.Windows.Forms.ComboBox SpellClass;
        public System.Windows.Forms.Button SpellcastingSave;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown Spellslot1;
        public System.Windows.Forms.NumericUpDown Spellslot2;
        public System.Windows.Forms.NumericUpDown Spellslot3;
        public System.Windows.Forms.NumericUpDown Spellslot4;
        public System.Windows.Forms.NumericUpDown Spellslot5;
        public System.Windows.Forms.NumericUpDown Spellslot6;
        public System.Windows.Forms.NumericUpDown Spellslot7;
        public System.Windows.Forms.NumericUpDown Spellslot8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown Spellslot9;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label SpellcastingLevelLabel;
        public System.Windows.Forms.NumericUpDown SpellcastingLevel;

    }
}