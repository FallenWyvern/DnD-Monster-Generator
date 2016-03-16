using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Ettercap
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Ettercap", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check." },
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Web Sense", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While in contact with a web, the {CREATURENAME} knows the exact location of any other creature in contact with the same web." },
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Web Walker", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} ignores movement restrictions caused by webbing." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Ettercap", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Ettercap", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its bite and one with its claws."},      
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 2,
                    HitAverageDamage = 6,
                    HitText = "plus 4 (1d8) poison damage. The target must succeed on a DC 11 Constitution saving throw or be poisoned for 1 minute. The creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.",
                    HitDamageType = "piercing"
                }
                },                  
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 4,
                    HitDamageBonus = 2,
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ettercap", Title = "Web (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "<i>Ranged Weapon Attack</i>: +4 to hit, range 30/60 ft., one Large or smaller creature. <i>Hit:</i> The creature is restrained by webbing. As an action, the restrained creature can make a DC 11 Strength check, escaping from the webbing on a success. The effect also ends if the webbing is destroyed. The webbing has AC 10, 5 hit points, vulnerability to fire damage, and immunity to bludgeoning, poison and psychic damage."},      
            });

            // new OGL_Ability() { OGL_Creature = "Ettercap", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Ettercap",
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

            OGLContent.OGL_Creatures.Add("Ettercap");
        }
    }
}
