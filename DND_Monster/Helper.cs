// This class is for data structures and helper methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{
    //using CefSharp;
    //using System.IO;
    //using System.Reflection;

    //class ResourceSchemeHandlerFactory : ISchemeHandlerFactory
    //{
    //    public ISchemeHandler Create()
    //    {
    //        return new ResourceSchemeHandler();
    //    }

    //    public static string SchemeName { get { return "resource"; } }
    //}

    //public class ResourceSchemeHandler : ISchemeHandler
    //{
    //    public bool ProcessRequestAsync(IRequest request, ISchemeHandlerResponse response, OnRequestCompletedHandler requestCompletedCallback)
    //    {
    //        Uri u = new Uri(request.Url);
    //        String file = u.Authority + u.AbsolutePath;

    //        Assembly ass = Assembly.GetExecutingAssembly();
    //        String resourcePath = ass.GetName().Name + "." + file.Replace("/", ".");

    //        if (ass.GetManifestResourceInfo(resourcePath) != null)
    //        {
    //            response.ResponseStream = ass.GetManifestResourceStream(resourcePath);
    //            switch (Path.GetExtension(file))
    //            {
    //                case ".html":
    //                    response.MimeType = "text/html";
    //                    break;
    //                case ".js":
    //                    response.MimeType = "text/javascript";
    //                    break;
    //                case ".png":
    //                    response.MimeType = "image/png";
    //                    break;
    //                case ".appcache":
    //                case ".manifest":
    //                    response.MimeType = "text/cache-manifest";
    //                    break;
    //                default:
    //                    response.MimeType = "application/octet-stream";
    //                    break;
    //            }
    //            requestCompletedCallback();
    //            return true;
    //        }
    //        return false;
    //    }
    //}

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
        public Challenge_Rating CR = Help.ChallengeRatings[0];

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
        public int XP { get; set; }
    }

    public class Legendary
    {
        public string Title { get; set; }        
        private List<LegendaryTrait> Traits = new List<LegendaryTrait>();

        public void AddTrait(string title, string ability)
        {
            Traits.Add(new LegendaryTrait(title, ability));
        }

        public List<LegendaryTrait> TraitList()
        {
            return Traits;
        }

        public string Boilerplate(string name)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                name = "creature";
            }
            return "The " + name + " can take 3 legendary actions, choosing from the options below. Only one legendary action can be used at a time and only at the end of another creature's turn. The " + name + " regains spent legendary actions at the start of its turn.";
        }
    }

    public class LegendaryTrait
    {
        public string Title { get; set; }
        public string Ability { get; set; }

        public LegendaryTrait(string title, string ability)
        {
            Title = title;
            Ability = ability;
        }
    }

    public class Ability
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isDamage { get; set; }
    }

    public class Attack : Ability
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
            Description = Describe();
        }

        public string Describe()
        {
            string returnstring = "<i>";
            returnstring += _Attack + ": </i>+";
            returnstring += Bonus + ", ";

            if (Reach > 0)
            {
                returnstring += "Reach: " + Reach + " ft., ";
            }

            if (RangeClose > 0)
            {
                returnstring += "Range: " + RangeClose;
                if (RangeFar > 0)
                {
                    returnstring += "/" + RangeFar;
                }
                returnstring += " ft., ";
            }

            returnstring += Target;
            returnstring += " <i>Hit:</i> " + HitAverageDamage + " (" + HitDiceNumber + "d" + HitDiceSize;
            if (HitDamageBonus > -1)
            {
                returnstring += "+";
            }
            returnstring += HitDamageBonus + ") " + HitDamageType + " damage " + HitText;

            return returnstring;
        }
    }

    public static class Help
    {
        public static string Version = "1.2";
        private static string bgURI = "";

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

        static public string BackgroundURI()
        {
            if (bgURI == "") { bgURI = System.IO.File.ReadAllText("background.uri"); }  
            return bgURI;
        }
    }
}
