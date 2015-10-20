namespace DND_Monster
{
    partial class AddSavedTrait
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.AbilityGrid = new System.Windows.Forms.DataGridView();
            this.AbilityTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbilityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionGrid = new System.Windows.Forms.DataGridView();
            this.ReactionGrid = new System.Windows.Forms.DataGridView();
            this.LegendaryGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavedTraitTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbilityGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegendaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AbilityGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ability";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ActionGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Action";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReactionGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(331, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reaction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LegendaryGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(331, 342);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Legendary";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AbilityGrid
            // 
            this.AbilityGrid.AllowUserToAddRows = false;
            this.AbilityGrid.AllowUserToDeleteRows = false;
            this.AbilityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbilityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbilityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AbilityTitle,
            this.AbilityDescription});
            this.AbilityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbilityGrid.Location = new System.Drawing.Point(3, 3);
            this.AbilityGrid.MultiSelect = false;
            this.AbilityGrid.Name = "AbilityGrid";
            this.AbilityGrid.ReadOnly = true;
            this.AbilityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AbilityGrid.ShowEditingIcon = false;
            this.AbilityGrid.Size = new System.Drawing.Size(325, 336);
            this.AbilityGrid.TabIndex = 1;
            // 
            // AbilityTitle
            // 
            this.AbilityTitle.HeaderText = "Ability Title";
            this.AbilityTitle.Name = "AbilityTitle";
            this.AbilityTitle.ReadOnly = true;
            // 
            // AbilityDescription
            // 
            this.AbilityDescription.HeaderText = "Description";
            this.AbilityDescription.Name = "AbilityDescription";
            this.AbilityDescription.ReadOnly = true;
            // 
            // ActionGrid
            // 
            this.ActionGrid.AllowUserToAddRows = false;
            this.ActionGrid.AllowUserToDeleteRows = false;
            this.ActionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ActionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionGrid.Location = new System.Drawing.Point(3, 3);
            this.ActionGrid.MultiSelect = false;
            this.ActionGrid.Name = "ActionGrid";
            this.ActionGrid.ReadOnly = true;
            this.ActionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActionGrid.ShowEditingIcon = false;
            this.ActionGrid.Size = new System.Drawing.Size(325, 336);
            this.ActionGrid.TabIndex = 2;
            // 
            // ReactionGrid
            // 
            this.ReactionGrid.AllowUserToAddRows = false;
            this.ReactionGrid.AllowUserToDeleteRows = false;
            this.ReactionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ReactionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReactionGrid.Location = new System.Drawing.Point(0, 0);
            this.ReactionGrid.MultiSelect = false;
            this.ReactionGrid.Name = "ReactionGrid";
            this.ReactionGrid.ReadOnly = true;
            this.ReactionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReactionGrid.ShowEditingIcon = false;
            this.ReactionGrid.Size = new System.Drawing.Size(331, 342);
            this.ReactionGrid.TabIndex = 2;
            // 
            // LegendaryGrid
            // 
            this.LegendaryGrid.AllowUserToAddRows = false;
            this.LegendaryGrid.AllowUserToDeleteRows = false;
            this.LegendaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LegendaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LegendaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.LegendaryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LegendaryGrid.Location = new System.Drawing.Point(0, 0);
            this.LegendaryGrid.MultiSelect = false;
            this.LegendaryGrid.Name = "LegendaryGrid";
            this.LegendaryGrid.ReadOnly = true;
            this.LegendaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LegendaryGrid.ShowEditingIcon = false;
            this.LegendaryGrid.Size = new System.Drawing.Size(331, 342);
            this.LegendaryGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Legendary";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Reaction Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Action Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // AddSavedTrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddSavedTrait";
            this.Text = "Add Saved Trait";
            this.Load += new System.EventHandler(this.AddSavedTrait_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AbilityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegendaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView AbilityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbilityTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbilityDescription;
        private System.Windows.Forms.DataGridView ActionGrid;
        private System.Windows.Forms.DataGridView ReactionGrid;
        private System.Windows.Forms.DataGridView LegendaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolTip SavedTraitTooltip;
    }
}