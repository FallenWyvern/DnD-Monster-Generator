using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Glabrezu
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 16, 
                Description = "bard|Intelligence|0|Innate|0,0,0,0,0,0,0,0,0|0:darkness,0:detect magic,0:dispel magic,1:confusion,1:fly,1:power word stun,|" },
                new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitText = "plus this text",
            //    HitDamageType = "Acid"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
                 new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "Pincer", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 5,
                    HitAverageDamage = 16,
                    HitText = "If the target is a Medium or smaller creature, it is grappled (escape DC 15). The {CREATURENAME} has two pincers, each of which can grapple only one target.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "Fist", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 4,
                    HitDamageBonus = 2,
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Glabrezu", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Glabrezu",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")                    
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Glaberzu");
        }
    }
}
