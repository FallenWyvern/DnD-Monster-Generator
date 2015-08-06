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
    public partial class AddAttackForm : Form
    {
        public Ability NewAttack = null;
        public Ability NewAbility = null;

        public AddAttackForm(string currentCR = "")
        {
            InitializeComponent();            
        }

        private void AddAttackForm_Load(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {            
            if (tabControl1.SelectedIndex == 0)
            {
                this.NewAttack = new Attack(
                    AttackTypeDropdown.Text,
                    AttackBonusUpDown.Value.ToString(),
                    (int)ReachUpDown.Value,
                    (int)RangeUpDownClose.Value,
                    (int)RangeUpDownFar.Value,
                    AttackTargetField.Text,
                    AverageDamage((int)HitNumberOfDice.Value, HitDiceType.Text, (int)HitDiceBonusDamage.Value),
                    (int)HitNumberOfDice.Value,
                    diceSize(HitDiceType.Text),
                    (int)HitDiceBonusDamage.Value,
                    HitDamageType.Text,
                    HitDamageEffect.Text);

                    NewAttack.Title = AttackNameField.Text;
                    NewAttack.isDamage = true;
            }
            else if (tabControl1.SelectedIndex == 1)
            {                
                this.NewAbility = new Ability();
                NewAbility.Title = AttackAbilityNameField.Text;
                NewAbility.Description = AttackAbilityDescriptionField.Text;
                NewAbility.isDamage = false;
            }
            this.Close();
        }

        private int diceSize(string sizeOfDie)
        {
            int value = 0;
            int.TryParse(sizeOfDie.Split('d')[1], out value);
            return value;
        }

        private int AverageDamage(int numOfDie, string sizeOfDie, int bonus)
        {            
            int diceSize = 0;
            int.TryParse(sizeOfDie.Split('d')[1], out diceSize);
            int average = (int)((numOfDie * (diceSize / 2)) + ((double)numOfDie * 0.5)) + bonus;                        
            return average;
        }

        public void LoadAttack(Ability values)
        {
            AttackAbilityNameField.Text = values.Title;
            AttackAbilityDescriptionField.Text = values.Description;            
            NewAbility = values;
            NewAbility.isDamage = false;
        }

        public void LoadAttack(Attack values)
        {            
            AttackNameField.Text = values.Title;

            foreach (string item in AttackTypeDropdown.Items)
            {
                if (values._Attack == item)
                {
                    AttackTypeDropdown.SelectedItem = item;
                }
            }

            AttackBonusUpDown.Value = Convert.ToInt32(values.Bonus);

            ReachUpDown.Value = values.Reach;
            RangeUpDownClose.Value = values.RangeClose;
            RangeUpDownFar.Value = values.RangeFar;
            AttackTargetField.Text = values.Target;

            foreach (string item in HitDiceType.Items)
            {
                if (item.Split('d')[1].Contains(values.HitDiceSize.ToString()))
                {
                    HitDiceType.SelectedItem = item;
                }
            }

            HitNumberOfDice.Value = values.HitDiceNumber;
            HitDiceBonusDamage.Value = values.HitDamageBonus;

            foreach (string item in HitDamageType.Items)
            {
                if (item.Contains(values.HitDamageType))
                {
                    HitDamageType.SelectedItem = item;
                }
            }

            HitDamageEffect.Text = values.HitText;

            NewAttack = values;
            NewAttack.isDamage = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddAttackForm_Leave(object sender, EventArgs e)
        {

        }
    }
}
