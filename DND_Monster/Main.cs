using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

using Newtonsoft;
using Newtonsoft.Json;

namespace DND_Monster
{
    public partial class Main : Form
    {        
        ChromiumWebBrowser b = new ChromiumWebBrowser("http://rendering/");
        Challenge_Rating currentCR = new Challenge_Rating();
        List<Control> statModList = new List<Control>();
        static string saveFilename = "";

        public Main()
        {
            InitializeComponent();           
        }

        private void CefStartup()
        {
            CefSettings _settings = new CefSettings
            {
                PackLoadingDisabled = true                
            };
            
            Cef.Initialize(_settings);
            BrowserSettings settings = new BrowserSettings
            {
                FileAccessFromFileUrlsAllowed = true,
                UniversalAccessFromFileUrlsAllowed = true,
                WebSecurityDisabled = true
            };
            b.BrowserSettings = settings;
        }
             

        // Set all drop downs and updowns to their starting values and set events.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check for version update here.
            
            currentCR = Help.ChallengeRatings[0];
            ChallengeRatingDropDown.SelectedIndex = 0;
            AlignmentDropDown.SelectedIndex = AlignmentDropDown.Items.Count - 1;
            HitDieDropDown.SelectedIndex = 0;
            SizeDropDown.SelectedIndex = 0;
            SkillDropDown.SelectedIndex = 0;

            StrUpDown.ValueChanged += modchanged_ValueChanged;
            DexUpDown.ValueChanged += modchanged_ValueChanged;
            ConUpDown.ValueChanged += modchanged_ValueChanged;
            IntUpDown.ValueChanged += modchanged_ValueChanged;
            WisUpDown.ValueChanged += modchanged_ValueChanged;
            ChaUpDown.ValueChanged += modchanged_ValueChanged;

            // StrSaveBonusUpDown.ValueChanged += savingThrowModify;
            // DexSaveBonusUpDown.ValueChanged += savingThrowModify;
            // ConSaveBonusUpDown.ValueChanged += savingThrowModify;
            // IntSaveBonusUpDown.ValueChanged += savingThrowModify;
            // WisSaveBonusUpDown.ValueChanged += savingThrowModify;
            // ChaSaveBonusUpDown.ValueChanged += savingThrowModify;

            statModList.Add(StrBonus);
            statModList.Add(DexBonus);
            statModList.Add(ConBonus);
            statModList.Add(IntBonus);
            statModList.Add(ChaBonus);
            statModList.Add(WisBonus);

            AddVulnerabilityButton.Click += addCondition;            
            DamageModificationType.SelectedIndex = 0;

            TraitsList.Sorted = true;

            CefStartup();

            b.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(b, 0, 0);

            this.FormClosing += (senderEnd, eEnd) => { Cef.Shutdown(); };

            if (!System.IO.File.Exists("skipupdate.dat") && !Help.CheckForDownload())
            {
                if (MessageBox.Show("New Version Available. Open Download Page?", "New Version", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"http://thegeniusinc.com/dd-monster-maker-download/?ref=" + Help.Version);
                }
            }

            this.Text = this.Text + " v" + Help.Version;
        }       

        // This updates the labels next to stats, when the stats change.
        // This uses tags on the controls to match the numericUpDown to the Label.
        private void modchanged_ValueChanged(object sender, EventArgs e)
        {            
            var temp = (NumericUpDown)sender;
            
            foreach (Control item in statModList)
            {
                if (item.Tag != null)
                {                    
                    if (item.Tag.ToString().Contains(temp.Tag.ToString()))
                    {                        
                        UpdateModifier(temp, (Label)item);
                        return;
                    }
                }
            }
        }      

        // This updates the proficiency based on CR.
        private void crChangedUpdateProficiency(object sender, EventArgs e)
        {            
            foreach (Challenge_Rating cr in Help.ChallengeRatings)
            {
                if (cr.CR == ChallengeRatingDropDown.Text)
                {
                    SkillBonus.Value = cr.profBonus;                    
                    currentCR = cr;
                    ProfBonus.Text = "+" + cr.profBonus;
                }
            }
        }
        
        // Adds senses to TraitList
        private void addSense(object sender, EventArgs e)
        {
            string addString = "Sense: " + SensesDropDown.Text;
            
            if (SensesDropDown.Text != "Passive Perception")
            {
                addString += " " + DistanceUpDown.Value + " ft";
            }

            TraitsList.Items.Add(addString);
        }

        // Adds languages to TraitList
        private void addLanguage(object sender, EventArgs e)
        {
            TraitsList.Items.Add("Language: " + LanguageComboBox.Text);
        }

        // Adds skills to TraitList
        private void addSkill(object sender, EventArgs e)
        {                      
            string skillToAdd = "Skill: ";
            int totalBonus = 0;
            int statBonus = 0;
            int profBonus = 0;
            int skillBonus = 0;

            skillToAdd += SkillDropDown.Text + " %BONUS% (";

            if (SkillStatCheckBox.Checked)
            {
                switch (SkillDropDown.Text.Split('(')[1].Replace(")", ""))
                {
                    case "Str":
                        int.TryParse(StrBonus.Text, out statBonus);
                        break;
                    case "Dex":
                        int.TryParse(DexBonus.Text, out statBonus);
                        break;
                    case "Con":
                        int.TryParse(ConBonus.Text, out statBonus);
                        break;
                    case "Int":
                        int.TryParse(IntBonus.Text, out statBonus);
                        break;
                    case "Wis":
                        int.TryParse(WisBonus.Text, out statBonus);
                        break;
                    case "Cha":
                        int.TryParse(ChaBonus.Text, out statBonus);
                        break;
                }

                skillToAdd += SkillDropDown.Text.Split('(')[1].Replace(")", "") + " " + statBonus + ", ";                
            }

            if (SkillProfCheckBox.Checked)
            {                
                profBonus = currentCR.profBonus;
                skillToAdd += "Prof. " + profBonus + ", ";
            }

            if (SkillBonusCheckBox.Checked)
            {
                skillBonus = (int)SkillBonus.Value;
                skillToAdd += "Bonus " + skillBonus;
            }

            skillToAdd += ")";

            totalBonus = statBonus + profBonus + skillBonus;

            if (totalBonus != 0)
            {
                if (totalBonus < 0)
                {
                    TraitsList.Items.Add(skillToAdd.Replace("%BONUS%", "" + totalBonus + " |"));
                }
                else
                {
                    TraitsList.Items.Add(skillToAdd.Replace("%BONUS%", "+" + totalBonus + " |"));
                }
            }
        }
        
        // Adds abilites to both the Monster._Abilities and TraitList
        private void addAbility(object sender, EventArgs e)
        {
            AddAbilityForm addAbility = new AddAbilityForm();
            addAbility.Show();

            addAbility.FormClosing += (senders, es) =>
            {
                if (addAbility.NewAbility != null)
                {                    
                    Monster.AddAbility(addAbility.NewAbility);
                    TraitsList.Items.Add("Ability: " + addAbility.NewAbility.Title);
                }
            };
        }

        // Adds attacks to both the Monster._Attacks and TraitList
        private void addAction(object sender, EventArgs e)
        {
            AddActionForm addAttack = new AddActionForm(ChallengeRatingDropDown.Text);
            addAttack.Show();

            addAttack.FormClosing += (senders, es) =>
            {
                if (addAttack.NewAttack != null)
                {
                    Console.WriteLine("1");
                    if (TraitsList.Items.Contains(addAttack.NewAttack.Title)) { addAttack.NewAttack.Title += "_"; }                    
                    Monster.AddAction(addAttack.NewAttack);
                    TraitsList.Items.Add("Action: " + addAttack.NewAttack.Title);                    
                }

                if (addAttack.NewAbility != null)
                {
                    Console.WriteLine("2");
                    if (TraitsList.Items.Contains(addAttack.NewAbility.Title)) { addAttack.NewAbility.Title += "_"; }                    
                    Monster.AddAction(addAttack.NewAbility);
                    TraitsList.Items.Add("Action: " + addAttack.NewAbility.Title);                        
                }

                if (addAttack.NewReaction != null)
                {
                    Console.WriteLine("3");
                    if (TraitsList.Items.Contains(addAttack.NewReaction.Title)) { addAttack.NewReaction.Title += "_"; }
                    Monster.AddReaction(addAttack.NewReaction);
                    TraitsList.Items.Add("Reaction: " + addAttack.NewReaction.Title);                        
                }
            };
        }

        // Adds a Legendary
        private void AddLegendary(object sender, EventArgs e)
        {
            AddLegendaryForm addLegendary = new AddLegendaryForm();
            addLegendary.Show();

            addLegendary.FormClosing += (senders, es) =>
            {
                addLegendary.SerializeTraits();
                if (addLegendary.LegendaryAbility != null)
                {                    
                    if (TraitsList.Items.Contains(addLegendary.LegendaryAbility.Title)) { addLegendary.LegendaryAbility.Title += "_"; }                    
                    Monster.AddLegendary(addLegendary.LegendaryAbility);
                    TraitsList.Items.Add("Legendary: " + addLegendary.LegendaryAbility.Title);
                }
            };
        }

        // Adds Condition Resistance, Immunity, Vulerability to TraitList
        private void addCondition(object sender, EventArgs e)
        {
            string tag = DamageModificationType.Items[DamageModificationType.SelectedIndex].ToString();
            string addString = "";
            
            if (DamageConditionDropDown.SelectedIndex > 13 && tag != "Immunity")
            {
                return;
            }

            if (DamageConditionDropDown.SelectedIndex < 13)
            {
                addString += "Damage";
            }
            else
            {
                addString += "Condition";
            }

            switch (tag)
            {
                case "Immunity":
                    // Immunity
                    addString += " Immunity: ";
                    break;
                case "Resistance":
                    // Resistance
                    addString += " Resistance: ";
                    break;
                case "Vulnerability":
                    // Vulnerability
                    addString += " Vulnerability: ";
                    break;
            }

            addString += DamageConditionDropDown.Text;
            
            if (TraitException.Text.Length > 0){
                addString += " " + TraitException.Text;
            }
            
            TraitsList.Items.Add(addString);
        }

        /* Edits selected item in the TraitList. If it's an Ability/Attack,
        Open the appropriate window and load that data. */
        private void editTrait(object sender, MouseEventArgs e)
        {                        
            if (TraitsList.SelectedItem == null) return;
                
            if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Legendary")
            {
                AddLegendaryForm loadLegendary = new AddLegendaryForm();
                    
                foreach (Legendary legendary in Monster._Legendaries)
                {
                    if (legendary.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                    {
                        loadLegendary.LoadLegendary(legendary);
                        loadLegendary.Show();

                        loadLegendary.FormClosing += (senderx, ex) =>
                        {
                            loadLegendary.SerializeTraits();
                            int index = Monster._Legendaries.IndexOf(legendary);
                            Monster._Legendaries.RemoveAt(index);
                            Monster._Legendaries.Insert(index, loadLegendary.LegendaryAbility);

                            index = TraitsList.Items.IndexOf(TraitsList.SelectedItem);
                            TraitsList.Items.RemoveAt(index);
                            TraitsList.Items.Insert(index, "Legendary: " + loadLegendary.LegendaryAbility.Title);
                        };
                        return;
                    }
                }
            }

            if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Action")
            {
                AddActionForm loadAttack = new AddActionForm();

                foreach (Ability attack in Monster._Actions)
                {
                    if (attack.isDamage)
                    {
                        if (attack.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {
                            loadAttack.LoadAttack(attack);                                
                            loadAttack.Show();

                            loadAttack.FormClosing += (senderx, ex) =>
                            {
                                int index = Monster._Actions.IndexOf(attack);
                                Monster._Actions.RemoveAt(index);                                    
                                Monster._Actions.Insert(index, loadAttack.NewAttack);

                                index = TraitsList.Items.IndexOf(TraitsList.SelectedItem);
                                TraitsList.Items.RemoveAt(index);
                                TraitsList.Items.Insert(index, "Action: " + loadAttack.NewAttack.Title);
                            };
                            return;
                        }
                    }

                    if (!attack.isDamage)
                    {
                        if (attack.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {
                            loadAttack.LoadAction((Ability)attack);
                            loadAttack.Show();

                            loadAttack.FormClosing += (senderx, ex) =>
                            {
                                int index = Monster._Actions.IndexOf(attack);
                                Monster._Actions.RemoveAt(index);
                                Monster._Actions.Insert(index, loadAttack.NewAbility);

                                index = TraitsList.Items.IndexOf(TraitsList.SelectedItem);
                                TraitsList.Items.RemoveAt(index);
                                TraitsList.Items.Insert(index, "Action: " + loadAttack.NewAbility.Title);
                            };
                            return;
                        }
                    }
                }
            }

            if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Reaction")
            {
                AddActionForm loadReaction = new AddActionForm();

                foreach (Ability reaction in Monster._Reactions)
                {
                    if (reaction.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                    {
                        loadReaction.LoadReaction(reaction);
                        loadReaction.Show();

                        loadReaction.FormClosing += (senderx, ex) =>
                        {
                            int index = Monster._Reactions.IndexOf(reaction);
                            Monster._Reactions.RemoveAt(index);
                            Monster._Reactions.Insert(index, loadReaction.NewReaction);

                            index = TraitsList.Items.IndexOf(TraitsList.SelectedItem);
                            TraitsList.Items.RemoveAt(index);
                            TraitsList.Items.Insert(index, "Reaction: " + loadReaction.NewReaction.Title);
                        };
                        return;
                    }                        
                }
            }

            if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Ability")
            {
                AddAbilityForm loadAbility = new AddAbilityForm();

                foreach (Ability ability in Monster._Abilities)
                {
                    if (ability.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                    {
                        if (ability.isSpell)
                        {
                            loadAbility.LoadSpell(ability);
                        }
                        else
                        {
                            loadAbility.LoadAbility(ability);
                        }
                        loadAbility.Show();

                        loadAbility.FormClosing += (senderx, ex) =>
                        {
                            int index = Monster._Abilities.IndexOf(ability);
                            Monster._Abilities.RemoveAt(index);
                            Monster._Abilities.Insert(index, loadAbility.NewAbility);

                            index = TraitsList.Items.IndexOf(TraitsList.SelectedItem);
                            TraitsList.Items.RemoveAt(index);
                            TraitsList.Items.Insert(index, "Ability: " + loadAbility.NewAbility.Title);
                        };
                        return;
                    }
                }
            }
        }                        

        /* Removes trait from the traitlist. If it's an attack, 
        ability or legendary also remove it from the monster. */
        private void deleteTrait(object sender, MouseEventArgs e)
        {            
            if (e.Button == System.Windows.Forms.MouseButtons.Right || sender.GetType() == typeof(Button))
            {
                if (TraitsList.Items.Count < 1 || TraitsList.SelectedItem == null) return;
                if (MessageBox.Show("Are you sure you wish to delete the selected item?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; }

                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Ability")
                {                    
                    Ability temp = null;

                    foreach (Ability item in Monster._Abilities)
                    {                        
                        if (item.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {                            
                            temp = item;
                        }
                    }

                    if (temp != null)
                    {                        
                        Monster._Abilities.Remove(temp);
                        TraitsList.Items.Remove(TraitsList.SelectedItem);
                    }
                }

                if (TraitsList.Items.Count < 1 || TraitsList.SelectedItem == null) return;
                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Action")
                {                    
                    Ability temp = null;

                    foreach (Ability item in Monster._Actions)
                    {                        
                        if (item.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {
                            temp = item;                            
                        }
                    } 

                    if (temp != null)
                    {
                        Monster._Actions.Remove(temp);
                        TraitsList.Items.Remove(TraitsList.SelectedItem);
                    }
                }

                if (TraitsList.Items.Count < 1 || TraitsList.SelectedItem == null) return;
                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Legendary")
                {
                    Legendary temp = null;

                    foreach (Legendary item in Monster._Legendaries)
                    {
                        if (item.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {
                            temp = item;
                        }
                    }

                    if (temp != null)
                    {
                        Monster._Legendaries.Remove(temp);
                        TraitsList.Items.Remove(TraitsList.SelectedItem);
                    }
                }

                if (TraitsList.Items.Count < 1 || TraitsList.SelectedItem == null) return;
                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Reaction")
                {
                    Ability temp = null;

                    foreach (Ability item in Monster._Reactions)
                    {
                        if (item.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {
                            temp = item;
                        }
                    }

                    if (temp != null)
                    {
                        Monster._Reactions.Remove(temp);
                        TraitsList.Items.Remove(TraitsList.SelectedItem);
                    }
                }

                if (TraitsList.Items.Count < 1 || TraitsList.SelectedItem == null) return;
                if (TraitsList.Items.Contains(TraitsList.SelectedItem))
                {
                    TraitsList.Items.Remove(TraitsList.SelectedItem);
                }                
            }            
        }
        
        // Generates data, then passes it to the appropriate template.
        private void Preview(object sender, EventArgs e)
        {
            SortTraits();
            Help.useBG = BackgroundCheckbox.Checked;
            Monster.columns = (int)PreviewColumns.Value;            

            GenerateMonsterData();
            ShowMonster();
        }

        private void Sort()
        {
            foreach (string item in TraitsList.Items)
            {

            }
        }

        // Converts monster to JSON, then saves to file.
        private void SaveData(object sender, EventArgs e)
        {            
            Data jsonMonster = new Data();
            GenerateMonsterData();
            Monster.Output(jsonMonster);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Help.LastDirectory;
            dialog.Filter = "mm files (*.mm)|*.mm";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Help.LastDirectory = dialog.FileName;
                System.IO.File.WriteAllText(dialog.FileName, JsonConvert.SerializeObject(jsonMonster));
            }
        }

        // Converts JSON string to Monster, loading data.
        private void LoadData(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Help.LastDirectory;
            dialog.Filter = "mm files (*.mm)|*.mm";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Help.LastDirectory = dialog.FileName;

                Data jsonMonster = new Data();
                jsonMonster = JsonConvert.DeserializeObject<Data>(System.IO.File.ReadAllText(dialog.FileName));
                TraitsList.Items.Clear();
                TraitsList.Sorted = false;

                Monster.Input(jsonMonster);                

                currentCR = Monster.CR;
                ChallengeRatingDropDown.Text = "";
                ChallengeRatingDropDown.SelectedText = Help.FindCRByIndex(Monster.CR.Index).CR;
                crChangedUpdateProficiency(null, null);
                
                AlignmentDropDown.Text = "";
                AlignmentDropDown.SelectedText = Monster.CreatureAlign;

                StrUpDown.Value = Monster.STR;
                DexUpDown.Value = Monster.DEX;
                ConUpDown.Value = Monster.CON;
                WisUpDown.Value = Monster.WIS;
                IntUpDown.Value = Monster.INT;
                ChaUpDown.Value = Monster.CHA;

                string[] speeds = Monster.Speed.Split(',');
                
                foreach (string speed in speeds)
                {
                    Console.WriteLine(speed);
                    string check = speed.Split(':')[0].Trim();                    
                    switch (check)
                    {
                        case "Burrow":
                            try
                            {
                                int Burrow = 0;
                                int.TryParse(speed.Split(':')[1].Replace("ft.", ""), out Burrow);
                                burrowUpDown.Value = Burrow;
                            }
                            catch { }
                            break;
                        case "Climb":
                            try
                            {
                                int Climb = 0;
                                int.TryParse(speed.Split(':')[1].Replace("ft.", ""), out Climb);
                                ClimbUpDown.Value = Climb;
                            }
                            catch { }
                            break;
                        case "Fly":
                            try
                            {
                                int Fly = 0;
                                if (speed.Split(':')[1].Contains("(Hover)"))
                                {
                                    HoverCheckBox.Checked = true;
                                    int.TryParse(speed.Split(':')[1].Replace("ft.", "").Replace(" (Hover)", ""), out Fly);
                                }
                                else
                                {
                                    int.TryParse(speed.Split(':')[1].Replace("ft.", ""), out Fly);
                                }
                                FlyUpDown.Value = Fly;
                            }
                            catch { }
                            break;
                        case "Swim":
                            try
                            {
                                int Swim = 0;
                                int.TryParse(speed.Split(':')[1].Replace("ft.", ""), out Swim);
                                SwimUpDown.Value = Swim;
                            }
                            catch { }
                            break;
                        default:                            
                            try
                            {
                                int temp = 0;
                                int.TryParse(check.Replace("ft.", ""), out temp);
                                SpeedUpDown.Value = temp;
                            }
                            catch { }                            
                            break;
                    }                    
                }
                
                foreach (Ability item in Monster._Abilities)
                {
                    TraitsList.Items.Add("Ability: " + item.Title);
                }

                foreach (Ability item in Monster._Actions)
                {
                    TraitsList.Items.Add("Action: " + item.Title);
                }

                foreach (Ability reaction in Monster._Reactions)
                {
                    TraitsList.Items.Add("Reaction: " + reaction.Title);
                }

                foreach (Legendary epic in Monster._Legendaries)
                {
                    TraitsList.Items.Add("Legendary: " + epic.Title);
                }
                
                foreach (string language in Monster._Languages)
                {
                    TraitsList.Items.Add("Language: " + language);
                }

                foreach (string senses in Monster._Senses)
                {
                    TraitsList.Items.Add("Sense: " + senses);
                }

                foreach (string CImmunity in Monster.ConditionImmunities)
                {
                    TraitsList.Items.Add("Condition Immunity: " + CImmunity);
                }

                foreach (string DImmunities in Monster.DamageImmunities)
                {
                    TraitsList.Items.Add("Damage Immunity: " + DImmunities);
                }

                foreach (string DResistance in Monster.DamageResistances)
                {
                    TraitsList.Items.Add("Damage Resistance: " + DResistance);
                }

                foreach (string DVulnerability in Monster.DamageVulnerability)
                {
                    TraitsList.Items.Add("Damage Vulnerability: " + DVulnerability);
                }

                foreach (string SavingThrow in Monster.SavingThrowBonuses)
                {
                    string temp = SavingThrow.Split(' ')[0];
                    int tempBonus = 0;
                    int.TryParse(SavingThrow.Split('+')[1], out tempBonus);

                    switch (temp)
                    {
                        case "Str":
                            StrSaveBonusUpDown.Value = tempBonus;
                            break;
                        case "Dex":
                            DexSaveBonusUpDown.Value = tempBonus;
                            break;
                        case "Con":
                            ConSaveBonusUpDown.Value = tempBonus;
                            break;
                        case "Int":
                            IntSaveBonusUpDown.Value = tempBonus;
                            break;
                        case "Wis":
                            WisSaveBonusUpDown.Value = tempBonus;
                            break;
                        case "Cha":
                            ChaSaveBonusUpDown.Value = tempBonus;
                            break;
                    }
                }

                foreach (string SkillBonus in Monster.SkillBonuses)
                {                    
                    TraitsList.Items.Add(SkillBonus);
                }

                HitDieTextBox.Text = Monster.HP;

                try
                {
                    string hpString = Monster.HP.Split('(')[1].Replace(')', ' ').Trim().Split('+')[0];
                    int DiceSize;
                    int DiceNumber;
                    int.TryParse(hpString.Split('d')[0], out DiceNumber);
                    int.TryParse(hpString.Split('d')[1], out DiceSize);

                    HitDieUpDown.Value = DiceNumber;
                    HitDieDropDown.Text = "";
                    HitDieDropDown.SelectedText = "d" + DiceSize;
                }
                catch { }

                try
                {
                    int ACValue = 0;
                    int.TryParse(Monster.AC.Split(' ')[0], out ACValue);

                    ACUpDown.Value = ACValue;
                    string temp = Monster.AC.Split(' ')[1].Trim();
                    ACSourceTextBox.Text = temp.Substring(1, temp.Length - 2);
                }
                catch { }

                MonsterNameTextBox.Text = "";
                SizeDropDown.Text = "";
                TypeDropDown.Text = "";
                TagDropDown.Text = "";

                MonsterNameTextBox.Text = Monster.CreatureName;
                SizeDropDown.SelectedText = Monster.CreatureSize;
                TypeDropDown.SelectedText = Monster.CreatureType.Split(' ')[0];
                try { TagDropDown.SelectedText = Monster.CreatureType.Split(' ')[1].Replace('(', ' ').Replace(')', ' ').Trim(); }
                catch { }
                
                Monster.Clear();
            }
        }        

        // Saves Monster.Output into an HTML file.
        private void ExportHTML(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Help.LastDirectory;
            dialog.Filter = "html files (*.html)|*.html";
            dialog.RestoreDirectory = true;
            
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Help.LastDirectory = dialog.FileName;
                System.IO.File.WriteAllText(dialog.FileName,"");

                foreach (string line in Monster.output){
                    System.IO.File.AppendAllText(dialog.FileName, line + Environment.NewLine);
                }
            }
        }
        
        // Creates an offscreen browser, then saves the paint buffer as PNG.
        private void ExportPNG_Click(object sender, EventArgs e)
        {            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Help.LastDirectory;
            dialog.Filter = "png files (*.png)|*.png";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Help.LastDirectory = dialog.FileName;
                Screenshot(dialog.FileName);
            }            
        }

        // The task that creates the PNG.
        private static async void Screenshot(string filename)
        {
            // Create the offscreen Chromium browser.
            using (var browser = new CefSharp.OffScreen.ChromiumWebBrowser())
            {
                browser.LoadHtml("<html><head></head><body></body></html>", "http://rendering/");
                browser.LoadHtml(Monster.ValloricStatBlock(), "http://rendering/");

                saveFilename = filename;
                
                await Task.Delay(500);

                int width = (Monster.width + (Monster.width * Monster.columns)) + 40;
                int height = 0;

                while (height == 0)
                {
                    height = BrowserInfo.BrowserHeight(browser);
                    System.Threading.Thread.Sleep(100);
                }

                browser.Size = new Size(width, height);
                
                await Task.Delay(500);
                await browser.ScreenshotAsync().ContinueWith(DisplayBitmap);
            }
        }
        
        // The task that saves the PNG
        private static void DisplayBitmap(Task<Bitmap> task)
        {
            var bitmap = task.Result;

            // Save the Bitmap to the path.
            // The image type is auto-detected via the ".png" extension.
            bitmap.Save(saveFilename);

            // We no longer need the Bitmap.
            // Dispose it to avoid keeping the memory alive.  Especially important in 32-bit applications.
            bitmap.Dispose();
        }

        // Convert Monster to CSV, then save the file.
        private void ExportCSV_Click(object sender, EventArgs e)
        {
            StringBuilder CSVOutput = new StringBuilder();
            CSVOutput.Append(Monster.Title + ",");
            CSVOutput.Append(Monster.CreatureName + ",");
            CSVOutput.Append(Monster.CreatureSize + " ");
            CSVOutput.Append(Monster.CreatureType + " ");
            CSVOutput.Append(Monster.CreatureAlign + ",");
            CSVOutput.Append("Armor Class=" + Monster.AC+ ",");
            CSVOutput.Append("HitPoints=" + Monster.HP + ",");
            CSVOutput.Append("Speed=" + Monster.Speed + ",");
            CSVOutput.Append("AbilityScores=[STR:" + Monster.STR + "(" + getStatMod("str") + ")],[DEX:" + Monster.DEX + "(" + getStatMod("dex") + ")],[CON:" + Monster.CON
                + "(" + getStatMod("con") + ")],[INT:" + Monster.INT + "(" + getStatMod("int") + ")],[WIS:" + Monster.WIS + "(" + getStatMod("wis") + ")],[CHA:" + Monster.CHA 
                + "(" + getStatMod("cha") +")],");

            CSVOutput.Append("Saving Throws=");
            foreach (string item in Monster.SavingThrowBonuses)
            {
                CSVOutput.Append("[" + item + "],");
            }

            CSVOutput.Append("Skills=");
            foreach (string item in Monster.SkillBonuses)
            {
                CSVOutput.Append("[" + item + "],");
            }

            CSVOutput.Append("Damage Immunities=");

            foreach (string dimm in Monster.DamageImmunities)
            {
                CSVOutput.Append("[" + dimm + "],");
            }

            CSVOutput.Append("Damage Resistances=");

            foreach (string dimm in Monster.DamageResistances)
            {
                CSVOutput.Append("[" + dimm + "],");
            }

            CSVOutput.Append("Damage Vulnerabilities=");

            foreach (string dimm in Monster.DamageVulnerability)
            {
                CSVOutput.Append("[" + dimm + "],");
            }

            CSVOutput.Append("Condition Immunities=");

            foreach (string dimm in Monster.ConditionImmunities)
            {
                CSVOutput.Append("[" + dimm + "],");
            }

            CSVOutput.Append("Senses=");

            foreach (string sense in Monster._Senses)
            {
                CSVOutput.Append("[" + sense + "],");
            }

            CSVOutput.Append("Languages=");

            foreach (string dimm in Monster._Languages)
            {
                CSVOutput.Append("[" + dimm + "],");
            }

            CSVOutput.Append("Challenge Rating=" + Monster.CR);

            CSVOutput.Append("Abilities=");

            foreach (Ability dimm in Monster._Abilities)
            {
                CSVOutput.Append("[Name=" + dimm .Title + ",Description=" + dimm.Description + "],");
            }

            CSVOutput.Append("Actions=");

            foreach (Ability dimm in Monster._Actions)
            {
                if (!dimm.isDamage)
                {
                    CSVOutput.Append("[Name=" + dimm.Title + ",Description=" + dimm.Description + "],");
                }
            }

            foreach (Ability action in Monster._Actions)
            {
                if (action.isDamage)
                {
                    Attack dimm = action.attack;

                    CSVOutput.Append("[" +
                        "Name=" + action.Title + "," +
                        "Type=" + dimm._Attack + "," +
                        "ToHit=" + dimm.Bonus + "," +
                        "Reach=" + dimm.Reach + "," +
                        "Range={" + dimm.RangeClose + "/" + dimm.RangeFar + "," +
                        "Target=" + dimm.Target + "," +
                        "Hit=[Average=" + dimm.HitAverageDamage + "]" + "[" + dimm.HitDiceNumber + "d" + dimm.HitDiceSize 
                            + "+" + dimm.HitDamageBonus + " " + dimm.HitDamageType + " " + dimm.HitText + "],"
                        + "],");
                }
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Help.LastDirectory;
            dialog.Filter = "csv files (*.csv)|*.csv";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Help.LastDirectory = dialog.FileName;
                string output = CSVOutput.ToString();
                if (output[output.Length - 1].ToString() == ",")
                {
                    output = output.Substring(0, output.Length - 1);
                }
                
                System.IO.File.WriteAllText(dialog.FileName, output);
            }
        }        

        // Opens the print dialog. 
        private void Print_Click(object sender, EventArgs e)
        {
            b.Print();            
        }    

        /// <summary>
        /// Takes a numericUpDown and a Label and derives the ability modifier, updating the label.
        /// </summary>
        /// <param name="value">Input</param>
        /// <param name="target">Output</param>
        private void UpdateModifier(NumericUpDown value, Label target)
        {            
            int modifier = (int)Math.Floor((double)(Convert.ToInt32(value.Value) - 10) / 2);

            if (modifier >= 0)
            {
                target.Text = "+" + modifier;
            }
            else
            {
                target.Text = modifier.ToString();
            }

            if (target.Tag.ToString() == "DEXMOD")
            {
                RecalculateAC("Mod Change");
            }

            try
            {
                for (int i = 0; i < TraitsList.Items.Count; i++)
                {
                    string item = TraitsList.Items[i].ToString();
                    if (!item.Contains("Skill")) return;

                    string mod = target.Tag.ToString().ToLower().Replace("mod", "");
                    mod = mod[0].ToString().ToUpper() + mod.Substring(1, 2);

                    if (item.Split('|')[1].Contains(mod))
                    {
                        string temp = item.Split('|')[1];
                        string skillChanged = item.Split('(')[0];
                        string addendum = "";
                        skillChanged += "(" + mod + ") ";

                        int totalBonus = 0;
                        int modBonus = 0;
                        int profBonus = 0;
                        int skillBonus = 0;

                        if (temp.Contains(mod))
                        {
                            modBonus = modifier;
                            addendum += mod + " " + modBonus + " ";
                        }

                        if (temp.Contains("Prof."))
                        {
                            profBonus = currentCR.profBonus;
                            addendum += "Prof. " + profBonus + " ";
                        }

                        if (temp.Contains("Bonus"))
                        {
                            skillBonus = (int)SkillBonus.Value;
                            addendum += "Bonus " + skillBonus;
                        }

                        totalBonus = modBonus + profBonus + skillBonus;
                        skillChanged += "+" + totalBonus + " | (" + addendum.Trim() + ")";

                        TraitsList.Items.Remove(item);
                        TraitsList.Items.Add(skillChanged);
                    }
                }
            }
            catch { }
        }

        // Gets the Average HP.
        private void generateHP(object sender, EventArgs e)
        {
            ResolveHP(false);
        }

        // Rolls HP.
        private void rollHP(object sender, EventArgs e)
        {
            ResolveHP(true);
        }

        /// <summary>
        /// Either rolls or uses the average for HP. 
        /// </summary>
        /// <param name="RollHP">Do we roll the HP. If not, the average is found.</param>
        private void ResolveHP(bool RollHP)
        {
            int size = Convert.ToInt32(HitDieDropDown.Text.Substring(1, HitDieDropDown.Text.Length - 1));
            double multiplier = (int)HitDieUpDown.Value;
            int conmod = Convert.ToInt32(ConBonus.Text.Replace("+", ""));

            double averageDie = (size / 2) + 0.5;
            int AverageHP = (int)((averageDie * multiplier) + (conmod * multiplier));

            if (RollHP)
            {
                Random r = new Random();
                AverageHP = 0;
                for (int i = 0; i < multiplier; i++)
                {
                    AverageHP += (r.Next(1, size + 1)) + conmod;
                }
            }

            HitDieTextBox.Text = AverageHP + " (" + multiplier + "d" + size + "+" + (conmod * multiplier) + ")";
        }
      
        // Generates the actual monster itself.
        private void GenerateMonsterData()
        {
            Monster.SkillBonuses.Clear();
            Monster.Clear();                
            // Clear existing HTML
            if (Monster.output.Count > 0)
            {
                
            }

            int.TryParse(ProfBonus.Text, out Monster.proficency);

            Monster.CreatureName = MonsterNameTextBox.Text;
            Monster.CreatureSize = SizeDropDown.Text;
            Monster.CreatureAlign = AlignmentDropDown.Text;
            Monster.CreatureType = TypeDropDown.Text;

            if (!String.IsNullOrEmpty(TagDropDown.Text))
            {
                Monster.CreatureType += " (" + TagDropDown.Text + ")";
            }

            Monster.STR = (int)StrUpDown.Value;
            Monster.DEX = (int)DexUpDown.Value;
            Monster.CON = (int)ConUpDown.Value;
            Monster.INT = (int)IntUpDown.Value;
            Monster.WIS = (int)WisUpDown.Value;
            Monster.CHA = (int)ChaUpDown.Value;

            Monster.Speed = SpeedUpDown.Value.ToString() + " ft.";

            if (!SpeedUpDown.Enabled) 
            {
                Monster.Speed += " " + SpeedUpDown.Tag;
            }

            if (burrowUpDown.Value > 0) { Monster.Speed += ", burrow: " + burrowUpDown.Value + " ft."; }
            if (!burrowUpDown.Enabled)
            {
                Monster.Speed += " " + burrowUpDown.Tag;
            }

            if (ClimbUpDown.Value > 0) { Monster.Speed += ", climb: " + ClimbUpDown.Value + " ft."; }
            if (!ClimbUpDown.Enabled)
            {
                Monster.Speed += " " + ClimbUpDown.Tag;
            }

            if (FlyUpDown.Value > 0) { Monster.Speed += ", fly: " + FlyUpDown.Value + " ft."; }
            if (!FlyUpDown.Enabled)
            {
                Monster.Speed += " " + FlyUpDown.Tag;
            }

            if (HoverCheckBox.Checked) { Monster.Speed += " (hover)"; }
            if (!HoverCheckBox.Enabled)
            {
                Monster.Speed += " " + HoverCheckBox.Tag;
            }

            if (SwimUpDown.Value > 0) { Monster.Speed += ", swim: " + SwimUpDown.Value + " ft."; }
            if (!SwimUpDown.Enabled)
            {
                Monster.Speed += " " + SwimUpDown.Tag;
            }

            Monster.AC = ACUpDown.Value + "";
            if (ACSourceTextBox.Text.Length > 0)
            {
                if (ACSourceTextBox.Text.Contains('('))
                {
                    Monster.AC += " " + ACSourceTextBox.Text;
                }
                else
                {
                    Monster.AC += " (" + ACSourceTextBox.Text + ")";
                }
            }

            Monster.HP = HitDieTextBox.Text;
            Monster.CR = currentCR;
            
            foreach (string item in TraitsList.Items)
            {
                switch (item.Split(':')[0])
                {
                    case "Skill":                        
                        Monster.AddSkillBonus(item);
                        break;
                    case "Damage Vulnerability":
                        Monster.AddDamageVulnerabilities(item.Split(':')[1].Trim());
                        break;
                    case "Damage Resistance":
                        Monster.AddDamageResistance(item.Split(':')[1].Trim());
                        break;
                    case "Damage Immunity":
                        Monster.AddDamageImmunity(item.Split(':')[1].Trim());
                        break;
                    case "Condition Immunity":
                        Monster.AddConditionImmunity(item.Split(':')[1].Trim());
                        break;
                    case "Language":
                        Monster._Languages.Add(item.Split(':')[1].Trim());
                        break;
                    case "Sense":
                        Monster._Senses.Add(item.Split(':')[1].Trim());
                        break;
                }
            }
            
            if (StrSaveBonusUpDown.Value > 0)
            {
                Monster.AddSavingThrow("Str +" + StrSaveBonusUpDown.Value);
            }
            if (DexSaveBonusUpDown.Value > 0)
            {
                Monster.AddSavingThrow("Dex +" + DexSaveBonusUpDown.Value);
            }
            if (ConSaveBonusUpDown.Value > 0)
            {
                Monster.AddSavingThrow("Con +" + ConSaveBonusUpDown.Value);
            }
            if (IntSaveBonusUpDown.Value > 0)
            {
                Monster.AddSavingThrow("Int +" + IntSaveBonusUpDown.Value);
            }
            if (WisSaveBonusUpDown.Value > 0)
            {
                Monster.AddSavingThrow("Wis +" + WisSaveBonusUpDown.Value);
            }
            if (ChaSaveBonusUpDown.Value > 0)
            {
                Monster.AddSavingThrow("Cha +" + ChaSaveBonusUpDown.Value);
            }            
        }
        
        // Clears the monster data.
        public void Clear()
        {
            b.LoadHtml("<html><head></head><body></body></html", "http://rendering/");
        }

        // Monster has been generated, send to browser.
        public void ShowMonster()
        {
            this.Text = Monster.CreatureName.Replace('*', ' ').Trim();
            Clear();
            if (b.IsLoading)
            {
                b.Stop();
                while (b.IsLoading)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }

            if (PreviewTemplateSelector.Text == "Valloric's Statblock")
            {
                b.LoadHtml(Monster.ValloricStatBlock(), "http://rendering/");
            }
        }

        // Recalculate AC based on CR/Dex.
        private void RecalculateAC(string source)
        {
            int mods = getStatMod("dex") + currentCR.ArmorClass;
            ACUpDown.Value = mods;
        }

        // Gets the modifier of a specific statistic.
        private int getStatMod(string mod)
        {
            int returnStatMod = 0;

            switch (mod.ToLower())
            {
                case "str":
                    int.TryParse(StrBonus.Text, out returnStatMod);
                    break;
                case "dex":
                    int.TryParse(DexBonus.Text, out returnStatMod);
                    break;
                case "con":
                    int.TryParse(ConBonus.Text, out returnStatMod);
                    break;
                case "int":
                    int.TryParse(IntBonus.Text, out returnStatMod);
                    break;
                case "wis":
                    int.TryParse(WisBonus.Text, out returnStatMod);
                    break;
                case "cha":
                    int.TryParse(ChaBonus.Text, out returnStatMod);
                    break;
            }

            return returnStatMod;
        }

        // Does nothing.
        private void GuessCR_Click(object sender, EventArgs e)
        {
            
        }

        // Sets the tooltip based on trait when hovering over the traits list.
        private void TraitsList_MouseHover(object sender, EventArgs e)
        {            
            try
            {
                TraitsList.SelectedIndex = TraitsList.IndexFromPoint(TraitsList.PointToClient(Cursor.Position));
                TraitsListPopUp.SetToolTip(TraitsList, TraitsList.SelectedItem.ToString());
            }
            catch { TraitsListPopUp.SetToolTip(TraitsList, ""); }
        }

        // Clears all data, starts a new monster.
        private void NewMonsterButton_Click(object sender, EventArgs e)
        {
            Monster.Clear(true);
            ClearUI();
        }

        // Clears the UI. Will not clear monster data.
        private void ClearUI()
        {
            StrUpDown.Value = 10;
            DexUpDown.Value = 10;
            ConUpDown.Value = 10;
            IntUpDown.Value = 10;
            WisUpDown.Value = 10;
            ChaUpDown.Value = 10;

            TraitsList.Items.Clear();

            StrSaveBonusUpDown.Value = 0;
            DexSaveBonusUpDown.Value = 0;
            ConSaveBonusUpDown.Value = 0;
            WisSaveBonusUpDown.Value = 0;
            IntSaveBonusUpDown.Value = 0;
            ChaSaveBonusUpDown.Value = 0;

            MonsterNameTextBox.Text = "";
            SizeDropDown.SelectedIndex = 0;
            TypeDropDown.Text = "";
            TagDropDown.Text = "";
            AlignmentDropDown.Text = "";
            AlignmentDropDown.SelectedText = "Unaligned";
            ACUpDown.Value = 10;
            ACSourceTextBox.Text = "";

            HitDieUpDown.Value = 1;
            HitDieDropDown.SelectedIndex = 0;
            HitDieTextBox.Text = "";

            SpeedUpDown.Value = 30;
            SwimUpDown.Value = 0;
            FlyUpDown.Value = 0;
            ClimbUpDown.Value = 0;
            burrowUpDown.Value = 0;
            HoverCheckBox.Checked = false;

            DamageConditionDropDown.Text = "";
            SensesDropDown.Text = "";
            DistanceUpDown.Value = 50;
            LanguageComboBox.Text = "";

            SkillBonusCheckBox.Checked = true;
            SkillProfCheckBox.Checked = true;
            SkillStatCheckBox.Checked = true;
            SkillDropDown.SelectedIndex = 0;

            ChallengeRatingDropDown.SelectedIndex = 0;
        }

        // Sets the tooltip based on CR when hovering over the traits list.
        private void ChallengeRatingDropDown_MouseHover(object sender, EventArgs e)
        {
            string output = "CR: " + currentCR.CR + Environment.NewLine;
            output += "AC: " + currentCR.ArmorClass + Environment.NewLine;
            output += "Attack Bonus: " + currentCR.AttackBonus + Environment.NewLine;
            output += "Save DC: " + currentCR.profBonus + Environment.NewLine;
            output += "Low HP: " + currentCR.LowHP + "  High HP: " + currentCR.HighHP + Environment.NewLine;
            TraitsListPopUp.SetToolTip(ChallengeRatingDropDown, output);
        }
      
        // Sort the four lists.
        private void SortTraits()
        {
            List<Ability> _Abilities = new List<Ability>();
            List<Ability> _Actions = new List<Ability>();
            List<Ability> _Reactions = new List<Ability>();
            List<Legendary> _Legendaries = new List<Legendary>();

            foreach (string item in TraitsList.Items)
            {
                if (item.Contains("Ability"))
                {
                    foreach (Ability ability in Monster._Abilities)
                    {
                        if (item.Contains(ability.Title))
                        {                            
                            _Abilities.Add(ability);                            
                        }
                    }
                }
            }

            Monster._Abilities = _Abilities;

            foreach (string item in TraitsList.Items)
            {
                if (item.Contains("Action"))
                {
                    foreach (Ability action in Monster._Actions)
                    {
                        if (item.Contains(action.Title))
                        {
                            _Actions.Add(action);
                        }
                    }
                }
            }

            Monster._Actions = _Actions;

            foreach (string item in TraitsList.Items)
            {
                if (item.Contains("Reaction"))
                {
                    foreach (Ability reaction in Monster._Reactions)
                    {
                        if (item.Contains(reaction.Title))
                        {
                            _Reactions.Add(reaction);
                        }
                    }
                }
            }

            Monster._Reactions = _Reactions;

            foreach (string item in TraitsList.Items)
            {
                if (item.Contains("Legendary"))
                {
                    foreach (Legendary epic in Monster._Legendaries)
                    {
                        if (item.Contains(epic.Title))
                        {
                            _Legendaries.Add(epic);
                        }
                    }
                }
            }

            Monster._Legendaries = _Legendaries;
        }


        // Use arrow keys to sort the traits list.
        private void TraitsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MoveItem(-1, TraitsList);
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveItem(1, TraitsList);
            }

            e.SuppressKeyPress = true;
        }

        private void MoveItem(int direction, ListBox target)
        {
            // Remove alphabetizing.
            if (target.Sorted) { target.Sorted = false; }

            // Checking selected item
            if (target.SelectedItem == null || target.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = target.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= target.Items.Count)
                return; // Index out of range - nothing to do

            object selected = target.SelectedItem;

            // Removing removable element
            target.Items.Remove(selected);
            // Insert it in new position
            target.Items.Insert(newIndex, selected);
            // Restore selection
            target.SetSelected(newIndex, true);
        }

        // Pop up text changes to traitslist help.
        private void TraitsListHoverHelp(object sender, EventArgs e)
        {
            TraitsListPopUp.SetToolTip(label1, "Right Click to Remove Items" + Environment.NewLine +
                                               "Double Click to Edit Items" + Environment.NewLine +
                                               "Hover to Select and Inspect Items" + Environment.NewLine +
                                               "Use Up/Down Keys to Sort");
        }

        // Allows for customized speeds
        private void CustomizeSpeed(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            NumericUpDown target = null;
            bool isFly = false;

            switch (temp.Tag.ToString())
            {
                case "Speed":
                    target = (NumericUpDown)SpeedUpDown;
                    break;
                case "Swim":
                    target = (NumericUpDown)SwimUpDown;
                    break;
                case "Fly":
                    target = (NumericUpDown)FlyUpDown;
                    isFly = true;
                    break;
                case "Burrow":
                    target = (NumericUpDown)burrowUpDown;
                    break;
                case "Climb":
                    target = (NumericUpDown)ClimbUpDown;
                    break;
            }

            target.Enabled = !target.Enabled;
            if (target.Enabled)
            {
                target.Tag = null;
                TraitsListPopUp.SetToolTip(this, "");
            }
            else
            {
                CustomSpeed speedPrompt = new CustomSpeed();
                speedPrompt.SpeedUpDown.Value = target.Value;
                if (isFly)
                {
                    speedPrompt.HoverCheckBox.Enabled = true;
                    speedPrompt.HoverCheckBox.Checked = HoverCheckBox.Checked;
                }
                speedPrompt.Show();

                speedPrompt.FormClosed += (senders, es) =>
                {
                    if (String.IsNullOrWhiteSpace(speedPrompt.SpeedDescription.Text) || String.IsNullOrEmpty(speedPrompt.SpeedDescription.Text))
                    {
                        target.Enabled = true;
                        target.Tag = null;
                        TraitsListPopUp.SetToolTip(this, "");
                    }
                    else
                    {
                        target.Value = speedPrompt.SpeedUpDown.Value;
                        target.Tag = speedPrompt.SpeedDescription.Text;
                        if (isFly)
                        {
                            HoverCheckBox.Checked = speedPrompt.HoverCheckBox.Checked;
                        }
                    }
                };
            }
        }

        // Sets tooltip for speed hovers.
        private void Speed_MouseHover(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            NumericUpDown target = null;
            
            switch (temp.Tag.ToString())
            {
                case "Speed":
                    target = (NumericUpDown)SpeedUpDown;
                    break;
                case "Swim":
                    target = (NumericUpDown)SwimUpDown;
                    break;
                case "Fly":
                    target = (NumericUpDown)FlyUpDown;
                    break;
                case "Burrow":
                    target = (NumericUpDown)burrowUpDown;
                    break;
                case "Climb":
                    target = (NumericUpDown)ClimbUpDown;
                    break;
            }

            if (target.Tag != null)
            {
                if (!String.IsNullOrWhiteSpace(target.Tag.ToString()) && !String.IsNullOrEmpty(target.Tag.ToString()))
                {                    
                    TraitsListPopUp.SetToolTip(temp, target.Tag.ToString());
                }
            }
            else
            {                
                TraitsListPopUp.SetToolTip(temp, "Click To Customize " + temp.Tag);
            }
        }

        private void MonsterName_MouseHover(object sender, EventArgs e)
        {
            TraitsListPopUp.SetToolTip(MonsterName, "If you use a * in the monster name, it becomes a proper name.");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoveTraitUpButton_Click(object sender, EventArgs e)
        {
            MoveItem(-1, TraitsList);
        }

        private void MoveTraitDownButton_Click(object sender, EventArgs e)
        {
            MoveItem(1, TraitsList);
        }
    }
}
