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
            textBox1.Text = values.Title;
            richTextBox1.Text = values.Description;
        }

        private void AddAbilityForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { this.Text = textBox1.Text; }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NewAbility = new Ability();
            NewAbility.Title = textBox1.Text;
            NewAbility.Description = richTextBox1.Text;
            NewAbility.isDamage = false;
            this.Close();
        }
    }
}
