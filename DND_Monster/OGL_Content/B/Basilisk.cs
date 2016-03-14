using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Basilisk
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Basilisk", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Basilisk", Title = "Petrifying Gaze", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If a creature starts its turn within 30 feet of the {CREATURENAME} and the two of them can see each other, the {CREATURENAME} can force the creature to make a DC 12 Constitution saving throw if the {CREATURENAME} isn't incapacitated. On a failed save, the creature magically begins to turn to stone and is restrained. It must repeat the saving throw at the end of its next turn. On a success, the effect ends. On a failure, the creature is petrified until freed by the <i>greater restoration</i> spell or other magic. </br> A creature that isn't surprised can avert its eyes to avoid the saving throw at the start of its turn. If it does so, it can't see the {CREATURENAME} until the start of its next turn, when it can avert its eyes again. If it looks at the {CREATURENAME} in the meantime, it must immediately make the save. </br> If the {CREATURENAME} sees its reflection within 30 " },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Basilisk", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Basilisk", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Basilisk", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "plus 7 (2d6) poison damage.",
                    HitDamageType = "piercing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Basilisk", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Basilisk",
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

            OGLContent.OGL_Creatures.Add("Basilisk");
        }
    }
}
