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
            comboBox5.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;            

            foreach (string creature in OGLContent.OGL_Creatures)
            {
                comboBox5.Items.Add(creature);
            }            

            comboBox1.SelectedIndexChanged += (senders, es) =>
            {                
                foreach (OGL_Ability _ability in OGLContent.OGL_Abilities)
                {
                    if (_ability.OGL_Creature == comboBox5.Text && _ability.Title == comboBox1.Text)
                    {
                        richTextBox1.Text = _ability.Description;
                    }
                }
            };

            comboBox2.SelectedIndexChanged += (senders, es) =>
            {
                foreach (OGL_Ability _action in OGLContent.OGL_Actions)
                {
                    if (_action.OGL_Creature == comboBox5.Text && _action.Title == comboBox2.Text)
                    {                        
                        if (String.IsNullOrEmpty(_action.Description))
                        {
                            richTextBox2.Text = _action.attack.TextDescribe();
                        }
                        else
                        {
                            richTextBox2.Text = _action.Description;
                        }
                    }
                }
                //if (String.IsNullOrEmpty(OGLContent.OGL_Actions[comboBox2.SelectedIndex].Description))
                //{
                //    //richTextBox2.Text = OGLContent.OGL_Actions[comboBox2.SelectedIndex].attack.TextDescribe();
                //}
                //else 
                //{
                //    //richTextBox2.Text = OGLContent.OGL_Actions[comboBox2.SelectedIndex].Description;
                //}                
            };

            comboBox3.SelectedIndexChanged += (senders, es) =>
            {
                //richTextBox3.Text = OGLContent.OGL_Reactions[comboBox3.SelectedIndex].Description;
            };

            comboBox4.SelectedIndexChanged += (senders, es) =>
            {
                //foreach (OGL_ trait in OGLContent.OGL_Legendary[comboBox4.SelectedIndex].Traits)
                //{
                //    //richTextBox4.Text += trait.Title + " : " + trait.Ability + Environment.NewLine;
                //}
            };            
        }

        private void AddSavedTrait_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        foreach (OGL_Ability _ability in OGLContent.OGL_Abilities)
                        {
                            if (_ability.OGL_Creature == comboBox5.Text && _ability.Title == comboBox1.Text)
                            {
                                ability = _ability;
                            }
                        }                        
                        break;
                    case 1:
                        foreach (OGL_Ability _action in OGLContent.OGL_Actions)
                        {
                            if (_action.OGL_Creature == comboBox5.Text && _action.Title == comboBox2.Text)
                            {
                                action = _action;
                            }
                        }                        
                        break;
                    case 2:
                        foreach (OGL_Ability _reaction in OGLContent.OGL_Reactions)
                        {
                            if (_reaction.OGL_Creature == comboBox5.Text && _reaction.Title == comboBox3.Text)
                            {
                                reaction = _reaction;
                            }
                        }
                        break;
                    case 3:
                        foreach (OGL_Legendary _legendary in OGLContent.OGL_Legendary)
                        {
                            if (_legendary.OGL_Creature == comboBox5.Text && _legendary.Title == comboBox4.Text)
                            {
                                legendary = _legendary;
                            }
                        }
                        break;
                }
            }
            catch { ability = null; action = null; reaction = null; legendary = null; }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ability = null;
            action = null;
            legendary = null;
            reaction = null;            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {                        
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();            

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";

            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";

            foreach (OGL_Ability _ability in OGLContent.OGL_Abilities)
            {
                if (_ability.OGL_Creature == comboBox5.Text)
                {
                    comboBox1.Items.Add(_ability.Title);
                }
            }

            foreach (OGL_Ability _action in OGLContent.OGL_Actions)
            {
                if (_action.OGL_Creature == comboBox5.Text)
                {
                    comboBox2.Items.Add(_action.Title);
                }
            }

            foreach (OGL_Ability _reaction in OGLContent.OGL_Reactions)
            {
                if (_reaction.OGL_Creature == comboBox5.Text)
                {
                    comboBox3.Items.Add(_reaction.Title);
                }
            }

            foreach (OGL_Legendary _legendary in OGLContent.OGL_Legendary)
            {
                if (_legendary.OGL_Creature == comboBox5.Text && !comboBox4.Items.Contains(_legendary.Title))
                {
                    comboBox4.Items.Add(_legendary.Title);
                }
            }

            if (comboBox4.Items.Count > 0)
            {
                tabControl1.SelectTab(3);
            }

            if (comboBox3.Items.Count > 0)
            {
                tabControl1.SelectTab(2);
            }
            
            if (comboBox2.Items.Count > 0)
            {
                tabControl1.SelectTab(1);
            }
            
            if (comboBox1.Items.Count > 0)            
            {
                tabControl1.SelectTab(0);
            }
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    if (!(comboBox1.Items.Count > 0))
                    {
                        e.Cancel = true;
                    }
                    break;
                case 1:
                    if (!(comboBox2.Items.Count > 0))
                    {
                        e.Cancel = true;
                    }
                    break;
                case 2:
                    if (!(comboBox3.Items.Count > 0))
                    {
                        e.Cancel = true;
                    }
                    break;
                case 3:
                    if (!(comboBox4.Items.Count > 0))
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {            
        }
    }
}
