using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Lemure
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Lemure", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Lemure", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Lemure", Title = "Hellish Rejuvenation", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "A {CREATURENAME} that dies in the Nine Hells comes back to life with all its hit points in 1d10 days unless it is specifically killed by a good-aligned creature with a <i>bless</i> spell cast on the creature or its remains are sprinkled with holy water." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Lemure", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Lemure", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Lemure", Title = "Fist", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 0,
                    HitAverageDamage = 2,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Lemure", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Lemure",
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

            OGLContent.OGL_Creatures.Add("Lemure");
        }
    }
}
