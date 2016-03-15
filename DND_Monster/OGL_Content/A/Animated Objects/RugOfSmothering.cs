using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class RugOfSmothering
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "Antimagic Susceptibility", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is incapacitated while in the area of an <i>antimagic field</i>. If targetd by <i>dispel magic</i>, the {CREATURENAME} must succeed on a Constitution saving throw against the caster's spell save DC or fall unconscious for 1 minute." },
                new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "Damage Transfer", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While it is grappling a creature, the {CREATURENAME} takes only half the damage dealt to it, and the creature grappled by the {CREATURENAME} takes the other half."},
                new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "False Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from a normal rug." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
            //{ 
            //    _Attack = "Melee Weapon Attack",
            //    Bonus = "1",
            //    Reach = 5,
            //    RangeClose = 10,
            //    RangeFar = 15,
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
                new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "Smother", isDamage = false, isSpell = false, saveDC = 0, Description = "<i>Melee Weapon Attack</i>: +5 to hit, reach 5ft., one Medium or smaller creature. <i>Hit</i>: The creature is grappled (escape DC 13). Until this grapple ends, the target is restrained, blinded, and at risk of suffocating, and the rug can't smother another target. In addition, at the start of each of the target's turns, the target takes 10 (2d6 + 3) bludgeoning damage."},                      
            });

            // new OGL_Ability() { OGL_Creature = "Rug Of Smothering", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Rug Of Smothering",
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

            OGLContent.OGL_Creatures.Add("Rug Of Smothering");
        }
    }
}
