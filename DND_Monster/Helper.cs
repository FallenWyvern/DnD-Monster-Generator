// This class is for data structures and helper methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{
    public class Data
    {
        //public List<string> output = new List<string>();
        public List<string> DamageImmunities = new List<string>();
        public List<string> ConditionImmunities = new List<string>();
        public List<string> DamageResistances = new List<string>();
        public List<string> DamageVulnerability = new List<string>();
        public List<string> SavingThrowBonuses = new List<string>();
        public List<string> SkillBonuses = new List<string>();

        public List<string> _Senses = new List<string>();
        public List<string> _Languages = new List<string>();

        public List<Ability> _Abilities = new List<Ability>();
        public List<Ability> _Attacks = new List<Ability>();

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
        public string CR = "";

        public string CreatureName = "";
        public string CreatureSize = "";
        public string CreatureType = "";
        public string CreatureAlign = "";
    }

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
    }

    public static class Help
    {
        public static List<Challenge_Rating> ChallengeRatings = new List<Challenge_Rating>
    {
        new Challenge_Rating {Index = 0, CR = "0", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 1, HighHP = 6 },
        new Challenge_Rating {Index = 1, CR = "1/8", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 7, HighHP = 35 },
        new Challenge_Rating {Index = 2, CR = "1/4", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 36, HighHP = 49 },
        new Challenge_Rating {Index = 3, CR = "1/2", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 50, HighHP = 70 },
        new Challenge_Rating {Index = 4, CR = "1", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 17, HighHP = 85 },
        new Challenge_Rating {Index = 5, CR = "2", profBonus = 2, ArmorClass = 13, AttackBonus = 3, SaveDC = 13, LowHP = 86, HighHP = 100 },
        new Challenge_Rating {Index = 6, CR = "3", profBonus = 2, ArmorClass = 13, AttackBonus = 4, SaveDC = 13, LowHP = 101, HighHP = 115 },
        new Challenge_Rating {Index = 7, CR = "4", profBonus = 2, ArmorClass = 14, AttackBonus = 5, SaveDC = 14, LowHP = 116, HighHP = 130 },
        new Challenge_Rating {Index = 8, CR = "5", profBonus = 3, ArmorClass = 15, AttackBonus = 6, SaveDC = 15, LowHP = 131, HighHP = 145 },
        new Challenge_Rating {Index = 9, CR = "6", profBonus = 3, ArmorClass = 15, AttackBonus = 6, SaveDC = 15, LowHP = 146, HighHP = 160 },
        new Challenge_Rating {Index = 10, CR = "7", profBonus = 3, ArmorClass = 15, AttackBonus = 6, SaveDC = 15, LowHP = 161, HighHP = 175 },
        new Challenge_Rating {Index = 11, CR = "8", profBonus = 3, ArmorClass = 16, AttackBonus = 7, SaveDC = 16, LowHP = 176, HighHP = 190 },
        new Challenge_Rating {Index = 12, CR = "9", profBonus = 4, ArmorClass = 16, AttackBonus = 7, SaveDC = 16, LowHP = 191, HighHP = 205 },
        new Challenge_Rating {Index = 13, CR = "10", profBonus = 4, ArmorClass = 17, AttackBonus = 7, SaveDC = 16, LowHP = 206, HighHP = 220 },
        new Challenge_Rating {Index = 14, CR = "11", profBonus = 4, ArmorClass = 17, AttackBonus = 8, SaveDC = 17, LowHP = 221, HighHP = 235 },
        new Challenge_Rating {Index = 15, CR = "12", profBonus = 4, ArmorClass = 17, AttackBonus = 8, SaveDC = 17, LowHP = 236, HighHP = 250 },
        new Challenge_Rating {Index = 16, CR = "13", profBonus = 5, ArmorClass = 18, AttackBonus = 8, SaveDC = 18, LowHP = 251, HighHP = 265 },
        new Challenge_Rating {Index = 17, CR = "14", profBonus = 5, ArmorClass = 18, AttackBonus = 8, SaveDC = 18, LowHP = 266, HighHP = 280 },
        new Challenge_Rating {Index = 18, CR = "15", profBonus = 5, ArmorClass = 18, AttackBonus = 8, SaveDC = 18, LowHP = 281, HighHP = 295 },
        new Challenge_Rating {Index = 19, CR = "16", profBonus = 5, ArmorClass = 18, AttackBonus = 9, SaveDC = 18, LowHP = 296, HighHP = 310 },
        new Challenge_Rating {Index = 20, CR = "17", profBonus = 6, ArmorClass = 18, AttackBonus = 10, SaveDC = 19, LowHP = 311, HighHP = 325 },
        new Challenge_Rating {Index = 21, CR = "18", profBonus = 6, ArmorClass = 19, AttackBonus = 10, SaveDC = 19, LowHP = 326, HighHP = 340 },
        new Challenge_Rating {Index = 22, CR = "19", profBonus = 6, ArmorClass = 19, AttackBonus = 10, SaveDC = 19, LowHP = 341, HighHP = 355 },
        new Challenge_Rating {Index = 23, CR = "20", profBonus = 6, ArmorClass = 19, AttackBonus = 10, SaveDC = 19, LowHP = 356, HighHP = 400 },
        new Challenge_Rating {Index = 24, CR = "21", profBonus = 7, ArmorClass = 19, AttackBonus = 11, SaveDC = 20, LowHP = 401, HighHP = 445 },
        new Challenge_Rating {Index = 25, CR = "22", profBonus = 7, ArmorClass = 19, AttackBonus = 11, SaveDC = 20, LowHP = 446, HighHP = 490 },
        new Challenge_Rating {Index = 26, CR = "23", profBonus = 7, ArmorClass = 19, AttackBonus = 11, SaveDC = 20, LowHP = 491, HighHP = 535 },
        new Challenge_Rating {Index = 27, CR = "24", profBonus = 7, ArmorClass = 19, AttackBonus = 12, SaveDC = 21, LowHP = 536, HighHP = 580 },
        new Challenge_Rating {Index = 28, CR = "25", profBonus = 8, ArmorClass = 19, AttackBonus = 12, SaveDC = 21, LowHP = 581, HighHP = 625 },
        new Challenge_Rating {Index = 29, CR = "26", profBonus = 8, ArmorClass = 19, AttackBonus = 12, SaveDC = 21, LowHP = 626, HighHP = 670 },
        new Challenge_Rating {Index = 30, CR = "27", profBonus = 8, ArmorClass = 19, AttackBonus = 13, SaveDC = 22, LowHP = 671, HighHP = 715 },
        new Challenge_Rating {Index = 31, CR = "28", profBonus = 8, ArmorClass = 19, AttackBonus = 13, SaveDC = 22, LowHP = 716, HighHP = 760 },
        new Challenge_Rating {Index = 32, CR = "29", profBonus = 9, ArmorClass = 19, AttackBonus = 13, SaveDC = 22, LowHP = 761, HighHP = 805 },
        new Challenge_Rating {Index = 33, CR = "30", profBonus = 9, ArmorClass = 19, AttackBonus = 14, SaveDC = 23, LowHP = 806, HighHP = 850 },
    };

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

        static public Challenge_Rating FindCRByHP(string hp)
        {
            int tempHP = 0;
            int.TryParse(hp, out tempHP);
            return FindCRByHP(tempHP);
        }
    }
}
