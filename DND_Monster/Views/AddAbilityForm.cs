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
        private List<NumericUpDown> spellslots = new List<NumericUpDown>();

        public AddAbilityForm()
        {
            InitializeComponent();            
            spellslots.Add(Spellslot1); 
            spellslots.Add(Spellslot2);
            spellslots.Add(Spellslot3);
            spellslots.Add(Spellslot4);
            spellslots.Add(Spellslot5);
            spellslots.Add(Spellslot6);
            spellslots.Add(Spellslot7);
            spellslots.Add(Spellslot8);
            spellslots.Add(Spellslot9);
        }

        // This loads non-spell abilities.
        public void LoadAbility(Ability values)
        {
            AbilityNameTextBox.Text = values.Title;
            DescriptionTextBox.Text = values.Description;
            NewAbility = values;
            NewAbility.isSpell = false;
        }

        // This loads spells.
        public void LoadSpell(Ability values)
        {
            NewAbility = values;
            tabControl1.SelectedIndex = 1;
            string[] spellValues = values.Description.Split('|');
            SpellClass.Text = spellValues[0];
            SpellCastingAbility.Text = spellValues[1];
            SpellcastingLevel.Value = Convert.ToInt32(spellValues[2]);
            if (spellValues[3] == "Innate") { 
                InnateCheckbox.Checked = true; 
            }
            else
            {
                Spellslot1.Value = Convert.ToInt32(spellValues[4].Split(',')[0]);
                Spellslot2.Value = Convert.ToInt32(spellValues[4].Split(',')[1]);
                Spellslot3.Value = Convert.ToInt32(spellValues[4].Split(',')[2]);
                Spellslot4.Value = Convert.ToInt32(spellValues[4].Split(',')[3]);
                Spellslot5.Value = Convert.ToInt32(spellValues[4].Split(',')[4]);
                Spellslot6.Value = Convert.ToInt32(spellValues[4].Split(',')[5]);
                Spellslot7.Value = Convert.ToInt32(spellValues[4].Split(',')[6]);
                Spellslot8.Value = Convert.ToInt32(spellValues[4].Split(',')[7]);
                Spellslot9.Value = Convert.ToInt32(spellValues[4].Split(',')[8]);
            }

            foreach (string item in spellValues[5].Split(','))
            {
                if (!String.IsNullOrWhiteSpace(item) || !String.IsNullOrEmpty(item))
                {
                    SpellList.Items.Add(item.Replace(':', '|'));
                }
            }
        }        

        // This saves the ability based on which tab is currently selected.
        private void Save(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.NewAbility = new Ability();
                NewAbility.Title = AbilityNameTextBox.Text;
                NewAbility.Description = DescriptionTextBox.Text;
                NewAbility.isDamage = false;
                NewAbility.isSpell = false;
            }
            else
            {
                this.NewAbility = new Ability();
                string spellText = "";

                if (InnateCheckbox.Checked)
                {
                    spellText = ToDescription_Innate();
                }
                else
                {
                   spellText = ToDescription_NotInnate();
                }

                NewAbility.Title = SpellClass.Text + " Spellcasting";
                NewAbility.Description = spellText; 
                NewAbility.isSpell = true;
                NewAbility.isDamage = false;                
            }
            this.Close();
        }

        // Creates the spell out into a string, to load into the description.
        private string ToDescription_NotInnate()
        {
            string spellText = "";
            spellText += SpellClass.Text + "|";
            spellText += SpellCastingAbility.Text + "|";
            spellText += SpellcastingLevel.Value + "|";

            if (InnateCheckbox.Checked)
            {
                spellText += "Innate|";
            }
            else
            {
                spellText += "NotInnate|";
            }

            foreach (NumericUpDown control in spellslots)
            {
                spellText += control.Value;
                if (control != Spellslot9) { spellText += ","; } else { spellText += "|"; }
            }

            for (int i = 0; i < 10; i++)
            {
                foreach (string item in SpellList.Items)
                {
                    if (!String.IsNullOrEmpty(item) || !String.IsNullOrWhiteSpace(item))
                    {
                        if (Convert.ToInt32(item.Split('|')[0]) == i)
                        {
                            spellText += item.Split('|')[0].Trim() + ":" + item.Split('|')[1].Trim() + ",";
                        }
                    }
                }
            }

            spellText += "|";
            return spellText;
        }

        // Creates the spell out into a string, to load into the description.
        private string ToDescription_Innate()
        {
            return ToDescription_NotInnate();
            string spellText = "";
            spellText += SpellClass.Text + "|";
            spellText += SpellCastingAbility.Text + "|";
            spellText += SpellcastingLevel.Value + "|";

            if (InnateCheckbox.Checked)
            {
                spellText += "Innate|";
            }
            else
            {
                spellText += "NotInnate|";
            }

            foreach (string item in SpellList.Items)
            {
                if (!String.IsNullOrEmpty(item) || !String.IsNullOrWhiteSpace(item))
                {
                    spellText += item.Split('|')[0].Trim() + ":" + item.Split('|')[1].Trim() + ",";            
                }
            }

            spellText += "|";
            return spellText;
        }
        

        // Remove spells from the spell list.
        private void SpellListItemRemove(object sender, EventArgs e)
        {
            if (SpellList.SelectedItem == null) return;
            SpellList.Items.Remove(SpellList.SelectedItem);
        }

        // Adds the spell to the spell list.
        private void AddSpellToList(object sender, EventArgs e)
        {
            SpellList.Items.Add(SpellLevel.Value + " | " + textBox1.Text);
            textBox1.Text = "";
        }

        // Ensures maximum level of an added spell isn't higher than the highest spell slot.
        private void ChangeSpellLevelMax(object sender, EventArgs e)
        {            
            NumericUpDown temp = (NumericUpDown)sender;
            int tagValue = Convert.ToInt32(temp.Tag.ToString());
            
            foreach (NumericUpDown item in spellslots)
            {                
                if (item.Value == 0)
                {                
                    int tempValue = Convert.ToInt32(item.Tag.ToString());
                    SpellLevel.Maximum = tempValue - 1;                    
                    return;
                }
            }
        }

        // Updates the window title.
        private void UpdatePopOutTitle(object sender, EventArgs e)
        {
            try { this.Text = AbilityNameTextBox.Text; }
            catch { }
        }

        int oldMax = 0;
        private void InnateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (InnateCheckbox.Checked)
            {
                SpellLevelLabel.Text = Settings.SpellTimesPerDay;
                oldMax = (int)SpellLevel.Maximum;
                SpellLevel.Maximum = 9;
            }
            else
            {
                SpellLevelLabel.Text = Settings.SpellLevel;
                SpellLevel.Maximum = oldMax;
            }
        }

    }
}
