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
    public partial class AddSavedTrait : Form
    {
        public Ability ability = null;
        public Ability action = null;
        public Ability reaction = null;
        public Legendary legendary = null;

        public AddSavedTrait()
        {
            InitializeComponent();
            Translation.Apply(this);
        }

        void SelectItem(object sender, EventArgs e)
        {
                        
        }

        private void AddSavedTrait_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += (senders, es) =>
            {
                richTextBox1.Text = OGLContent.OGL_Abilities[comboBox1.SelectedIndex].Description;
            };

            comboBox2.SelectedIndexChanged += (senders, es) =>
            {
                if (String.IsNullOrEmpty(OGLContent.OGL_Actions[comboBox2.SelectedIndex].Description))
                {
                    richTextBox2.Text = OGLContent.OGL_Actions[comboBox2.SelectedIndex].attack.TextDescribe();
                }
                else 
                {
                    richTextBox2.Text = OGLContent.OGL_Actions[comboBox2.SelectedIndex].Description;
                }                
            };

            comboBox3.SelectedIndexChanged += (senders, es) =>
            {
                richTextBox3.Text = OGLContent.OGL_Reactions[comboBox3.SelectedIndex].Description;
            };

            comboBox4.SelectedIndexChanged += (senders, es) =>
            {
                foreach (LegendaryTrait trait in OGLContent.OGL_Legendary[comboBox4.SelectedIndex].Traits)
                {
                    richTextBox4.Text += trait.Title + " : " + trait.Ability + Environment.NewLine;
                }
            };

            foreach (OGL_Ability item in OGLContent.OGL_Abilities)
            {                
                comboBox1.Items.Add(item.OGL_Creature + " : " + item.Title);             
            }

            foreach (OGL_Ability item in OGLContent.OGL_Actions)
            {
                comboBox2.Items.Add(item.OGL_Creature + " : " + item.Title);
            }

            foreach (OGL_Ability item in OGLContent.OGL_Reactions)
            {
                comboBox3.Items.Add(item.OGL_Creature + " : " + item.Title);
            }

            foreach (OGL_Legendary item in OGLContent.OGL_Legendary)
            {
                comboBox4.Items.Add(item.OGL_Creature + " : " + item.Title);
            }                   
        }

        private void AddSavedTrait_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        ability = OGLContent.OGL_Abilities[comboBox1.SelectedIndex];
                        break;
                    case 1:
                        action = OGLContent.OGL_Actions[comboBox2.SelectedIndex];
                        break;
                    case 2:
                        reaction = OGLContent.OGL_Reactions[comboBox3.SelectedIndex];
                        break;
                    case 3:
                        legendary = OGLContent.OGL_Legendary[comboBox4.SelectedIndex];
                        break;
                }
            }
            catch { ability = null; action = null; reaction = null; legendary = null; }
            //MessageBox.Show(text);
        }
    }
}
