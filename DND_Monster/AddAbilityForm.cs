using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Monster
{
    public partial class AddAbilityForm : Form
    {
        public Ability NewAbility = null;

        public AddAbilityForm()
        {
            InitializeComponent();
        }

        public void LoadAbility(Ability values)
        {
            AbilityNameTextBox.Text = values.Title;
            DescriptionTextBox.Text = values.Description;
        }

        private void AddAbilityForm_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdatePopOutTitle(object sender, EventArgs e)
        {
            try { this.Text = AbilityNameTextBox.Text; }
            catch { }
        }

        private void Save(object sender, EventArgs e)
        {
            this.NewAbility = new Ability();
            NewAbility.Title = AbilityNameTextBox.Text;
            NewAbility.Description = DescriptionTextBox.Text;
            NewAbility.isDamage = false;
            this.Close();
        }
    }
}
