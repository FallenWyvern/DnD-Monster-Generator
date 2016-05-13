using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Treant
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Treant", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Treant", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Treant", Title = "False Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from a normal tree." },
                new OGL_Ability() { OGL_Creature = "Treant", Title = "Siege Monster", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} deals double damage to objects and structures." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Treant", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Treant", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Treant", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two slam attacks."},      
                 new OGL_Ability() { OGL_Creature = "Treant", Title = "Slam", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 16,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
                 new OGL_Ability() { OGL_Creature = "Treant", Title = "Rock", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "10",
                    Reach = 0,
                    RangeClose = 60,
                    RangeFar = 180,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 28,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
                 new OGL_Ability() { OGL_Creature = "Treant", Title = "Animate Trees (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically animates one or two trees it can see within 60 feet of it. These trees have the same statistics as a {CREATURENAME}, except they have Intelligence and Charisma scores of 1, they can't speak, and they only have the Slam attack option. An animated tree acts as an ally of the {CREATURENAME}. The tree remains animate for 1 day or until it dies; until the {CREATURENAME} dies or is more than 120 feet from the tree; or until the {CREATURENAME} takes a bonus action to turn it back into an inanimate tree. The tree then takes root if possible."},      
            });

            // new OGL_Ability() { OGL_Creature = "Treant", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Treant",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Treant");
        }
    }
}
