using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Dretch
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Dretch", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Dretch", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Dretch", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Dretch", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its bite and one with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Dretch", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "2",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 3,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Dretch", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "2",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 4,
                    HitDamageBonus = 0,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },    
                new OGL_Ability() { OGL_Creature = "Dretch", Title = "Fetic Cloud (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "A 10-foot radius of disgusting green gas extends out from the {CREATURENAME}. The gas spreads around corners, and its area is lightly obscured. It lasts for 1 minute or until a strong wind disperses it. Any creature that starts its turn in that area must succeed on a DC 11 Constitution saving throw or be poisoned until the start of its next turn. While poisoned in this way, the target can either take an action or a bonus action on its turn, not both, and can't take reactions."},      
            });

            // new OGL_Ability() { OGL_Creature = "Dretch", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Dretch",
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

            OGLContent.OGL_Creatures.Add("Dretch");
        }
    }
}
