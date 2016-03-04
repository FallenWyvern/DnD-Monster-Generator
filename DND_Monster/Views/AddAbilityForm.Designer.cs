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
            this.SpellcastingLevel = new System.Windows.Forms.NumericUpDown();
            this.SpellCastingTable = new System.Windows.Forms.TableLayoutPanel();
            this.Spellslot9 = new System.Windows.Forms.NumericUpDown();
            this.NinethLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.SeventhLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.SixthLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.FifthLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.FourthLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.ThirdLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.SecondLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.FirstLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.CantripLabel = new System.Windows.Forms.Label();
            this.Spellslot1 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot2 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot3 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot4 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot5 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot6 = new System.Windows.Forms.NumericUpDown();
            this.Spellslot7 = new System.Windows.Forms.NumericUpDown();
            this.AtWillLabel = new System.Windows.Forms.Label();
            this.EighthLevelSpellSlotLabel = new System.Windows.Forms.Label();
            this.Spellslot8 = new System.Windows.Forms.NumericUpDown();
            this.SpellcastingSave = new System.Windows.Forms.Button();
            this.SpellCastingAbility = new System.Windows.Forms.ComboBox();
            this.InnateCheckbox = new System.Windows.Forms.CheckBox();
            this.SpellClass = new System.Windows.Forms.ComboBox();
            this.SpellList = new System.Windows.Forms.ListBox();
            this.AddSpell = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpellLevel = new System.Windows.Forms.NumericUpDown();
            this.SpellcastingLevelLabel = new System.Windows.Forms.Label();
            this.CastingAbilityLabel = new System.Windows.Forms.Label();
            this.SpellClassLabel = new System.Windows.Forms.Label();
            this.SpellNameLabel = new System.Windows.Forms.Label();
            this.SpellLevelLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellcastingLevel)).BeginInit();
            this.SpellCastingTable.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.AbilityNameTextBox);
            this.tabPage1.Controls.Add(this.AbilityDescription);
            this.tabPage1.Controls.Add(this.AbilityName);
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
            this.tabPage2.Controls.Add(this.SpellcastingLevel);
            this.tabPage2.Controls.Add(this.SpellCastingTable);
            this.tabPage2.Controls.Add(this.SpellcastingSave);
            this.tabPage2.Controls.Add(this.SpellCastingAbility);
            this.tabPage2.Controls.Add(this.InnateCheckbox);
            this.tabPage2.Controls.Add(this.SpellClass);
            this.tabPage2.Controls.Add(this.SpellList);
            this.tabPage2.Controls.Add(this.AddSpell);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.SpellLevel);
            this.tabPage2.Controls.Add(this.SpellcastingLevelLabel);
            this.tabPage2.Controls.Add(this.CastingAbilityLabel);
            this.tabPage2.Controls.Add(this.SpellClassLabel);
            this.tabPage2.Controls.Add(this.SpellNameLabel);
            this.tabPage2.Controls.Add(this.SpellLevelLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spellcasting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SpellcastingLevel
            // 
            this.SpellcastingLevel.Location = new System.Drawing.Point(153, 48);
            this.SpellcastingLevel.Name = "SpellcastingLevel";
            this.SpellcastingLevel.Size = new System.Drawing.Size(120, 20);
            this.SpellcastingLevel.TabIndex = 14;
            // 
            // SpellCastingTable
            // 
            this.SpellCastingTable.ColumnCount = 2;
            this.SpellCastingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpellCastingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpellCastingTable.Controls.Add(this.Spellslot9, 1, 9);
            this.SpellCastingTable.Controls.Add(this.NinethLevelSpellSlotLabel, 0, 9);
            this.SpellCastingTable.Controls.Add(this.SeventhLevelSpellSlotLabel, 0, 7);
            this.SpellCastingTable.Controls.Add(this.SixthLevelSpellSlotLabel, 0, 6);
            this.SpellCastingTable.Controls.Add(this.FifthLevelSpellSlotLabel, 0, 5);
            this.SpellCastingTable.Controls.Add(this.FourthLevelSpellSlotLabel, 0, 4);
            this.SpellCastingTable.Controls.Add(this.ThirdLevelSpellSlotLabel, 0, 3);
            this.SpellCastingTable.Controls.Add(this.SecondLevelSpellSlotLabel, 0, 2);
            this.SpellCastingTable.Controls.Add(this.FirstLevelSpellSlotLabel, 0, 1);
            this.SpellCastingTable.Controls.Add(this.CantripLabel, 0, 0);
            this.SpellCastingTable.Controls.Add(this.Spellslot1, 1, 1);
            this.SpellCastingTable.Controls.Add(this.Spellslot2, 1, 2);
            this.SpellCastingTable.Controls.Add(this.Spellslot3, 1, 3);
            this.SpellCastingTable.Controls.Add(this.Spellslot4, 1, 4);
            this.SpellCastingTable.Controls.Add(this.Spellslot5, 1, 5);
            this.SpellCastingTable.Controls.Add(this.Spellslot6, 1, 6);
            this.SpellCastingTable.Controls.Add(this.Spellslot7, 1, 7);
            this.SpellCastingTable.Controls.Add(this.AtWillLabel, 1, 0);
            this.SpellCastingTable.Controls.Add(this.EighthLevelSpellSlotLabel, 0, 8);
            this.SpellCastingTable.Controls.Add(this.Spellslot8, 1, 8);
            this.SpellCastingTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.SpellCastingTable.Location = new System.Drawing.Point(282, 3);
            this.SpellCastingTable.Name = "SpellCastingTable";
            this.SpellCastingTable.RowCount = 10;
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SpellCastingTable.Size = new System.Drawing.Size(220, 353);
            this.SpellCastingTable.TabIndex = 13;
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
            // NinethLevelSpellSlotLabel
            // 
            this.NinethLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NinethLevelSpellSlotLabel.AutoSize = true;
            this.NinethLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 327);
            this.NinethLevelSpellSlotLabel.Name = "NinethLevelSpellSlotLabel";
            this.NinethLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.NinethLevelSpellSlotLabel.TabIndex = 20;
            this.NinethLevelSpellSlotLabel.Text = "9th Level Slots";
            // 
            // SeventhLevelSpellSlotLabel
            // 
            this.SeventhLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SeventhLevelSpellSlotLabel.AutoSize = true;
            this.SeventhLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 256);
            this.SeventhLevelSpellSlotLabel.Name = "SeventhLevelSpellSlotLabel";
            this.SeventhLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.SeventhLevelSpellSlotLabel.TabIndex = 18;
            this.SeventhLevelSpellSlotLabel.Text = "7th Level Slots";
            // 
            // SixthLevelSpellSlotLabel
            // 
            this.SixthLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SixthLevelSpellSlotLabel.AutoSize = true;
            this.SixthLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 221);
            this.SixthLevelSpellSlotLabel.Name = "SixthLevelSpellSlotLabel";
            this.SixthLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.SixthLevelSpellSlotLabel.TabIndex = 17;
            this.SixthLevelSpellSlotLabel.Text = "6th Level Slots";
            // 
            // FifthLevelSpellSlotLabel
            // 
            this.FifthLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FifthLevelSpellSlotLabel.AutoSize = true;
            this.FifthLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 186);
            this.FifthLevelSpellSlotLabel.Name = "FifthLevelSpellSlotLabel";
            this.FifthLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.FifthLevelSpellSlotLabel.TabIndex = 16;
            this.FifthLevelSpellSlotLabel.Text = "5th Level Slots";
            // 
            // FourthLevelSpellSlotLabel
            // 
            this.FourthLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FourthLevelSpellSlotLabel.AutoSize = true;
            this.FourthLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 151);
            this.FourthLevelSpellSlotLabel.Name = "FourthLevelSpellSlotLabel";
            this.FourthLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.FourthLevelSpellSlotLabel.TabIndex = 15;
            this.FourthLevelSpellSlotLabel.Text = "4th Level Slots";
            // 
            // ThirdLevelSpellSlotLabel
            // 
            this.ThirdLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThirdLevelSpellSlotLabel.AutoSize = true;
            this.ThirdLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 116);
            this.ThirdLevelSpellSlotLabel.Name = "ThirdLevelSpellSlotLabel";
            this.ThirdLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.ThirdLevelSpellSlotLabel.TabIndex = 14;
            this.ThirdLevelSpellSlotLabel.Text = "3rd Level Slots";
            // 
            // SecondLevelSpellSlotLabel
            // 
            this.SecondLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondLevelSpellSlotLabel.AutoSize = true;
            this.SecondLevelSpellSlotLabel.Location = new System.Drawing.Point(15, 81);
            this.SecondLevelSpellSlotLabel.Name = "SecondLevelSpellSlotLabel";
            this.SecondLevelSpellSlotLabel.Size = new System.Drawing.Size(80, 13);
            this.SecondLevelSpellSlotLabel.TabIndex = 13;
            this.SecondLevelSpellSlotLabel.Text = "2nd Level Slots";
            // 
            // FirstLevelSpellSlotLabel
            // 
            this.FirstLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstLevelSpellSlotLabel.AutoSize = true;
            this.FirstLevelSpellSlotLabel.Location = new System.Drawing.Point(17, 46);
            this.FirstLevelSpellSlotLabel.Name = "FirstLevelSpellSlotLabel";
            this.FirstLevelSpellSlotLabel.Size = new System.Drawing.Size(76, 13);
            this.FirstLevelSpellSlotLabel.TabIndex = 12;
            this.FirstLevelSpellSlotLabel.Text = "1st Level Slots";
            // 
            // CantripLabel
            // 
            this.CantripLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CantripLabel.AutoSize = true;
            this.CantripLabel.Location = new System.Drawing.Point(32, 11);
            this.CantripLabel.Name = "CantripLabel";
            this.CantripLabel.Size = new System.Drawing.Size(45, 13);
            this.CantripLabel.TabIndex = 11;
            this.CantripLabel.Text = "Cantrips";
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
            // AtWillLabel
            // 
            this.AtWillLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AtWillLabel.AutoSize = true;
            this.AtWillLabel.Location = new System.Drawing.Point(146, 11);
            this.AtWillLabel.Name = "AtWillLabel";
            this.AtWillLabel.Size = new System.Drawing.Size(37, 13);
            this.AtWillLabel.TabIndex = 10;
            this.AtWillLabel.Text = "At Will";
            // 
            // EighthLevelSpellSlotLabel
            // 
            this.EighthLevelSpellSlotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EighthLevelSpellSlotLabel.AutoSize = true;
            this.EighthLevelSpellSlotLabel.Location = new System.Drawing.Point(16, 291);
            this.EighthLevelSpellSlotLabel.Name = "EighthLevelSpellSlotLabel";
            this.EighthLevelSpellSlotLabel.Size = new System.Drawing.Size(77, 13);
            this.EighthLevelSpellSlotLabel.TabIndex = 19;
            this.EighthLevelSpellSlotLabel.Text = "8th Level Slots";
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
            this.SpellList.Sorted = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SpellLevel
            // 
            this.SpellLevel.Location = new System.Drawing.Point(3, 137);
            this.SpellLevel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.SpellLevel.Name = "SpellLevel";
            this.SpellLevel.Size = new System.Drawing.Size(56, 20);
            this.SpellLevel.TabIndex = 0;
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
            // CastingAbilityLabel
            // 
            this.CastingAbilityLabel.AutoSize = true;
            this.CastingAbilityLabel.Location = new System.Drawing.Point(3, 78);
            this.CastingAbilityLabel.Name = "CastingAbilityLabel";
            this.CastingAbilityLabel.Size = new System.Drawing.Size(72, 13);
            this.CastingAbilityLabel.TabIndex = 11;
            this.CastingAbilityLabel.Text = "Casting Ability";
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
            // SpellNameLabel
            // 
            this.SpellNameLabel.AutoSize = true;
            this.SpellNameLabel.Location = new System.Drawing.Point(212, 121);
            this.SpellNameLabel.Name = "SpellNameLabel";
            this.SpellNameLabel.Size = new System.Drawing.Size(61, 13);
            this.SpellNameLabel.TabIndex = 3;
            this.SpellNameLabel.Text = "Spell Name";
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
            this.SpellCastingTable.ResumeLayout(false);
            this.SpellCastingTable.PerformLayout();
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
        public System.Windows.Forms.TableLayoutPanel SpellCastingTable;
        public System.Windows.Forms.Label EighthLevelSpellSlotLabel;
        public System.Windows.Forms.Label SeventhLevelSpellSlotLabel;
        public System.Windows.Forms.Label SixthLevelSpellSlotLabel;
        public System.Windows.Forms.Label FifthLevelSpellSlotLabel;
        public System.Windows.Forms.Label FourthLevelSpellSlotLabel;
        public System.Windows.Forms.Label ThirdLevelSpellSlotLabel;
        public System.Windows.Forms.Label SecondLevelSpellSlotLabel;
        public System.Windows.Forms.Label FirstLevelSpellSlotLabel;
        public System.Windows.Forms.Label CantripLabel;
        public System.Windows.Forms.NumericUpDown Spellslot1;
        public System.Windows.Forms.NumericUpDown Spellslot2;
        public System.Windows.Forms.NumericUpDown Spellslot3;
        public System.Windows.Forms.NumericUpDown Spellslot4;
        public System.Windows.Forms.NumericUpDown Spellslot5;
        public System.Windows.Forms.NumericUpDown Spellslot6;
        public System.Windows.Forms.NumericUpDown Spellslot7;
        public System.Windows.Forms.NumericUpDown Spellslot8;
        public System.Windows.Forms.Label AtWillLabel;
        public System.Windows.Forms.NumericUpDown Spellslot9;
        public System.Windows.Forms.Label NinethLevelSpellSlotLabel;
        public System.Windows.Forms.Label SpellcastingLevelLabel;
        public System.Windows.Forms.NumericUpDown SpellcastingLevel;

    }
}