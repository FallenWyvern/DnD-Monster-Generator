using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{
    public static partial class Monster
    {
        static string RedditMonster = "";

        public static string RedditOutput()
        {
            RedditMonster += Bold(CreatureName.Replace('*', ' ').Trim());
            RedditMonster += Italic(CreatureSize + " " + CreatureType.ToLower() + ", " + CreatureAlign.ToLower());
            RedditMonster += HR();
            RedditMonster += Bold("Armor Class", AC);
            RedditMonster += Bold("Hit Points", HP);
            RedditMonster += Bold("Speed", Speed.Replace(':', ' ').Trim());
            RedditMonster += HR();
            RedditMonster += NonSpace("STR | DEX | CON | INT | WIS | CHA");
            RedditMonster += NonSpace(":-:|:-:|:-:|:-:|:-:|:-:|");
            RedditMonster += NonSpace(STR + "|" + DEX + "|" + CON + "|" + INT + "|" + WIS + "|" + CHA);
            RedditMonster += HR();
            RedditMonster += Bold("Saving Throws", SavingThrows());
            RedditMonster += Bold("Skills", Skills());
            RedditMonster += Bold("Damage Immunities", D_Immunities());
            RedditMonster += Bold("Damage Resistances", D_Resistances());
            RedditMonster += Bold("Damage Vulnerabilities", D_Vulnerabilities());
            RedditMonster += Bold("Condition Immunities", C_Immunities());
            RedditMonster += Bold("Senses", Senses());
            RedditMonster += Bold("Languages", Languages());
            RedditMonster += Bold("Challenge", CR.CR + " (" + CR.XP + " XP)");
            RedditMonster += HR();

            foreach (Ability ability in _Abilities)
            {
                // Non Spells
                #region
                if (!ability.isSpell)
                {
                    string abilityDescription = "";

                    foreach (string abilityWord in ability.Description.Split(' '))
                    {
                        if (!abilityWord.Contains('\n'))
                        {
                            abilityDescription += abilityWord + " ";
                        }
                        else
                        {
                            string breakString = Environment.NewLine + "        ";
                            abilityDescription += abilityWord.Replace('\n'.ToString(), breakString) + " ";
                        }
                    }
                    RedditMonster += Bold(ability.ProperName(), abilityDescription);
                }
                #endregion

                // Spells
                #region
                if (ability.isSpell)
                {
                    RedditMonster += Bold("Spellcasting", ability.TextSpellcasterBoilerplate(CreatureName));
                    RedditMonster += ability.TextSpellBlockFormat();
                }
                #endregion
            }

            RedditMonster += HR();

            RedditMonster += Bold("--Actions--");

            foreach (Ability action in _Actions)
            {
                if (!action.isDamage)
                {
                    RedditMonster += Bold(action.ProperName(), action.Description);
                }
            }

            RedditMonster += HR();
            RedditMonster += Bold("--Reactions--");

            foreach (Ability reaction in _Reactions)
            {
                RedditMonster += Bold(reaction.ProperName(), reaction.Description);
            }

            RedditMonster += HR();
            RedditMonster += Bold("--Legendary Action--");

            foreach (Legendary legendary in _Legendaries)
            {
                RedditMonster += Regular(legendary.WebBoilerplate(CreatureName));
                foreach (LegendaryTrait trait in legendary.Traits)
                {
                    RedditMonster += BoldItalic(trait.ProperName(), trait.Ability);
                }
            }

            return RedditMonster;
        }

        public static string Bold(string input)
        {
            return "**" + input + "** " + Environment.NewLine + Environment.NewLine;
        }

        public static string Bold(string input, string nonBold)
        {
            return "**" + input + "** " + nonBold + Environment.NewLine + Environment.NewLine;
        }

        public static string Italic(string input)
        {
            return "*" + input + "* " + Environment.NewLine + Environment.NewLine;
        }

        public static string Italic(string input, string nonItalic)
        {
            return "*" + input + "* " + nonItalic + Environment.NewLine + Environment.NewLine;
        }

        public static string BoldItalic(string input)
        {
            return "***" + input + "*** " + Environment.NewLine + Environment.NewLine;
        }

        public static string BoldItalic(string input, string nonBoldItalic)
        {
            return "***" + input + "*** " + nonBoldItalic + Environment.NewLine + Environment.NewLine;
        }


        public static string Regular(string input)
        {
            return input + Environment.NewLine + Environment.NewLine;
        }

        public static string NonSpace(string input)
        {
            return input + Environment.NewLine;
        }

        public static string HR()
        {
            return "___" + Environment.NewLine + Environment.NewLine;
        }
    }
}
