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
    public partial class AddLegendaryForm : Form
    {
        public Legendary LegendaryAbility = null;

        public AddLegendaryForm()
        {
            InitializeComponent();            
        }

        private void AddLegendaryForm_Load(object sender, EventArgs e)
        {
            Traits.Sorted = true;
        }

        public void SerializeTraits()
        {
            if (Traits.Items.Count == 0 || String.IsNullOrEmpty(LegendaryAbilityName.Text)) { return; }

            LegendaryAbility = new Legendary();
            LegendaryAbility.Title = LegendaryAbilityName.Text;

            foreach (string item in Traits.Items)
            {
                LegendaryAbility.AddTrait(item.Split('|')[0].Trim(), item.Split('|')[1].Trim());
            }
        }

        public void LoadLegendary(Legendary target)
        {
            LegendaryAbility = target;
            LegendaryAbilityName.Text = target.Title;
            
            foreach (LegendaryTrait trait in target.TraitList())
            {
                Traits.Items.Add(trait.Title + " | " + trait.Ability);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { this.Text = LegendaryAbilityName.Text; }
            catch {this.Text = "Add Legendary Actions";}
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Traits.SelectedItem == null) return;
            Traits.Items.Remove(Traits.SelectedItem);
        }

        private void SaveTrait_Click(object sender, EventArgs e)
        {
            Traits.Items.Add(textBox1.Text + " | " + TraitDescriptionBox.Text);
            textBox1.Text = "";
            TraitDescriptionBox.Text = "";
        }

        private void LoadTrait_Click(object sender, EventArgs e)
        {
            textBox1.Text = Traits.SelectedItem.ToString().Split('|')[0].Trim();
            TraitDescriptionBox.Text = Traits.SelectedItem.ToString().Split('|')[1].Trim();
            Traits.Items.Remove(Traits.SelectedItem);
        }
    }
}
