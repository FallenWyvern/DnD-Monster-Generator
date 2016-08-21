using System;
using System.Linq;

namespace DND_Monster
{
    public static partial class Monster
    {
        static string RedditMonster = "";
        public static string sDoddlerIndex = "";
        public static string sDoddlerCreature = "";

        public static string sDoddlerOutput()
        {
            string align = "Unaligned";
            if (CreatureAlign.Split(' ').Length > 1)
            {
                if (CreatureAlign == "True Neutral")
                {
                    align = "N";
                }
                else
                {
                    align = CreatureAlign[0].ToString();
                    align += (CreatureAlign.Split(' ')[1][0]).ToString();
                    align = align.ToUpper();
                }
            }

            RedditMonster = Monster.CreatureName + "=" + Monster.CreatureSize + @"\\";
            RedditMonster += (Monster.CreatureType.Contains('(')) ? Monster.CreatureType.Replace(" (", @"\\").Replace(")", "") + @"\\" : Monster.CreatureType + @"\\\\";
            RedditMonster += align + @"\\" + CR.CR + @"\\" + CR.XP + @"\\" + HP + @"\\" + "Custom";
            sDoddlerIndex = RedditMonster;

            RedditMonster += Environment.NewLine;

            RedditMonster += "[" + Monster.CreatureName + "]" + Environment.NewLine;
            RedditMonster += "AC= " + Monster.AC + Environment.NewLine;
            RedditMonster += "STR=" + Monster.STR + " (" + Monster.StatMod(Monster.STR) + ")" + Environment.NewLine;
            RedditMonster += "DEX=" + Monster.DEX + " (" + Monster.StatMod(Monster.DEX) + ")" + Environment.NewLine;
            RedditMonster += "CON=" + Monster.CON + " (" + Monster.StatMod(Monster.CON) + ")" + Environment.NewLine;
            RedditMonster += "INT=" + Monster.INT + " (" + Monster.StatMod(Monster.INT) + ")" + Environment.NewLine;
            RedditMonster += "WIS=" + Monster.WIS + " (" + Monster.StatMod(Monster.WIS) + ")" + Environment.NewLine;
            RedditMonster += "CHA=" + Monster.CHA + " (" + Monster.StatMod(Monster.CHA) + ")" + Environment.NewLine;
            RedditMonster += "Speed=" + Monster.Speed.Replace(":", "") + Environment.NewLine;
            RedditMonster += "Senses=" + Monster.Senses() + Environment.NewLine;            

            if (!String.IsNullOrEmpty(Monster.Skills()))
            {
                RedditMonster += "Skills=" + Monster.Skills() + Environment.NewLine;
            }

            if (!String.IsNullOrEmpty(Monster.SavingThrows()))
            {
                RedditMonster += "Saving Throws=" + Monster.SavingThrows() + Environment.NewLine;
            }

            if (Monster._Languages.Count > 0)
            {
                RedditMonster += "Languages= " + Monster.Languages() + Environment.NewLine;
            }
            
            if (!String.IsNullOrEmpty(Monster.D_Immunities()))
            {
                RedditMonster += "Damage Immunities=" + Monster.D_Immunities() + Environment.NewLine;
            }

            if (!String.IsNullOrEmpty(Monster.D_Resistances()))
            {
                RedditMonster += "Damage Resistances=" + Monster.D_Resistances() + Environment.NewLine;
            }

            if (!String.IsNullOrEmpty(Monster.D_Vulnerabilities()))
            {
                RedditMonster += "Damage Vulnerabilities=" + Monster.D_Vulnerabilities() + Environment.NewLine;
            }

            if (!String.IsNullOrEmpty(Monster.C_Immunities()))
            {
                RedditMonster += "Condition Immunities=" + Monster.C_Immunities() + Environment.NewLine;
            }

            sDoddlerCreature = RedditMonster.Replace(sDoddlerIndex + Environment.NewLine, "");
            return RedditMonster;
        }

        public static string RedditOutput()
        {
            RedditMonster = "";
            RedditMonster += Bold(CreatureName.Replace('*', ' ').Trim());
            RedditMonster += Italic(CreatureSize + " " + CreatureType.ToLower() + ", " + CreatureAlign.ToLower());
            RedditMonster += HR();
            RedditMonster += Bold("Armor Class", AC);
            RedditMonster += Bold("Hit Points", HP);
            RedditMonster += Bold("Speed", Speed.Replace(':', ' ').Trim());
            RedditMonster += HR();
            RedditMonster += NonSpace("STR | DEX | CON | INT | WIS | CHA");
            RedditMonster += NonSpace(":-:|:-:|:-:|:-:|:-:|:-:|");
            RedditMonster += NonSpace(STR + " (" + StatMod(STR)  + ")|"
                + DEX + " (" + StatMod(DEX) + ")|"
                + CON + " (" + StatMod(CON) + ")|"
                + INT + " (" + StatMod(INT) + ")|"
                + WIS + " (" + StatMod(WIS) + ")|"
                + CHA + " (" + StatMod(CHA) + ")|");
            RedditMonster += HR();
            if (SavingThrows().Length > 0)
            {
                RedditMonster += Bold("Saving Throws", SavingThrows());
            }

            if (Skills().Length > 0)
            {
                RedditMonster += Bold("Skills", Skills());
            }

            if (D_Immunities().Length > 0)
            {
                RedditMonster += Bold("Damage Immunities", D_Immunities());
            }

            if (D_Resistances().Length > 0)
            {
                RedditMonster += Bold("Damage Resistances", D_Resistances());
            }

            if (D_Vulnerabilities().Length > 0)
            {
                RedditMonster += Bold("Damage Vulnerabilities", D_Vulnerabilities());
            }

            if (C_Immunities().Length > 0)
            {
                RedditMonster += Bold("Condition Immunities", C_Immunities());
            }

            if (Senses().Length > 0)
            {
                RedditMonster += Bold("Senses", Senses());
            }

            RedditMonster += Bold("Languages", Languages());
            RedditMonster += Bold("Challenge", CR.CR + " (" + CR.XP + " XP)");
            RedditMonster += HR();

            if (_Abilities.Count > 0)
            {
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
                        RedditMonster += Bold(ability.ProperName() + ".", abilityDescription);
                    }
                    #endregion

                    // Spells
                    #region
                    if (ability.isSpell)
                    {
                        RedditMonster += Bold("Spellcasting.", ability.TextSpellcasterBoilerplate(CreatureName));
                        if (ability.Description.Contains("NotInnate"))
                        {
                            RedditMonster += ability.TextSpellBlockFormat_NotInnate();
                        }
                        else
                        {
                            RedditMonster += ability.TextSpellBlockFormat_Innate();
                        }
                    }
                    #endregion
                }
                RedditMonster += HR();
            }

            if (_Actions.Count > 0)
            {
                RedditMonster += Bold("--Actions--");
                foreach (Ability action in _Actions)
                {
                    if (!action.isDamage)
                    {
                        RedditMonster += Bold(action.ProperName() + ".", action.Description);
                    }
                    else
                    {
                        RedditMonster += Bold(action.ProperName() + ".", action.attack.TextDescribe());
                    }
                }
                RedditMonster += HR();
            }

            if (_Reactions.Count > 0)
            {
                RedditMonster += Bold("--Reactions--");

                foreach (Ability reaction in _Reactions)
                {
                    RedditMonster += Bold(reaction.ProperName() + ".", reaction.Description);
                }

                RedditMonster += HR();
            }

            if (_Legendaries.Count > 0)
            {
                RedditMonster += Bold("--Legendary Action--");

                foreach (Legendary legendary in _Legendaries)
                {
                    RedditMonster += Regular(legendary.WebBoilerplate(CreatureName));
                    foreach (LegendaryTrait trait in legendary.Traits)
                    {
                        RedditMonster += BoldItalic(trait.ProperName() + ".", trait.Ability);
                    }
                }
            }

            if (!Settings.isFeet)
            {
                RedditMonster.Replace("feet", "meters").Replace("Feet", "Meters").Replace("ft.", "meters");
            }
            return RedditMonster;
        }

        public static string Bold(string input)
        {
            return "**" + input + "** " + "  " + Environment.NewLine;
        }

        public static string Bold(string input, string nonBold)
        {
            return "**" + input + "** " + nonBold + "  " + Environment.NewLine;
        }

        public static string Italic(string input)
        {
            return "*" + input + "* " + "  " + Environment.NewLine;
        }

        public static string Italic(string input, string nonItalic)
        {
            return "*" + input + "* " + nonItalic + "  " + Environment.NewLine;
        }

        public static string BoldItalic(string input)
        {
            return "***" + input + "*** " + "  " + Environment.NewLine;
        }

        public static string BoldItalic(string input, string nonBoldItalic)
        {
            return "***" + input + "*** " + nonBoldItalic + "  " + Environment.NewLine;
        }


        public static string Regular(string input)
        {
            return input + "  " + Environment.NewLine;
        }

        public static string NonSpace(string input)
        {
            return input + Environment.NewLine;
        }

        public static string HR()
        {
            return "___" + "  " + Environment.NewLine;
        }

        public static string StatMod(int stat)
        {
            string returnMod = "";
            int modifier = (int)Math.Floor((double)(stat - 10) / 2);

            if (modifier >= 0)
            {
                returnMod = "+" + modifier;
            }
            else
            {
                returnMod = modifier + "";
            }
            return returnMod;
        }
    }
}
