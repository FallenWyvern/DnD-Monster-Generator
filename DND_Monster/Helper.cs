// This class is for data structures and helper methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;

namespace DND_Monster
{    
    // Model
    public class Data
    {        
        public List<string> DamageImmunities = new List<string>();
        public List<string> ConditionImmunities = new List<string>();
        public List<string> DamageResistances = new List<string>();
        public List<string> DamageVulnerability = new List<string>();
        public List<string> SavingThrowBonuses = new List<string>();
        public List<string> SkillBonuses = new List<string>();

        public List<string> _Senses = new List<string>();
        public List<string> _Languages = new List<string>();

        public List<Ability> _Abilities = new List<Ability>();
        public List<Ability> _Actions = new List<Ability>();
        public List<Ability> _Reactions = new List<Ability>();
        public List<Legendary> _Legendaries = new List<Legendary>();        

        public string Title = "";
        public int STR = 0;
        public int DEX = 0;
        public int CON = 0;
        public int INT = 0;
        public int WIS = 0;
        public int CHA = 0;
        public int proficency = 0;

        public string Speed = "";

        public string AC = "";
        public string HP = "";
        public Challenge_Rating CR = Help.ChallengeRatings[0];

        public string CreatureName = "";
        public string CreatureSize = "";
        public string CreatureType = "";
        public string CreatureAlign = "";
    }

    public class SavedTraitData
    {
        List<Ability> _Abilities = new List<Ability>();
        List<Ability> _Actions = new List<Ability>();
        List<Ability> _Reactions = new List<Ability>();
        List<Legendary> _Legendaries = new List<Legendary>();
    }

    // Data Construct for Challenge Ratings
    public class Challenge_Rating
    {
        public int Index { get; set; }
        public string CR { get; set; }
        public int profBonus { get; set; }
        public int ArmorClass { get; set; }
        public int AttackBonus { get; set; }
        public int SaveDC { get; set; }
        public int LowHP { get; set; }
        public int HighHP { get; set; }
        public int XP { get; set; }
    }

    // Legendary ability
    public class Legendary
    {
        public string Title { get; set; }        

        public List<LegendaryTrait> Traits = new List<LegendaryTrait>();

        public void AddTrait(string title, string ability)
        {
            Traits.Add(new LegendaryTrait(title, ability));
        }

        public List<LegendaryTrait> TraitList()
        {
            return Traits;
        }

        public string WebBoilerplate(string name)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                name = "creature";
            }
            else
            {
                if (!name.Contains('*')) { name = name.ToLower(); }
            }
            return "The " + name + " can take 3 legendary actions, choosing from the options below. Only one legendary action can be used at a time and only at the end of another creature's turn. The " + name + " regains spent legendary actions at the start of its turn.";
        }
    }

    // Traits for Legendary Abilities
    public class LegendaryTrait
    {
        public string Title { get; set; }
        public string Ability { get; set; }        

        public LegendaryTrait(string title, string ability)
        {
            Title = title;
            Ability = ability;
        }

        public string ProperName()
        {
            string s = Regex.Replace(Title, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            return s;
        }
    }

    // Ability
    public class Ability
    {
        public string Title { get; set; }
        public string Description { get; set; }        
        public bool isDamage { get; set; }
        public bool isSpell { get; set; }
        public Attack attack { get; set; }

        public string ProperName()
        {
            string s = Regex.Replace(Title, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            return s;
        }

        public string WebSpellcasterBoilerplate(string name)
        {
            if (!isSpell) return "";
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) 
            { 
                name = "Creature"; 
            }
            else
            {
                if (!name.Contains('*')) { name = name.ToLower(); }
            }
            string spellcastingstat = Description.Split('|')[1];            
            int modifier = 0;

            switch (spellcastingstat.ToLower().Substring(0, 3))
            {
                case "str":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.STR) - 10) / 2);
                    break;
                case "int":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.INT) - 10) / 2);
                    break;
                case "wis":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.WIS) - 10) / 2);
                    break;
                case "cha":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.CHA) - 10) / 2);
                    break;
                case "con":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.CON) - 10) / 2);
                    break;
                case "dex":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.DEX) - 10) / 2);
                    break;
            }

            string levelSuffix = "th";
            if (Description.Split('|')[2].Trim() == "1")
            {
                levelSuffix = "st";
            } 
            if (Description.Split('|')[2].Trim() == "2")
            {
                levelSuffix = "nd";
            } 
            if (Description.Split('|')[2].Trim() == "3")
            {
                levelSuffix = "rd";
            }

            string returnstring = "";
            returnstring += "The " + name + " is a " + Description.Split('|')[2] + levelSuffix + "-level spellcaster. ";
            returnstring += "Its spellcasting ability is " + spellcastingstat + " (spell save DC " + (8 + Monster.CR.profBonus + modifier) + ", +" + (modifier + Monster.CR.profBonus) + " to hit with spell attacks). ";

            if (!Description.Contains("NotInnate"))
            {
                returnstring += "It can innately cast the following spells, requiring no material components: ";                
            }
            else
            {
                returnstring += "The " + name + " has the following " + Description.Split('|')[0] + " spells prepared:";
            }

            return "<h4>Spellcasting. </h4><p>" + returnstring + "</p></br></br>";
        }

        public string WebSpellBlockFormat_NotInnate()
        {
            if (!isSpell) return "";

            string returnstring = "";
            string spellSlots = Description.Split('|')[4];
            string[] spells = Description.Split('|')[5].Split(',');

            for (int i = 0; i < 10; i++)
            {
                if (i > 0 && Convert.ToInt16(spellSlots.Split(',')[i - 1]) == 0)
                {
                    i = 10; break; 
                }                

                if (i == 0)
                {
                    returnstring += "<p>Cantrips (at will): </p>";
                }
                else
                {
                    string suffix = "";
                    switch (i)
                    {
                        case 1:
                            suffix = "st";
                            break;
                        case 2:
                            suffix = "nd";
                            break;
                        case 3:
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }


                    returnstring += i + suffix + " level (" + spellSlots.Split(',')[i - 1] + " slots): </p>";
                }

                returnstring += "<p><i>";

                bool addedData = false;
                foreach (string item in spells)
                {                    
                    if (item.Contains(i + ":"))
                    {
                        if (!String.IsNullOrEmpty(item) || !String.IsNullOrWhiteSpace(item))
                        {
                            returnstring += item.Replace(i + ":", "").Replace("(", "</i></p>(").Replace(")", ")<p><i>") + ", ";
                            addedData = true;
                        }                            
                    }
                }
                if (addedData) { returnstring = returnstring.Substring(0, returnstring.Length - 2); }
                returnstring += "</i></p></br>";                
            } 

            return returnstring;
        }

        public string WebSpellBlockFormat_Innate()
        {
            if (!isSpell) return "";

            string returnstring = "";            
            string[] spells = Description.Split('|')[5].Split(',');            

            for (int i = 0; i < 10; i++)
            {                
                foreach (string item in spells)
                {                    
                    if (item.Contains(i + ":"))
                    {
                        if (i == 0)
                        {
                            if (!returnstring.Contains("At will"))
                            {
                                returnstring += "At will: ";
                                returnstring += "<p><i>";
                            }                            
                        }
                        else
                        {
                            if (!returnstring.Contains(i + "/day"))
                            {
                                returnstring += i + "/day each: ";
                                returnstring += "<p><i>";
                            }
                        }
                        
                        returnstring += item.Split(':')[1].Trim() + ", ";
                    }
                }
                
                returnstring = returnstring.Trim().Substring(0, returnstring.Trim().Length - 1) + "</i></p></br>";                
            }            

            return returnstring;
        }
        
        // Fix these when innate is finished
        public string TextSpellcasterBoilerplate(string name)
        {
            if (!isSpell) return "";
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                name = "Creature";
            }
            else
            {
                if (!name.Contains('*')) { name = name.ToLower(); }
            }
            string spellcastingstat = Description.Split('|')[1];
            int modifier = 0;

            switch (spellcastingstat.ToLower().Substring(0, 3))
            {
                case "str":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.STR) - 10) / 2);
                    break;
                case "int":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.INT) - 10) / 2);
                    break;
                case "wis":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.WIS) - 10) / 2);
                    break;
                case "cha":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.CHA) - 10) / 2);
                    break;
                case "con":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.CON) - 10) / 2);
                    break;
                case "dex":
                    modifier = (int)Math.Floor((double)(Convert.ToInt32(Monster.DEX) - 10) / 2);
                    break;
            }

            string levelSuffix = "th";
            if (Description.Split('|')[2].Trim() == "1")
            {
                levelSuffix = "st";
            }
            if (Description.Split('|')[2].Trim() == "2")
            {
                levelSuffix = "nd";
            }
            if (Description.Split('|')[2].Trim() == "3")
            {
                levelSuffix = "rd";
            }

            string returnstring = "";
            returnstring += "The " + name + " is a " + Description.Split('|')[2] + levelSuffix + "-level spellcaster. ";
            returnstring += "Its spellcasting ability is " + spellcastingstat + " (spell save DC " + (8 + Monster.CR.profBonus + modifier) + ", +" + (modifier + Monster.CR.profBonus) + " to hit with spell attacks). ";

            if (!Description.Contains("NotInnate"))
            {
                returnstring += "It requires no material components to cast its spells. ";
            }
            else
            {
                returnstring += "The " + name + " has the following " + Description.Split('|')[0] + " spells prepared:";
            }

            return returnstring + Environment.NewLine + Environment.NewLine;
        }
        
        public string TextSpellBlockFormat_NotInnate()
        {
            if (!isSpell) return "";

            string returnstring = "";
            string spellSlots = Description.Split('|')[4];
            string[] spells = Description.Split('|')[5].Split(',');

            for (int i = 0; i < 10; i++)
            {
                if (i > 0 && Convert.ToInt16(spellSlots.Split(',')[i - 1]) == 0)
                {
                    i = 10; break;
                }

                if (i == 0)
                {
                    returnstring += "- Cantrips (at will): ";
                }
                else
                {
                    string suffix = "";
                    switch (i)
                    {
                        case 1:
                            suffix = "st";
                            break;
                        case 2:
                            suffix = "nd";
                            break;
                        case 3:
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }


                    returnstring += "- " + i + suffix + " level (" + spellSlots.Split(',')[i - 1] + " slots): ";
                }

                returnstring += "";

                bool addedData = false;
                foreach (string item in spells)
                {                    
                    if (item.Contains(i + ":"))
                    {
                        if (!String.IsNullOrEmpty(item) || !String.IsNullOrWhiteSpace(item))
                        {
                            returnstring += "*" + item.Replace(i + ":", "").Replace("(", "*(").Replace(")", ")") + "*, ";
                            addedData = true;
                        }
                    }
                }
                
                if (addedData) { returnstring = returnstring.Substring(0, returnstring.Length - 3); }
                returnstring += "*" + Environment.NewLine + Environment.NewLine;
            }

            return returnstring;
        }

        public string TextSpellBlockFormat_Innate()
        {            
            if (!isSpell) return "";

            string returnstring = "";
            string[] spells = Description.Split('|')[5].Split(',');            

            for (int i = 0; i < 10; i++)
            {
                foreach (string item in spells)
                {                    
                    if (item.Contains(i + ":"))
                    {
                        if (i == 0)
                        {
                            if (!returnstring.Contains("At will"))
                            {
                                returnstring += "- At will: ";
                            }
                        }
                        else
                        {
                            if (!returnstring.Contains(i + "/day"))
                            {
                                returnstring += "- " + i + "/day each: ";
                            }
                        }

                        returnstring += "*" + item.Split(':')[1].Trim() + "*, ";                        
                    }                    
                }
                returnstring = returnstring.Substring(0, returnstring.Length - 2) + Environment.NewLine + Environment.NewLine;                                    
            }

            returnstring = returnstring.Trim() + Environment.NewLine + Environment.NewLine;
            return returnstring;
        }        
    }

    // Attack
    public class Attack 
    {
        public string _Attack { get; set; }
        public string Bonus { get; set; }
        public int Reach { get; set; }
        public int RangeClose { get; set; }
        public int RangeFar { get; set; }
        public string Target { get; set; }
        public int HitDiceNumber { get; set; }
        public int HitDiceSize { get; set; }
        public int HitDamageBonus { get; set; }
        public int HitAverageDamage { get; set; }
        public string HitText { get; set; }
        public string HitDamageType { get; set; }
        
        public Attack()
        {

        }

        public Attack(string attack, string bonus, int reach, int rangeClose, int rangeFar, string target, int hitAverageDamage, int hitDiceNumber, int hitDiceSize, int hitDamageBonus, string damageType, string hit)
        {
            _Attack = attack;
            Bonus = bonus;
            Reach = reach;
            RangeClose = rangeClose;
            RangeFar = rangeFar;
            Target = target;
            HitAverageDamage = hitAverageDamage;
            HitDiceNumber = hitDiceNumber;
            HitDiceSize = hitDiceSize;
            HitDamageBonus = hitDamageBonus;
            HitDamageType = damageType;
            HitText = hit;            
        }

        public string WebDescribe()
        {
            string returnstring = "<i>";
            returnstring += _Attack + ": </i>+";
            returnstring += Bonus + " to hit, ";

            if (Reach > 0)
            {
                returnstring += "reach " + Reach + " ft., ";
            }

            if (Reach > 0 && (RangeFar > 0 || RangeClose > 0))
            {
                returnstring += " or ";
            }

            if (RangeClose > 0)
            {
                returnstring += "range " + RangeClose;
                if (RangeFar > 0)
                {
                    returnstring += "/" + RangeFar;
                }
                returnstring += " ft., ";
            }

            returnstring += Target;

            if (!String.IsNullOrEmpty(Target) || !String.IsNullOrWhiteSpace(Target))
            {
                if (Target[Target.Length - 1] != '.')
                {
                    returnstring += ".";
                }
            }

            returnstring += " <i>Hit:</i> ";

            if (HitDiceNumber > 0)
            {
                returnstring += HitAverageDamage + " (" + HitDiceNumber + "d" + HitDiceSize;
                if (HitDamageBonus > -1)
                {
                    returnstring += "+";
                }
                returnstring += HitDamageBonus + ") " + HitDamageType.ToLower() + " damage. ";
            }

            returnstring += HitText;

            return returnstring;
        }
        public string TextDescribe()
        {
            string returnstring = "*";
            returnstring += _Attack + ":* +";
            returnstring += Bonus + " to hit, ";

            if (Reach > 0)
            {
                returnstring += "reach " + Reach + " ft., ";
            }

            if (Reach > 0 && (RangeFar > 0 || RangeClose > 0))
            {
                returnstring += " or ";
            }

            if (RangeClose > 0)
            {
                returnstring += "range " + RangeClose;
                if (RangeFar > 0)
                {
                    returnstring += "/" + RangeFar;
                }
                returnstring += " ft., ";
            }

            returnstring += Target;

            if (!String.IsNullOrEmpty(Target) || !String.IsNullOrWhiteSpace(Target))
            {
                if (Target[Target.Length - 1] != '.')
                {
                    returnstring += ".";
                }
            }

            returnstring += " *Hit:* ";

            if (HitDiceNumber > 0)
            {
                returnstring += HitAverageDamage + " (" + HitDiceNumber + "d" + HitDiceSize;
                if (HitDamageBonus > -1)
                {
                    returnstring += "+";
                }
                returnstring += HitDamageBonus + ") " + HitDamageType.ToLower() + " damage. ";
            }

            returnstring += HitText;

            return returnstring;
        }
    }

    // Reaction
    public class Reaction : Ability
    {

    }

    // Assistance Classes
    public static class Help
    {
        public static string Version = "3.1.7";
        public static string VersionURL = @"http://download.thegeniusinc.com/monster_generator/version.txt";
        public static string LastDirectory = System.IO.Directory.GetCurrentDirectory().ToString();
        public static string TemplateName = "Valloric's StatBlock";

        public static bool useBG = false;
        private static string bgURI = "";
        
        // Used to check for updates.
        public static bool CheckForDownload()
        {            
            using (WebClient w = new WebClient())
            {                    
                string result = w.DownloadString(Help.VersionURL);
                Console.WriteLine(result);
                Console.WriteLine(Help.Version);
                if (result == Help.Version) { return true; } else { return false; }
            }
        }        

        // Object of all Challenge Ratings
        public static List<Challenge_Rating> ChallengeRatings = new List<Challenge_Rating>
        {
            new Challenge_Rating {Index = 0, CR = "0", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 1, HighHP = 6, XP = 0 },
            new Challenge_Rating {Index = 1, CR = "1/8", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 7, HighHP = 35, XP = 25},
            new Challenge_Rating {Index = 2, CR = "1/4", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 36, HighHP = 49, XP = 50 },
            new Challenge_Rating {Index = 3, CR = "1/2", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 50, HighHP = 70, XP = 100 },
            new Challenge_Rating {Index = 4, CR = "1", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 17, HighHP = 85, XP = 200 },
            new Challenge_Rating {Index = 5, CR = "2", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 86, HighHP = 100, XP = 450 },
            new Challenge_Rating {Index = 6, CR = "3", profBonus = 2, ArmorClass = 13, AttackBonus = 4, SaveDC = 13, LowHP = 101, HighHP = 115, XP = 700 },
            new Challenge_Rating {Index = 7, CR = "4", profBonus = 2, ArmorClass = 14, AttackBonus = 5, SaveDC = 14, LowHP = 116, HighHP = 130, XP = 1100 },
            new Challenge_Rating {Index = 8, CR = "5", profBonus = 3, ArmorClass = 15, AttackBonus = 6, SaveDC = 15, LowHP = 131, HighHP = 145, XP = 1800 },
            new Challenge_Rating {Index = 9, CR = "6", profBonus = 3, ArmorClass = 15, AttackBonus = 6, SaveDC = 15, LowHP = 146, HighHP = 160, XP = 2300 },
            new Challenge_Rating {Index = 10, CR = "7", profBonus = 3, ArmorClass = 15, AttackBonus = 6, SaveDC = 15, LowHP = 161, HighHP = 175, XP = 2900 },
            new Challenge_Rating {Index = 11, CR = "8", profBonus = 3, ArmorClass = 16, AttackBonus = 7, SaveDC = 16, LowHP = 176, HighHP = 190, XP = 3900 },
            new Challenge_Rating {Index = 12, CR = "9", profBonus = 4, ArmorClass = 16, AttackBonus = 7, SaveDC = 16, LowHP = 191, HighHP = 205, XP = 5000 },
            new Challenge_Rating {Index = 13, CR = "10", profBonus = 4, ArmorClass = 17, AttackBonus = 7, SaveDC = 16, LowHP = 206, HighHP = 220, XP = 5900},
            new Challenge_Rating {Index = 14, CR = "11", profBonus = 4, ArmorClass = 17, AttackBonus = 8, SaveDC = 17, LowHP = 221, HighHP = 235, XP = 7200},
            new Challenge_Rating {Index = 15, CR = "12", profBonus = 4, ArmorClass = 17, AttackBonus = 8, SaveDC = 17, LowHP = 236, HighHP = 250, XP = 8400},
            new Challenge_Rating {Index = 16, CR = "13", profBonus = 5, ArmorClass = 18, AttackBonus = 8, SaveDC = 18, LowHP = 251, HighHP = 265, XP = 10000},
            new Challenge_Rating {Index = 17, CR = "14", profBonus = 5, ArmorClass = 18, AttackBonus = 8, SaveDC = 18, LowHP = 266, HighHP = 280, XP = 11500},
            new Challenge_Rating {Index = 18, CR = "15", profBonus = 5, ArmorClass = 18, AttackBonus = 8, SaveDC = 18, LowHP = 281, HighHP = 295, XP = 13000},
            new Challenge_Rating {Index = 19, CR = "16", profBonus = 5, ArmorClass = 18, AttackBonus = 9, SaveDC = 18, LowHP = 296, HighHP = 310, XP = 15000},
            new Challenge_Rating {Index = 20, CR = "17", profBonus = 6, ArmorClass = 18, AttackBonus = 10, SaveDC = 19, LowHP = 311, HighHP = 325, XP = 18000},
            new Challenge_Rating {Index = 21, CR = "18", profBonus = 6, ArmorClass = 19, AttackBonus = 10, SaveDC = 19, LowHP = 326, HighHP = 340, XP = 20000},
            new Challenge_Rating {Index = 22, CR = "19", profBonus = 6, ArmorClass = 19, AttackBonus = 10, SaveDC = 19, LowHP = 341, HighHP = 355, XP = 22000},
            new Challenge_Rating {Index = 23, CR = "20", profBonus = 6, ArmorClass = 19, AttackBonus = 10, SaveDC = 19, LowHP = 356, HighHP = 400, XP = 25000},
            new Challenge_Rating {Index = 24, CR = "21", profBonus = 7, ArmorClass = 19, AttackBonus = 11, SaveDC = 20, LowHP = 401, HighHP = 445, XP = 33000},
            new Challenge_Rating {Index = 25, CR = "22", profBonus = 7, ArmorClass = 19, AttackBonus = 11, SaveDC = 20, LowHP = 446, HighHP = 490, XP = 41000},
            new Challenge_Rating {Index = 26, CR = "23", profBonus = 7, ArmorClass = 19, AttackBonus = 11, SaveDC = 20, LowHP = 491, HighHP = 535, XP = 50000},
            new Challenge_Rating {Index = 27, CR = "24", profBonus = 7, ArmorClass = 19, AttackBonus = 12, SaveDC = 21, LowHP = 536, HighHP = 580, XP = 62000},
            new Challenge_Rating {Index = 28, CR = "25", profBonus = 8, ArmorClass = 19, AttackBonus = 12, SaveDC = 21, LowHP = 581, HighHP = 625, XP = 75000},
            new Challenge_Rating {Index = 29, CR = "26", profBonus = 8, ArmorClass = 19, AttackBonus = 12, SaveDC = 21, LowHP = 626, HighHP = 670, XP = 90000},
            new Challenge_Rating {Index = 30, CR = "27", profBonus = 8, ArmorClass = 19, AttackBonus = 13, SaveDC = 22, LowHP = 671, HighHP = 715, XP = 105000},
            new Challenge_Rating {Index = 31, CR = "28", profBonus = 8, ArmorClass = 19, AttackBonus = 13, SaveDC = 22, LowHP = 716, HighHP = 760, XP = 120000},
            new Challenge_Rating {Index = 32, CR = "29", profBonus = 9, ArmorClass = 19, AttackBonus = 13, SaveDC = 22, LowHP = 761, HighHP = 805, XP = 135000 },
            new Challenge_Rating {Index = 33, CR = "30", profBonus = 9, ArmorClass = 19, AttackBonus = 14, SaveDC = 23, LowHP = 806, HighHP = 850, XP = 155000 },
        };

        // Find CR based on HP (Int).
        static public Challenge_Rating FindCRByHP(int hp)
        {
            foreach (Challenge_Rating cr in ChallengeRatings)
            {
                if (hp >= cr.LowHP && hp <= cr.HighHP)
                {
                    return cr;
                }
            }

            return null;
        }

        // Find CR based on the Index.
        static public Challenge_Rating FindCRByIndex(int index)
        {
            foreach (Challenge_Rating cr in ChallengeRatings)
            {
                if (cr.Index == index)
                {
                    return cr;
                }
            }

            return null;
        }

        // Find CR based on HP (String).
        static public Challenge_Rating FindCRByHP(string hp)
        {
            int tempHP = 0;
            int.TryParse(hp, out tempHP);
            return FindCRByHP(tempHP);
        }

        static public string BackgroundImage()
        {            
            switch (Help.TemplateName)
            {
                case "Future":
                    bgURI = "";
                    return FutureBackgroundURI();                   
                default:
                    bgURI = "";
                    return ValloricBackgroundURI();                    
            }
        }

        // Returns fantasy background from 'background-small.uri'
        static public string ValloricBackgroundURI()
        {
            if (useBG)
            {
                if (bgURI == "") { bgURI = System.IO.File.ReadAllText("Resource/background-small.uri"); }
                return bgURI;
            }
            else
            {
                return "";
            }
        }

        // Returns future background from 'background-small.uri'
        static public string FutureBackgroundURI()
        {
            if (useBG)
            {
                if (bgURI == "") { bgURI = System.IO.File.ReadAllText("Resource/background-carbon.uri"); }
                return bgURI;
            }
            else
            {
                return "";
            }
        }

        // Replaces System.Threading.Tasks.Task.Delay (4.5 minimum) 
        // found at http://stackoverflow.com/questions/15341962/how-to-put-a-task-to-sleep-or-delay-in-c-sharp-4-0
        public static Task Delay(double milliseconds)
        {
            var tcs = new TaskCompletionSource<bool>();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (obj, args) =>
            {
                tcs.TrySetResult(true);
            };
            timer.Interval = milliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }
    }
}
