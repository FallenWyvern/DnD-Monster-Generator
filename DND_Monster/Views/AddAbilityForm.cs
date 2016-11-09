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
            Translation.Apply(this);

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

        // This loads advanced spellcasting
        public void LoadAbility()
        {
            Monster._advancedSpells.Clear();
            tabControl1.SelectedIndex = 2;
            advancedSpells = Monster._advancedSpellData;
            foreach (AdvancedSpell spell in Monster._advancedSpellData)
            {
                if (spell.spellLevel > highestSpellLevel)
                {
                    highestSpellLevel = spell.spellLevel;
                }
            }
            AdvancedSpellText();
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
            else if (tabControl1.SelectedIndex == 1) 
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

                if (InnateCheckbox.Checked)
                {
                    NewAbility.Title = "Innate Spellcasting";
                }
                else
                {
                    NewAbility.Title = SpellClass.Text + " Spellcasting";
                }

                NewAbility.Description = spellText; 
                NewAbility.isSpell = true;
                NewAbility.isDamage = false;                
            }
            else
            {
                NewAbility = null;
                Monster._advancedSpells.Add(advancedSpell.Text);
                Monster._advancedSpellData = advancedSpells;
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
            //string spellText = "";
            //spellText += SpellClass.Text + "|";
            //spellText += SpellCastingAbility.Text + "|";
            //spellText += SpellcastingLevel.Value + "|";

            //if (InnateCheckbox.Checked)
            //{
            //    spellText += "Innate|";
            //}
            //else
            //{
            //    spellText += "NotInnate|";
            //}

            //foreach (string item in SpellList.Items)
            //{
            //    if (!String.IsNullOrEmpty(item) || !String.IsNullOrWhiteSpace(item))
            //    {
            //        spellText += item.Split('|')[0].Trim() + ":" + item.Split('|')[1].Trim() + ",";            
            //    }
            //}

            //spellText += "|";
            //return spellText;
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
            // NumericUpDown temp = (NumericUpDown)sender;
            // int tagValue = Convert.ToInt32(temp.Tag.ToString());

            // if (SpellLevel.Maximum < tagValue)
            // {
            //     SpellLevel.Maximum = tagValue;
            // }
        }

        // Updates the window title.
        private void UpdatePopOutTitle(object sender, EventArgs e)
        {
            try { this.Text = AbilityNameTextBox.Text; }
            catch { }
        }

        // int oldMax = 0;
        private void InnateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (InnateCheckbox.Checked)
            {
                SpellLevelLabel.Text = Settings.SpellTimesPerDay;
                // oldMax = (int)SpellLevel.Maximum;
                // SpellLevel.Maximum = 9;
            }
            else
            {
                SpellLevelLabel.Text = Settings.SpellLevel;
                // SpellLevel.Maximum = oldMax;
            }
        }

        List<AdvancedSpell> advancedSpells = new List<AdvancedSpell>();
        int highestSpellLevel = 0;     

        private void AdvancedSpellText()
        {
            advancedSpell.Text = "<h4><b>Spellcasting. </b></h4><p>";
            string name = "";
            if (String.IsNullOrEmpty(Monster.CreatureName) || String.IsNullOrWhiteSpace(Monster.CreatureName))
            {
                name = "The Creature";
            }
            else
            {
                if (!name.Contains('*') && !Monster.unique) { name = name.ToLower(); }
            }

            string levelSuffix = "th";
            if (advancedCasterLevel.Value == 1)
            {
                levelSuffix = "st";
            }
            if (advancedCasterLevel.Value == 2)
            {
                levelSuffix = "nd";
            }
            if (advancedCasterLevel.Value == 3)
            {
                levelSuffix = "rd";
            }

            string spellcastingstat = advancedCasterAbility.Text;
            int modifier = 0;

            switch (spellcastingstat.ToLower().Substring(0, 3))
            {
                case "str":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.STR) - 10) / 2);
                    break;
                case "int":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.INT) - 10) / 2);
                    break;
                case "wis":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.WIS) - 10) / 2);
                    break;
                case "cha":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.CHA) - 10) / 2);
                    break;
                case "con":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.CON) - 10) / 2);
                    break;
                case "dex":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.DEX) - 10) / 2);
                    break;
            }

            advancedSpell.Text += name + " is a " + advancedCasterLevel.Value + levelSuffix + "-level spellcaster. Its spellcasting ability is " + advancedCasterAbility.Text + " (spell save DC ";
            advancedSpell.Text += (8 + Monster.CR.profBonus + modifier) + ", +" + (modifier + Monster.CR.profBonus) + " to hit with spell attacks). " + name + " has the following " + advancedSpellType.Text + " spells prepared:</p></br>";

            for (int i = 0; i < highestSpellLevel + 1; i++)
            {
                foreach (AdvancedSpell spell in advancedSpells)
                {
                    if (spell.spellLevel == i)
                    {
                        string _levelSuffix = "th";
                        if (spell.spellLevel == 1)
                        {
                            _levelSuffix = "st";
                        }
                        if (spell.spellLevel == 2)
                        {
                            _levelSuffix = "nd";
                        }
                        if (spell.spellLevel == 3)
                        {
                            _levelSuffix = "rd";
                        }

                        if (i != 0)
                        {
                            advancedSpell.Text += "<p>" + spell.spellLevel + _levelSuffix + " (" + spell.spellSlots + " slot";
                            if (spell.spellSlots > 1)
                            {
                                advancedSpell.Text += "s";
                            }
                            advancedSpell.Text += "): ";
                        }
                        else
                        {
                            advancedSpell.Text += "<p>Cantrips (<i>at will</i>): ";
                        }
                        
                        foreach (string item in spell.spellNames)
                        {
                            advancedSpell.Text += "<i>" + item + "</i>";
                            if (item != spell.spellNames.Last())
                            {
                                advancedSpell.Text += ", ";
                            } else
                            {
                                advancedSpell.Text += "</p>";
                            }
                        }

                        if (spell.spellNames.Count == 0)
                        {
                            advancedSpell.Text += "</p>";
                        }
                    }
                }                
            }
        }

        private void AdjustSlots(object sender, EventArgs e)
        {
            bool foundExistingLevels = false;
            foreach (AdvancedSpell spell in advancedSpells)
            {
                if (spell.spellLevel == (int)advancedSpellSlotsLevel.Value)
                {
                    foundExistingLevels = true;
                    spell.spellSlots = (int)advancedSpellSlotsPerLevel.Value;
                }
            }

            if (!foundExistingLevels)
            {
                advancedSpells.Add(new AdvancedSpell()
                {
                    spellSlots = (int)advancedSpellSlotsPerLevel.Value,
                    spellLevel = (int)advancedSpellSlotsLevel.Value,
                });
            }

            if (advancedSpellSlotsLevel.Value > highestSpellLevel)
            {
                highestSpellLevel = (int)advancedSpellSlotsLevel.Value;                
            }

            AdvancedSpellText();
        }

        private void AdjustSpell(object sender, EventArgs e)
        {
            bool foundSpellLevel = false;
            foreach (AdvancedSpell spell in advancedSpells)
            {
                if (spell.spellLevel == (int)advancedSpellLevel.Value)
                {
                    foundSpellLevel = true;
                    spell.spellNames.Add(advancedSpellName.Text);
                    AdvancedSpellText();                    
                }
            }                       

            if (foundSpellLevel)
            {
                addSpellMessage.Text = "Message: Successfully added spell.";
            }
            else
            {
                addSpellMessage.Text = "Message: Could not add spell, please " + Environment.NewLine + "adjust spell slots for this level.";
            } 
        }
    }
}
