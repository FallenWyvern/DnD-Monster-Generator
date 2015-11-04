using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace DND_Monster
{
    public static class Translation
    {
        static List<string> translation = new List<string>();
        static TranslationData translationData = new TranslationData();

        public static void Apply(Form target)
        {
            if (translationData.data == null) return;

            if (target is DND_Monster.Main)
            {
                #region
                DND_Monster.Main temp = (DND_Monster.Main)target;
                foreach (Control c in temp.panel1.Controls)
                {
                    foreach (string item in translationData.data.main.items)
                    {
                        if (c.Name == item.Split(':')[0])
                        {
                            try { TranslateControl(c, item); }
                            catch (Exception ex) { Console.WriteLine("Error: " + item.Split(':')[0] + " " + ex.Message); }
                        }
                    }
                }
                foreach (Control c in temp.panel2.Controls)
                {
                    foreach (string item in translationData.data.main.items)
                    {
                        if (c.Name == item.Split(':')[0])
                        {
                            try { TranslateControl(c, item); }
                            catch (Exception ex) { Console.WriteLine("Error: " + item.Split(':')[0] + " " + ex.Message); }
                        }
                    }
                }
                #endregion
            }            

            if (target is AddAbilityForm)
            {
                #region
                AddAbilityForm temp = (AddAbilityForm)target;                
                foreach (Control c in temp.Controls)
                {
                    if (c is TabControl)
                    {
                        TabControl tctemp = (TabControl)c;
                        foreach (TabPage i in tctemp.Controls)
                        {
                            foreach (Control item in i.Controls)
                            {
                                foreach (string ability in translationData.data.ability.items)
                                {                                    
                                    if (item.Name == ability.Split(':')[0])
                                    {
                                        TranslateControl(item, ability);
                                    }
                                }

                                if (item is TableLayoutPanel)
                                {
                                    TableLayoutPanel tabletemp = (TableLayoutPanel)item;

                                    for (int x = 0; x < tabletemp.ColumnCount; x++)
                                    {
                                        for (int y = 0; y < tabletemp.RowCount; y++)
                                        {
                                            Control check = tabletemp.GetControlFromPosition(x, y);
                                            
                                            foreach (string ability in translationData.data.ability.items)
                                            {
                                                if (check.Name == ability.Split(':')[0])
                                                {
                                                    TranslateControl(check, ability);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }                   
                }
                #endregion
            }

            if (target is AddActionForm)
            {
                #region
                AddActionForm temp = (AddActionForm)target;
                foreach (Control c in temp.Controls)
                {
                    if (c is TabControl)
                    {
                        TabControl tctemp = (TabControl)c;
                        foreach (TabPage i in tctemp.Controls)
                        {
                            foreach (Control item in i.Controls)
                            {
                                foreach (string action in translationData.data.action.items)
                                {
                                    if (item.Name == action.Split(':')[0])
                                    {
                                        TranslateControl(item, action);
                                    }
                                }
                            }
                        }                        
                    }
                }
                #endregion
            }

            if (target is AddLegendaryForm)
            {
                #region
                AddLegendaryForm temp = (AddLegendaryForm)target;
                foreach (Control c in temp.Controls)
                {
                    foreach (string item in translationData.data.legendary.items)
                    {
                        if (c.Name == item.Split(':')[0])
                        {
                            try { TranslateControl(c, item); }
                            catch (Exception ex) { Console.WriteLine("Error: " + item.Split(':')[0] + " " + ex.Message); }
                        }
                    }
                }
                #endregion
            }

            if (target is CustomSpeed)
            {
                #region
                CustomSpeed temp = (CustomSpeed)target;
                foreach (Control c in temp.Controls)
                {
                    foreach (string item in translationData.data.speed.items)
                    {
                        if (c.Name == item.Split(':')[0])
                        {
                            try { TranslateControl(c, item); }
                            catch (Exception ex) { Console.WriteLine("Error: " + item.Split(':')[0] + " " + ex.Message); }
                        }
                    }
                }
                #endregion
            }
        }

        private static void TranslateControl(Control c, string translation)
        {
            if (c is ComboBox)
            {
                ComboBox temp = (ComboBox)c;
                for (int i = 0; i < temp.Items.Count; i++)
                {
                    if ((string)temp.Items[i] == translation.Split(':')[1])
                    {
                        temp.Items[i] = translation.Split(':')[2];
                    }
                }
                return;
            }

            int outInt = 0;
            if (!String.IsNullOrEmpty(c.Text))
            {
                if (!int.TryParse(c.Text, out outInt))
                {
                    //System.IO.File.AppendAllText(filename, type + " : " + c.Name + " : " + c.Text + Environment.NewLine);
                    c.Text = translation.Split(':')[2];
                }
            }
        }

        public static void LoadTranslationFile(string target)
        {
            if (File.Exists(target))
            {
                translation = File.ReadAllLines(target).ToList<string>();
                translationData = JsonConvert.DeserializeObject<TranslationData>(File.ReadAllText(target));
            }
        }

        public static void ResetTranslation()
        {

        }

        public class Main
        {
            public List<string> items { get; set; }
        }

        public class PopUp
        {
            public List<string> items { get; set; }
        }

        public class Action
        {
            public List<string> items { get; set; }
        }

        public class Ability
        {
            public List<string> items { get; set; }
        }

        public class Legendary
        {
            public List<string> items { get; set; }
        }

        public class Speed
        {
            public List<string> items { get; set; }
        }

        public class Data
        {
            public Main main { get; set; }
            public PopUp popup { get; set; }
            public Action action { get; set; }
            public Ability ability { get; set; }
            public Legendary legendary { get; set; }
            public Speed speed { get; set; }
        }

        public class TranslationData
        {
            public Data data { get; set; }
        }
    }
}
