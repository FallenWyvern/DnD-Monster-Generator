// This class is for storing monster data.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{    
    // To read this, the Monster class has a few important methods.
    // First, Create() fills the list output with all the strings needed
    // to apply the template.
    // Clear() removes all data from all variables, effectively resetting the monster.
    // Input() and Output() either copies all data to or from this static class to a Data instance.

    public static partial class Monster
    {
        // The width of the document is 212 + (212 * columns).
        public static int columns = 0;
        public static int width = 260;

        // Methods for building monster.
        #region
        
        public static void AddAbility(Ability target)
        {
            _Abilities.Add(target);
        }        

        public static void AddAction(Ability target)
        {
            _Actions.Add(target);
        }

        public static void AddReaction(Ability target)
        {
            _Reactions.Add(target);
        }

        public static void AddLegendary(Legendary target)
        {
            _Legendaries.Add(target);
        }

        private static string D_Immunities()
        {
            string immunities = "";
            foreach (string item in DamageImmunities)
            {
                immunities += item.ToLower() + ", ";
            }
            if (immunities.Length > 2)
            {
                immunities = immunities.Substring(0, immunities.Length - 2);
            }
            return immunities;
        }

        public static void AddDamageImmunity(string immunity)
        {
            DamageImmunities.Add(immunity);
        }

        private static string D_Resistances()
        {
            string resistance = "";
            foreach (string item in DamageResistances)
            {
                resistance += item.ToLower() + ", ";
            }
            if (resistance.Length > 2)
            {
                resistance = resistance.Substring(0, resistance.Length - 2);
            }
            return resistance;
        }

        public static void AddDamageResistance(string resistance)
        {
            
            DamageResistances.Add(resistance);
        }

        private static string D_Vulnerabilities()
        {
            string vulnerability = "";
            foreach (string item in DamageVulnerability)
            {
                vulnerability += item.ToLower() + ", ";
            }
            if (vulnerability.Length > 2)
            {
                vulnerability = vulnerability.Substring(0, vulnerability.Length - 2);
            }
            return vulnerability;
        }

        public static void AddDamageVulnerabilities(string vulnerability)
        {
            DamageVulnerability.Add(vulnerability);
        }

        private static string C_Immunities()
        {
            string immunities = "";
            foreach (string item in ConditionImmunities)
            {
                immunities += item.ToLower() + ", ";
            }
            if (immunities.Length > 2)
            {
                immunities = immunities.Substring(0, immunities.Length - 2);
            }
            return immunities;
        }

        public static void AddConditionImmunity(string immunity)
        {            
            ConditionImmunities.Add(immunity);            
        }

        private static string SavingThrows()
        {
            string savingThrows = "";
            foreach (string item in SavingThrowBonuses)
            {
                savingThrows += item + ", ";
            }
            if (savingThrows.Length > 2)
            {
                savingThrows = savingThrows.Substring(0, savingThrows.Length - 2);
            }
            return savingThrows;
        }

        public static void AddSavingThrow(string savingThrow)
        {
            SavingThrowBonuses.Add(savingThrow);
        }

        private static string Skills()
        {
            string skills = "";
            foreach (string item in SkillBonuses)
            {
                skills += item.Split(':')[1].Split('|')[0].Replace("(Str)", "").Replace("(Dex)", "").Replace("(Con)", "")
                    .Replace("(Int)", "").Replace("(Wis)", "").Replace("(Cha)", "").Trim() + ", ";
            }
            if (skills.Length > 2)
            {
                skills = skills.Substring(0, skills.Length - 2);
            }
            return skills;
        }

        public static void AddSkillBonus(string skill)
        {            
            SkillBonuses.Add(skill);
        }

        private static string Senses()
        {            
            string senses = "";
            foreach (string item in _Senses)
            {
                string temp = item;
                
                if (temp.ToLower().Contains("passive"))
                {                    
                    if (temp.Split(' ').Length <= 2)
                    {
                        int modifier = (int)Math.Floor((double)(WIS - 10) / 2);
                        string bonus = " " + (10 + (modifier + proficency)) + " ";
                        temp = "passive Perception" + bonus;
                    }
                    else
                    {
                        temp = temp.Replace("Passive", "passive");
                    }
                }
                
                if (temp.ToLower().Contains("passive"))
                {                    
                    senses += temp.Trim() + ", ";
                }
                else
                {                    
                    senses += temp.ToLower() + "., ";
                }
            }
            if (senses.Length > 2)
            {
                senses = senses.Substring(0, senses.Length - 2);
            }

            if (!senses.Contains("passive")) 
            {
                senses += " passive Perception " + (10 + Convert.ToInt32(StatMod(WIS)));
            }

            return senses;
        }

        public static void AddSense(string sense)
        {
            _Senses.Add(sense);
        }

        private static string Languages()
        {
            if (_Languages.Count > 0)
            {
                string languages = "";
                foreach (string item in _Languages)
                {
                    languages += item + ", ";
                }
                if (languages.Length > 2)
                {
                    languages = languages.Substring(0, languages.Length - 2);
                }
                return languages;
            }
            else
            {
                return "-";
            }
        }

        public static void AddLanguage(string language)
        {
            _Languages.Add(language);
        }
        #endregion

        // Methods for altering data structure.
        #region
        public static void Clear(bool isNew = false)
        {
            Title = "";

            STR = 0;
            DEX = 0;
            CON = 0;
            INT = 0;
            WIS = 0;
            CHA = 0;

            Speed = "";
            AC = "";
            HP = "";
            CR = Help.ChallengeRatings[0];

            CreatureAlign = "";
            CreatureName = "";
            CreatureSize = "";
            CreatureType = "";

            output.Clear();
            output = new List<string>();

            DamageImmunities.Clear();
            DamageResistances.Clear();
            DamageVulnerability.Clear();
            ConditionImmunities.Clear();
            SavingThrowBonuses.Clear();
            SkillBonuses.Clear();            

            if (isNew)
            {
                _Abilities.Clear();
                _Actions.Clear();
                _Legendaries.Clear();
                _Reactions.Clear();
            }

            _Languages.Clear();
            _Senses.Clear();
        }

        // Saves the monster data to the data model.
        public static void Output(Data fillTarget)
        {
            fillTarget._Abilities = _Abilities;
            fillTarget._Actions = _Actions;
            fillTarget._Legendaries = _Legendaries;
            fillTarget._Reactions = _Reactions;
            fillTarget._Languages = _Languages;
            fillTarget._Senses = _Senses;
            fillTarget.AC = AC;
            fillTarget.CHA = CHA;
            fillTarget.CON = CON;
            fillTarget.ConditionImmunities = ConditionImmunities;
            fillTarget.CR = CR;
            fillTarget.CreatureAlign = CreatureAlign;
            fillTarget.CreatureName = CreatureName;
            fillTarget.CreatureSize = CreatureSize;
            fillTarget.CreatureType = CreatureType;
            fillTarget.DamageImmunities = DamageImmunities;
            fillTarget.DamageResistances = DamageResistances;
            fillTarget.DamageVulnerability = DamageVulnerability;
            fillTarget.DEX = DEX;
            fillTarget.HP = HP;
            fillTarget.INT = INT;
            //fillTarget.output = output;
            fillTarget.proficency = proficency;
            fillTarget.SavingThrowBonuses = SavingThrowBonuses;
            fillTarget.SkillBonuses = SkillBonuses;
            fillTarget.Speed = Speed;
            fillTarget.STR = STR;
            fillTarget.Title = Title;
            fillTarget.WIS = WIS;
        }

        // Loads the monster data from data model.
        public static void Input(Data source)
        {
            Monster.Clear(true);
            _Abilities = source._Abilities;
            _Actions = source._Actions;
            _Legendaries = source._Legendaries;
            _Reactions = source._Reactions;
            _Languages = source._Languages;
            _Senses = source._Senses;
            AC = source.AC;
            CHA = source.CHA;
            CON = source.CON;
            ConditionImmunities = source.ConditionImmunities;
            CR = source.CR;
            CreatureAlign = source.CreatureAlign;
            CreatureName = source.CreatureName;
            CreatureSize = source.CreatureSize;
            CreatureType = source.CreatureType;
            DamageImmunities = source.DamageImmunities;
            DamageResistances = source.DamageResistances;
            DamageVulnerability = source.DamageVulnerability;
            DEX = source.DEX;
            HP = source.HP;
            INT = source.INT;
            //fillTarget.output = output;
            proficency = source.proficency;
            SavingThrowBonuses = source.SavingThrowBonuses;
            SkillBonuses = source.SkillBonuses;
            Speed = source.Speed;
            STR = source.STR;
            Title = source.Title;
            WIS = source.WIS;
        }
        #endregion

        // Variables
        #region
        public static List<string> output = new List<string>();

        public static List<string> DamageImmunities = new List<string>();        
        public static List<string> ConditionImmunities = new List<string>();
        public static List<string> DamageResistances = new List<string>();
        public static List<string> DamageVulnerability = new List<string>();
        public static List<string> SavingThrowBonuses = new List<string>();
        public static List<string> SkillBonuses = new List<string>();

        public static List<string> _Senses = new List<string>();
        public static List<string> _Languages = new List<string>();

        public static List<Ability> _Abilities = new List<Ability>();
        public static List<Ability> _Actions = new List<Ability>();
        public static List<Ability> _Reactions = new List<Ability>();
        public static List<Legendary> _Legendaries = new List<Legendary>();        

        public static string Title = "";        
        public static int STR = 0;
        public static int DEX = 0;
        public static int CON = 0;
        public static int INT = 0;
        public static int WIS = 0;
        public static int CHA = 0;
        public static int proficency = 0;

        public static string Speed = "";

        public static string AC = "";
        public static string HP = "";
        public static Challenge_Rating CR = Help.ChallengeRatings[0];

        public static string CreatureName = "";
        public static string CreatureSize = "";
        public static string CreatureType = "";
        public static string CreatureAlign = "";
        
        #endregion

        // Shared template methods.
        #region
        // Since the scripts in the original template were so
        // similar, I just wrote this to re-write them over and over.
        // Saves typing.
        private static void AddTemplateScript(string identifier)
        {
            output.Add(@"<script>");
            output.Add(@"(function(window, document) {");
            output.Add(@"var elemName = '" + identifier + "';");
            output.Add(@"var thatDoc = document;");
            output.Add(@"var thisDoc = (thatDoc.currentScript || thatDoc._currentScript).ownerDocument;");
            output.Add(@"var proto = Object.create(HTMLElement.prototype, {");
            output.Add(@"createdCallback: {");
            output.Add(@"value: function() {");
            output.Add(@"var template = thisDoc.getElementById(elemName);");

            if (identifier == "stat-block")
            {
                output.Add(@"if (this.hasAttribute('data-content-height')){");
                output.Add(@"var wrap = template.content.getElementById('content-wrap');");
                output.Add(@"wrap.style.height = this.getAttribute('data-content-height') + 'px';");
                output.Add(@"}");
            }

            output.Add(@"var clone = thatDoc.importNode(template.content, true);");
            output.Add(@"this.createShadowRoot().appendChild(clone);");
            output.Add(@"}");
            output.Add(@"}");
            output.Add(@"});");
            output.Add(@"thatDoc.registerElement(elemName, {prototype: proto});");
            output.Add(@"})(window, document);");
            output.Add(@"</script>");
        }

        // Tapered Rule
        private static void TaperedRule()
        {
            output.Add(@"<tapered-rule></tapered-rule>");
        }
        #endregion
    }
}
