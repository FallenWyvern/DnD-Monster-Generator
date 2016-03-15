using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class FlyingSword
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "Antimagic Susceptibility", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is incapacitated while in the area of an <i>antimagic field</i>. If targetd by <i>dispel magic</i>, the {CREATURENAME} must succeed on a Constitution saving throw against the caster's spell save DC or fall unconscious for 1 minute." },
                new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "False Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from a normal sword." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "Longsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 1,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Flying Sword", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Flying Sword",
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

            OGLContent.OGL_Creatures.Add("Flying Sword");
        }
    }
}
