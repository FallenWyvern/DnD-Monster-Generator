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

        // Constructs the Legendary object.
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

        // Load a Legendary object.
        public void LoadLegendary(Legendary target)
        {
            LegendaryAbility = target;
            LegendaryAbilityName.Text = target.Title;
            
            foreach (LegendaryTrait trait in target.TraitList())
            {
                Traits.Items.Add(trait.Title + " | " + trait.Ability);
            }
        }

        // Updates the window title.
        private void UpdateTitle(object sender, EventArgs e)
        {
            try { this.Text = LegendaryAbilityName.Text; }
            catch {this.Text = "Add Legendary Actions";}
        }

        // Removes a legendary trait.
        private void RemoveTrait(object sender, MouseEventArgs e)
        {
            if (Traits.SelectedItem == null) return;
            Traits.Items.Remove(Traits.SelectedItem);
        }

        // Adds a Legendary trait.
        private void SaveTrait_Click(object sender, EventArgs e)
        {
            Traits.Items.Add(AbilityName.Text + " | " + TraitDescriptionBox.Text);
            AbilityName.Text = "";
            TraitDescriptionBox.Text = "";
        }

        // Edit a Legendary trait
        private void LoadTrait_Click(object sender, EventArgs e)
        {
            AbilityName.Text = Traits.SelectedItem.ToString().Split('|')[0].Trim();
            TraitDescriptionBox.Text = Traits.SelectedItem.ToString().Split('|')[1].Trim();
            Traits.Items.Remove(Traits.SelectedItem);
        }
    }
}
