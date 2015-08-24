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

        public void LoadAbility(Ability values)
        {
            AbilityNameTextBox.Text = values.Title;
            DescriptionTextBox.Text = values.Description;
            NewAbility = values;
            NewAbility.isSpell = false;
        }

        public void LoadSpell(Ability values)
        {            
            tabControl1.SelectedIndex = 1;
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
                string spellText = ToDescription();
                NewAbility.Title = SpellClass.Text + " Spellcasting";
                NewAbility.Description = spellText; 
                NewAbility.isSpell = true;
                NewAbility.isDamage = false;                
            }
            this.Close();
        }

        private string ToDescription()
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
                    if (Convert.ToInt32(item.Split('|')[0]) == i)
                    {
                        spellText += item.Split('|')[0].Trim() + ":" + item.Split('|')[1].Trim() + ",";
                    }
                }
            }

            spellText += "|";
            return spellText;
        }
        
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (SpellList.SelectedItem == null) return;
            SpellList.Items.Remove(SpellList.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpellList.Items.Add(numericUpDown1.Value + " | " + textBox1.Text);
            textBox1.Text = "";
        }        
    }
}
