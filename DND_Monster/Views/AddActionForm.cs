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
    public partial class AddActionForm : Form
    {
        public Ability NewAttack = null;
        public Ability NewAbility = null;
        public Ability NewReaction = null;

        public AddActionForm(string currentCR = "")
        {
            InitializeComponent();
            Translation.Apply(this);
        }        

        // Saves the ability or attack based on the selected tab.
        private void Save(object sender, EventArgs e)
        {            
            if (tabControl1.SelectedIndex == 0)
            {
                this.NewAttack = new Ability();
                this.NewAttack.attack = new Attack(
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
                    NewAttack.isSpell = false;
            }
            else if (tabControl1.SelectedIndex == 1)
            {                
                this.NewAbility = new Ability();
                NewAbility.Title = AttackAbilityNameField.Text;
                NewAbility.Description = AttackAbilityDescriptionField.Text;
                NewAbility.isDamage = false;
                NewAbility.isSpell = false;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.NewAbility = new Ability();
                NewAbility.Title = "Multiattack";
                NewAbility.Description = multiAttackDescription.Text;
                NewAbility.isDamage = false;
                NewAbility.isSpell = false;
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                this.NewReaction = new Ability();
                NewReaction.Title = ReactionName.Text;
                NewReaction.Description = ReactionDescription.Text;
                NewReaction.isDamage = false;
                NewReaction.isSpell = false;
            }
            this.Close();
        }

        // Convinence property to get the size of the die from a string.
        private int diceSize(string sizeOfDie)
        {
            int value = 0;
            int.TryParse(sizeOfDie.Split('d')[1], out value);
            return value;
        }

        // Gets the average damage based on dice size, number of and bonus to add.
        private int AverageDamage(int numOfDie, string sizeOfDie, int bonus)
        {            
            int diceSize = 0;
            int.TryParse(sizeOfDie.Split('d')[1], out diceSize);
            int average = (int)((numOfDie * (diceSize / 2)) + ((double)numOfDie * 0.5)) + bonus;                        
            return average;
        }

        // Loads abilities.
        public void LoadAction(Ability values)
        {            
            AttackAbilityNameField.Text = values.Title;
            AttackAbilityDescriptionField.Text = values.Description;            

            NewAbility = values;
            NewAbility.isDamage = false;
            NewAbility.isSpell = false;
            
            tabControl1.SelectedIndex = 1;
        }

        // Loads attacks.
        public void LoadAttack(Ability values)
        {
            NewAttack = values;         
            AttackNameField.Text = values.Title;

            foreach (string item in AttackTypeDropdown.Items)
            {
                if (values.attack._Attack == item)
                {
                    AttackTypeDropdown.SelectedItem = item;
                }
            }

            AttackBonusUpDown.Value = Convert.ToInt32(values.attack.Bonus);

            ReachUpDown.Value = values.attack.Reach;
            RangeUpDownClose.Value = values.attack.RangeClose;
            RangeUpDownFar.Value = values.attack.RangeFar;
            AttackTargetField.Text = values.attack.Target;

            foreach (string item in HitDiceType.Items)
            {
                if (item.Split('d')[1].Contains(values.attack.HitDiceSize.ToString()))
                {
                    HitDiceType.SelectedItem = item;
                }
            }

            HitNumberOfDice.Value = values.attack.HitDiceNumber;
            HitDiceBonusDamage.Value = values.attack.HitDamageBonus;

            foreach (string item in HitDamageType.Items)
            {
                if (item.Contains(values.attack.HitDamageType))
                {
                    HitDamageType.SelectedItem = item;
                }
            }

            HitDamageEffect.Text = values.attack.HitText;

            NewAttack = values;
            NewAttack.isDamage = true;
            NewAttack.isSpell = false;
        }                

        // Loads reactions
        public void LoadReaction(Ability values)
        {
            NewReaction = values;
            ReactionName.Text = values.Title;
            ReactionDescription.Text = values.Description;
            NewReaction.isDamage = false;
            NewReaction.isSpell = false;

            tabControl1.SelectedIndex = 2;
        }

        private void ConfigureRange(object sender, EventArgs e)
        {
            switch (AttackTypeDropdown.SelectedIndex)
            {
                // Melee
                case 0:
                    RangeUpDownClose.Value = 0;
                    RangeUpDownFar.Value = 0;
                    ReachUpDown.Value = 5;
                    break;
                // Ranged
                case 1:
                    RangeUpDownClose.Value = 5;
                    RangeUpDownFar.Value = 5;
                    ReachUpDown.Value = 0;
                    break;
                // Both
                case 2:
                    RangeUpDownClose.Value = 0;
                    RangeUpDownFar.Value = 0;
                    ReachUpDown.Value = 5;
                    break;
            }
        }

        private void FillActionOnTabChange(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                try
                {
                    Ability Attack = new Ability();
                    Attack.attack = new Attack(
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

                    Attack.Title = AttackNameField.Text;
                    Attack.isDamage = true;
                    Attack.isSpell = false;



                    AttackAbilityDescriptionField.Text = Attack.attack.TextDescribe().Replace("*", "");
                    AttackAbilityNameField.Text = Attack.attack._Attack;
                }

                catch
                {

                }
            }

            if (tabControl1.SelectedIndex == 2)
            {
                int numberOfAttacks = 0;
                foreach (Ability attack in Monster._Actions)
                {
                    if (attack.isDamage)
                    {
                        numberOfAttacks++;
                    }
                }
                multiAttackDescription.Text = "The " + Monster.CreatureName + " makes " + numberOfAttacks + " attacks.";
            }
        }

        private void AddActionForm_Load(object sender, EventArgs e)
        {

        }

        private void StrengthAttackButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Monster.CR.AttackBonus + " " + Monster.CR.profBonus);
            HitDiceBonusDamage.Value = Convert.ToInt32(Monster.StatMod(Monster.STR));
            AttackBonusUpDown.Value = Convert.ToInt32(Monster.StatMod(Monster.STR)) + Monster.CR.profBonus;           
        }

        private void DexterityAttackButton_Click(object sender, EventArgs e)
        {
            HitDiceBonusDamage.Value = Convert.ToInt32(Monster.StatMod(Monster.DEX));
            AttackBonusUpDown.Value = Convert.ToInt32(Monster.StatMod(Monster.DEX)) + Monster.CR.profBonus; 
        }

        private void FilterColon(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ':')
            {
                e.Handled = true;
            }
        }
    }
}
