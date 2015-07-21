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
    // All UI elements and events are up here.
    public partial class Main : Form
    {        
        ChromiumWebBrowser b = new ChromiumWebBrowser("http://rendering/");
        Challenge_Rating currentCR = new Challenge_Rating();

        // Init Cef, load the control into the tableLayoutPanel and set the closing
        // event to stop Cef.
        public Main()
        {
            InitializeComponent();
            Cef.Initialize(new CefSettings
            {
                PackLoadingDisabled = true
            });

            b.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(b, 0, 0);
            
            this.FormClosing += (sender, e) => { Cef.Shutdown(); };
        }

        // Set all drop downs and updowns to their starting values and set events.
        private void Form1_Load(object sender, EventArgs e)
        {
            currentCR = Help.ChallengeRatings[0];
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

            StrSaveBonusUpDown.ValueChanged += savingThrowModify;
            DexSaveBonusUpDown.ValueChanged += savingThrowModify;
            ConSaveBonusUpDown.ValueChanged += savingThrowModify;
            IntSaveBonusUpDown.ValueChanged += savingThrowModify;
            WisSaveBonusUpDown.ValueChanged += savingThrowModify;
            ChaSaveBonusUpDown.ValueChanged += savingThrowModify;

            AddVulnerabilityButton.Click += addCondition;
            AddResistanceButton.Click += addCondition;
            AddImmunityButton.Click += addCondition;
        }       

        // This updates the labels next to stats, when the stats change.
        // This uses tags on the controls to match the numericUpDown to the Label.
        private void modchanged_ValueChanged(object sender, EventArgs e)
        {
            var temp = (NumericUpDown)sender;
            foreach (Control item in this.Controls)
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
                    RecalculateAC("CR Updated");
                }
            }
        }

        private void savingThrowModify(object sender, EventArgs e)
        {

        }
        
        private void addSense(object sender, EventArgs e)
        {
            string addString = "Sense: " + SensesDropDown.Text;
            
            if (SensesDropDown.Text != "Passive Perception")
            {
                addString += " " + DistanceUpDown.Value + " ft";
            }

            TraitsList.Items.Add(addString);
        }

        private void addLanguage(object sender, EventArgs e)
        {
            TraitsList.Items.Add("Language: " + LanguageTextBox.Text);
        }

        private void addSkill(object sender, EventArgs e)
        {
            Button temp = (Button)sender;            
            string skillToAdd = "";
            int bonus = 0;
            skillToAdd = SkillDropDown.Text + " ";

            switch (SkillDropDown.Text.Split('(')[1].Replace(")", ""))
            {
                case "Str":
                    int.TryParse(StrBonus.Text, out bonus);
                    break;
                case "Dex":
                    int.TryParse(DexBonus.Text, out bonus);
                    break;
                case "Con":
                    int.TryParse(ConBonus.Text, out bonus);
                    break;
                case "Int":
                    int.TryParse(IntBonus.Text, out bonus);
                    break;
                case "Wis":
                    int.TryParse(WisBonus.Text, out bonus);
                    break;
                case "Cha":
                    int.TryParse(ChaBonus.Text, out bonus);
                    break;
            }
            
            if (temp.Tag.ToString() == "Skill")
            {
                if (bonus > 0)
                {
                    skillToAdd += " +";
                }
                skillToAdd = "Skill: " + (skillToAdd + bonus);
            }
            if (temp.Tag.ToString() == "Skill+")
            {                
                bonus += (int)SkillBonus.Value;
                if (bonus > 0)
                {
                    skillToAdd += " +";
                }
                skillToAdd = "Skill+: " + (skillToAdd + bonus);
            }

            if (!ShowStatInSkill.Checked)
            {
                skillToAdd = skillToAdd.Replace("(Str)", "").Replace("(Dex)", "").Replace("(Con)", "").Replace("(Int)", "").Replace("(Wis)", "").Replace("(Cha)", "");
            }

            if (bonus != 0)
            {
                TraitsList.Items.Add(skillToAdd);
            }
        }
        
        private void addAbility(object sender, EventArgs e)
        {
            AddAbilityForm addAbility = new AddAbilityForm();
            addAbility.Show();

            addAbility.FormClosing += (senders, es) =>
            {
                if (addAbility.NewAbility != null)
                {
                    Monster._Abilities.Add(addAbility.NewAbility);
                    TraitsList.Items.Add("Ability: " + addAbility.NewAbility.Title);
                }
            };
        }

        private void addAttack(object sender, EventArgs e)
        {
            AddAttackForm addAttack = new AddAttackForm(ChallengeRatingDropDown.Text);
            addAttack.Show();

            addAttack.FormClosing += (senders, es) =>
            {
                if (addAttack.NewAttack != null)
                {
                    Monster._Attacks.Add(addAttack.NewAttack);
                    TraitsList.Items.Add("Attack: " + addAttack.NewAttack.Title);                    
                }

                if (addAttack.NewAbility != null)
                {
                    Monster._Attacks.Add(addAttack.NewAbility);
                    TraitsList.Items.Add("Attack: " + addAttack.NewAbility.Title);                        
                }
            };
        }

        private void addCondition(object sender, EventArgs e)
        {
            var temp = (Button)sender;
            string tag = temp.Tag.ToString().ToLower();
            string addString = "";

            if (DamageConditionDropDown.SelectedIndex > 13 && tag != "addi")
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
                case "addi":
                    // Immunity
                    addString += " Immunity: ";
                    break;
                case "addr":
                    // Resistance
                    addString += " Resistance: ";
                    break;
                case "addv":
                    // Vulnerability
                    addString += " Vulnerability: ";
                    break;
            }

            addString += DamageConditionDropDown.Text;
            TraitsList.Items.Add(addString);
        }

        private void editTrait(object sender, MouseEventArgs e)
        {            
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (TraitsList.SelectedItem == null) return;
                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Attack")
                {
                    AddAttackForm loadAttack = new AddAttackForm();

                    foreach (Ability attack in Monster._Attacks)
                    {
                        if (attack.isDamage)
                        {
                            if (attack.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                            {
                                loadAttack.LoadAttack((Attack)attack);                                
                                loadAttack.Show();

                                loadAttack.FormClosing += (senderx, ex) =>
                                {
                                    Monster._Attacks.Remove(attack);
                                    Monster._Attacks.Add(loadAttack.NewAttack);
                                    TraitsList.Items.Remove(TraitsList.SelectedItem);
                                    TraitsList.Items.Add("Attack: " + loadAttack.NewAttack.Title);
                                };
                                return;
                            }
                        }

                        if (!attack.isDamage)
                        {
                            if (attack.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                            {
                                loadAttack.LoadAttack((Ability)attack);
                                loadAttack.Show();

                                loadAttack.FormClosing += (senderx, ex) =>
                                {
                                    Monster._Attacks.Remove(attack);
                                    Monster._Attacks.Add(loadAttack.NewAttack);
                                    TraitsList.Items.Remove(TraitsList.SelectedItem);
                                    TraitsList.Items.Add("Attack: " + loadAttack.NewAbility.Title);
                                };
                                return;
                            }
                        }
                    }
                }
                
                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Ability")
                {                    
                    AddAbilityForm loadAttack = new AddAbilityForm();

                    foreach (Ability ability in Monster._Abilities)
                    {
                        if (ability.Title == TraitsList.SelectedItem.ToString().Split(':')[1].Trim())
                        {
                            loadAttack.LoadAbility(ability);
                            loadAttack.Show();

                            loadAttack.FormClosing += (senderx, ex) =>
                            {
                                Monster._Abilities.Remove(ability);
                                Monster._Abilities.Add(loadAttack.NewAbility);
                                TraitsList.Items.Remove(TraitsList.SelectedItem);
                                TraitsList.Items.Add("Ability: " + loadAttack.NewAbility.Title);
                            };
                            return;
                        }
                    }
                }
            }
        }                

        private void deleteTrait(object sender, MouseEventArgs e)
        {            
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Ability")
                {
                    MessageBox.Show("Ability!");
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
                else if (TraitsList.SelectedItem.ToString().Split(':')[0].Trim() == "Attack")
                {                    
                    Ability temp = null;

                    foreach (Ability item in Monster._Attacks)
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
                else
                {
                    TraitsList.Items.Remove(TraitsList.SelectedItem);
                }                
            }            
        }

        private void Preview(object sender, EventArgs e)
        {
            GenerateMonsterData();
        }

        private void SaveData(object sender, EventArgs e)
        {            
            Data jsonMonster = new Data();
            GenerateMonsterData();
            Monster.Output(jsonMonster);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "mm files (*.mm)|*.mm";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(dialog.FileName, JsonConvert.SerializeObject(jsonMonster));
            }
        }

        private void LoadData(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "mm files (*.mm)|*.mm";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Data jsonMonster = new Data();
                jsonMonster = JsonConvert.DeserializeObject<Data>(System.IO.File.ReadAllText(dialog.FileName));
                TraitsList.Items.Clear();
                Monster.Input(jsonMonster);

                foreach (Ability item in Monster._Abilities)
                {
                    TraitsList.Items.Add("Ability: " + item.Title);
                }

                foreach (Attack item in Monster._Attacks)
                {
                    TraitsList.Items.Add("Attack: " + item.Title);
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

            }
        }        

        private void ExportHTML(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "html files (*.html)|*.html";
            dialog.RestoreDirectory = true;
            
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(dialog.FileName,"");

                foreach (string line in Monster.output){
                    System.IO.File.AppendAllText(dialog.FileName, line);
                }
            }
        }

        private void ExportPNG_Click(object sender, EventArgs e)
        {            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "png files (*.png)|*.png";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ControlSnapshot.Snapshot(b, BrowserWidth(b), BrowserHeight(b)).Save(dialog.FileName);                
            }
        }                
    }

    // For ease of reading, all methods not tied to UI elements are down here.
    public partial class Main : Form
    {
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
        }

        private void generateHP(object sender, EventArgs e)
        {
            ResolveHP(false);
        }

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

            HitDieTextBox.Text = AverageHP + " (" + multiplier + "d" + size + "+" + (size * conmod) + ")";
        }
      
        // Generates the actual monster itself.
        private void GenerateMonsterData()
        {
            int estimatedCR = 0;

            // Clear existing HTML
            if (Monster.output.Count > 0)
            {
                Monster.Clear();
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

            Monster.Speed = SpeedUpDown.Value.ToString();
            if (burrowUpDown.Value > 0) { Monster.Speed += ", Burrow: " + burrowUpDown.Value; }
            if (ClimbUpDown.Value > 0) { Monster.Speed += ", Climb: " + ClimbUpDown.Value; }
            if (FlyUpDown.Value > 0) { Monster.Speed += ", Fly: " + FlyUpDown.Value; }
            if (HoverCheckBox.Checked) { Monster.Speed += " (Hover)"; }
            if (SwimUpDown.Value > 0) { Monster.Speed += ", Swim: " + SwimUpDown.Value; }

            Monster.AC = ACUpDown.Value + " " + ACSourceTextBox.Text;
            Monster.HP = HitDieTextBox.Text;
            Monster.CR = ChallengeRatingDropDown.Text;

            foreach (string item in TraitsList.Items)
            {
                switch (item.Split(':')[0])
                {
                    case "Skill":
                        Monster.AddSkillBonus(item);
                        break;
                    case "Skill+":
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

            ShowMonster();
        }

        public void Clear()
        {
            b.LoadHtml("<html><head></head><body></body></html", "http://rendering/");
        }

        private static int BrowserHeight(ChromiumWebBrowser b)
        {
            // Get Document Height
            var task = b.EvaluateScriptAsync("(function() { var body = document.body, html = document.documentElement; return  Math.max( body.scrollHeight, body.offsetHeight, html.clientHeight, html.scrollHeight, html.offsetHeight ); })();");

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    var EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
                    //MessageBox.Show(response.Result.ToString());                    
                    //MessageBox.Show(EvaluateJavaScriptResult.ToString());                    
                }
            });

            return Convert.ToInt32(task.Result.Result.ToString());
        }

        private static int BrowserWidth(ChromiumWebBrowser b)
        {
            // Get Document Height
            var task = b.EvaluateScriptAsync("(function() { var body = document.body, html = document.documentElement; return  Math.max( body.scrollWidth, body.offsetWidth, html.clientWidth, html.scrollWidth, html.offsetWidth ); })();");

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    var EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
                    //MessageBox.Show(response.Result.ToString());                    
                    //MessageBox.Show(EvaluateJavaScriptResult.ToString());
                }
            });

            return Convert.ToInt32(task.Result.Result.ToString());
        }

        public void ShowMonster()
        {
            this.Text = Monster.CreatureName;
            Clear();
            if (b.IsLoading)
            {
                b.Stop();
                while (b.IsLoading)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
            b.LoadHtml(Monster.Create(), "http://rendering/");
        }

        private void RecalculateAC(string source)
        {
            int mods = getStatMod("dex") + currentCR.ArmorClass;
            ACUpDown.Value = mods;            
        }

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
    }
}
