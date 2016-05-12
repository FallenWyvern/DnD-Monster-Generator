using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Sahuaguin
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Blood Frenzy", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on melee attack rolls against any creature that doesn't have all its hit points." },
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Limited Amphibiousness", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water, but it needs to be submerged at least once every 4 hours to avoid suffocating." },
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Shark Telepathy", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can magically command any shark within 120 feet of it, using a limited telepathy." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
            //{ 
            //    _Attack = "Melee Weapon Attack",
            //    Bonus = "1",
            //    Reach = 5,
            //    RangeClose = 0,
            //    RangeFar = 0,
            //    Target = "one target",
            //    HitDiceNumber = 2,
            //    HitDiceSize = 6,
            //    HitDamageBonus = 3,
            //    HitAverageDamage = 10,
            //    HitText = "",
            //    HitDamageType = "Acid"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two melee attacks: one with its bite and one with its claws or spear."},      
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 1,
                    HitAverageDamage = 3,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 1,
                    HitAverageDamage = 3,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "Spear", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee or Ranged Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 20,
                    RangeFar = 60,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 1,
                    HitAverageDamage = 4,
                    HitText = "or 5 (1d8 + 1) piercing damage if used in two hands with a melee attack.",
                    HitDamageType = "piercing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Sahuagin", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Sahuagin",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")  
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Sahuagin");
        }
    }
}
