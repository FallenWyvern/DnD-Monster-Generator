using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Triceratops
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Triceratops", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Triceratops", Title = "Trampling Charge", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} moves at least 20 feet straight toward a creature and then hits it with a gore attack on the same turn, that target must succeed on a DC 13 Strength saving throw or be knocked prone. If the target is prone, the {CREATURENAME} can make one stomp attack against it as a bonus action." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Triceratops", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Triceratops", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Triceratops", Title = "Gore", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 8,
                    HitDamageBonus = 6,
                    HitAverageDamage = 24,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Triceratops", Title = "Stomp", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one prone creature",
                    HitDiceNumber = 3,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 22,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Triceratops", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Triceratops",
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

            OGLContent.OGL_Creatures.Add("Triceratops");
        }
    }
}
