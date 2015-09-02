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
        public static Ability ability = null;
        public static Ability action = null;
        public static Ability reaction = null;
        public static Legendary legendary = null;

        public AddSavedTrait()
        {
            InitializeComponent();
            AbilityGrid.DoubleClick += SelectItem;
            ActionGrid.DoubleClick += SelectItem;
            ReactionGrid.DoubleClick += SelectItem;
            LegendaryGrid.DoubleClick += SelectItem;
        }

        void SelectItem(object sender, EventArgs e)
        {
                        
        }

        private void AddSavedTrait_Load(object sender, EventArgs e)
        {
            foreach (Ability ability in Monster._Abilities)
            {                
               AbilityGrid.Rows.Add(new Object[] { ability.Title, ability.Description });                
            }

            foreach (Ability action in Monster._Actions)
            {
                if (action.isDamage)
                {
                    ActionGrid.Rows.Add(new Object[] { action.Title, action.attack.WebDescribe() });
                }
                else
                {
                    ActionGrid.Rows.Add(new Object[] { action.Title, action.Description });
                }
            }

            foreach (Ability reaction in Monster._Reactions)
            {
                ReactionGrid.Rows.Add(new Object[] { reaction.Title, reaction.Description });
            }

            foreach (Legendary legendary in Monster._Legendaries)
            {
                string x = "";
                foreach (LegendaryTrait trait in legendary.Traits)
                {
                    x += trait.Title + ", ";
                }
                x = x.Substring(0, x.Length - 2);

                LegendaryGrid.Rows.Add(new Object[] { legendary.Title, x});
            }
        }
    }
}
