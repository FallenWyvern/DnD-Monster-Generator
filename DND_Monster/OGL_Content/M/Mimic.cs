using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Mimic
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Mimic", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Mimic", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Mimic", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into an object or back into its true, amorphous form. Its statistics are the same in each form. Any equipment it was wearing or carrying isn't transformed. It reverts to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Mimic", Title = "Adhesive (Object Form Only)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} adheres to anything that touches it. A Huge or smaller creature adhered to the mimic is also grappled by it (escape DC 13). Ability checks made to escape this grapple have disadvantage." },
                new OGL_Ability() { OGL_Creature = "Mimic", Title = "False Appearance (Object Form Only)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from an ordinary object." },
                new OGL_Ability() { OGL_Creature = "Mimic", Title = "Grappler", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on attack rolls against any creature grappled by it." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Mimic", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Mimic", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Mimic", Title = "Pseudopod", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "If the {CREATURENAME} is in object form, the target is subjected to its Adhesive trait.",
                    HitDamageType = "bludgeoning"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Mimic", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "plus 4 (1d8) acid damage.",
                    HitDamageType = "piercing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Mimic", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Mimic",
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

            OGLContent.OGL_Creatures.Add("Mimic");
        }
    }
}
