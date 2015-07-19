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

        public AddAttackForm()
        {
            InitializeComponent();
        }

        private void AddAttackForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (tabControl1.SelectedIndex == 0)
            {                
                this.NewAttack = new Attack(
                    comboBox1.Text,
                    numericUpDown1.Value.ToString(),
                    comboBox2.Text,
                    (int)numericUpDown2.Value,
                    textBox3.Text,
                    textBox1.Text);
                NewAttack.Title = textBox2.Text;
                NewAttack.isDamage = true;
            }
            else if (tabControl1.SelectedIndex == 1)
            {                
                this.NewAbility = new Ability();
                NewAbility.Title = textBox4.Text;
                NewAbility.Description = richTextBox1.Text;
                NewAbility.isDamage = false;
            }
            this.Close();
        }

        public void LoadAttack(Attack values)
        {
            this.Text = values.Title;
            textBox2.Text = values.Title;

            foreach (string item in comboBox1.Items)
            {
                if (values._Attack == item)
                {
                    comboBox1.SelectedItem = item;
                }
            }

            numericUpDown1.Value = Convert.ToInt32(values.Bonus);

            foreach (string item in comboBox2.Items)
            {
                if (values.RangeMode == item)
                {
                    comboBox2.SelectedItem = item;
                }
            }

            numericUpDown2.Value = values.Range;
            textBox3.Text = values.Target;
            textBox1.Text = values.Hit;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
