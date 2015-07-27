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
        // Methods for building monster.
        #region

        public static void AddAbility(string title, string description)
        {
            _Abilities.Add(new Ability { Title = title, Description = description });
        }

        public static void AddAttack(string title, string description)
        {
            _Attacks.Add(new Ability { Title = title, Description = description });
        }
        
        private static string D_Immunities()
        {
            string immunities = "";
            foreach (string item in DamageImmunities)
            {
                immunities += item + ", ";
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
                resistance += item + ", ";
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
                vulnerability += item + ", ";
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
                immunities += item + ", ";
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
                skills += item.Split(':')[1] + ", ";
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

                if (temp.Contains("Passive"))
                {
                    string bonus = " " + (WIS + proficency) + " ";                    
                    temp = "Passive Perception" + bonus;
                }
                senses += temp + ", ";
            }
            if (senses.Length > 2)
            {
                senses = senses.Substring(0, senses.Length - 2);
            }

            return senses;
        }

        public static void AddSense(string sense)
        {
            _Senses.Add(sense);
        }

        private static string Languages()
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
            CR = "";

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
                _Attacks.Clear();
            }

            _Languages.Clear();
            _Senses.Clear();
        }

        public static void Output(Data fillTarget)
        {
            fillTarget._Abilities = _Abilities;
            fillTarget._Attacks = _Attacks;
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

        public static void Input(Data source)
        {
            _Abilities = source._Abilities;
            _Attacks = source._Attacks;
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
        public static List<Ability> _Attacks = new List<Ability>();

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
        public static string CR = "";

        public static string CreatureName = "";
        public static string CreatureSize = "";
        public static string CreatureType = "";
        public static string CreatureAlign = "";
        
        #endregion
    }
}
