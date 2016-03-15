using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Darkmantle
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "Echolocation", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can't use its blindsight while deafened." },
                new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "False Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from a cave formation such as a stalactite or stalagmite." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "Crush", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 6,
                    HitText = "and the {CREATURENAME} attaches to the target. If the target is Medium or smaller and the {CREATURENAME} has advantage on the attack roll, it attaches by engulfing the target's head, and the target is also blind and unable to breathe while the {CREATURENAME} is attached in this way. </br> While attached to the target, the {CREATURENAME} can attack no other creature except the target but has advantage on its attack rolls. The {CREATURENAME}'s speed also becomes 0, it can't benefit from any bonus to its speed, and it moves with the target. </br> A creature can detach the {CREATURENAME} by making a successful DC 13 Strength check as an action. On its turn, the {CREATURENAME} can detach itself from the target using 5 feet of movement.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "Darkness Aura (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "A 15-foot radius of magical darkness extends out from the {CREATURENAME}, moves with it, and spreads around corners. The darkness lasts as long as the {CREATURENAME} maintains concentration, up to 10 minutes (as if concentrating on a spell). Darkvision can't penetrate this darkness, and no natural light can illuminate it. If any of hte darkness overlaps with an area of light creatred by a spell of 2nd level or lower, the spell creating the light is dispelled."},      
            });

            // new OGL_Ability() { OGL_Creature = "Darkmantle", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Darkmantle",
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

            OGLContent.OGL_Creatures.Add("Darkmantle");
        }
    }
}
