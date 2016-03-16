using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Duergar
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Duergar", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Duergar", Title = "Duergar Resilience", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
                new OGL_Ability() { OGL_Creature = "Duergar", Title = "Sunlight Sensitivity", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Duergar", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Duergar", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Duergar", Title = "Enlarge (Recharges after a Short or Long Rest)", isDamage = false, isSpell = false, saveDC = 0, Description = "For 1 minute, the {CREATURENAME} magically increases in size, along with anything it is wearing or carrying. While enlarged, the {CREATURENAME} is Large, doubles its damage dice on Strength-based weapon attacks (included in the attacks), and makes Strength checks and Strength saving throws with advantage. If the {CREATURENAME} lackst he room to become Large, it attains the maximum size possible in the space available."},      
                new OGL_Ability() { OGL_Creature = "Duergar", Title = "War Pick", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "or 11 (2d8 + 2) piercing damage while enlarged.",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Duergar", Title = "Javelin", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee or Ranged Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 30,
                    RangeFar = 120,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 5,
                    HitText = "or 9 (2d6 + 2) piercing damage while enlarged.",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Duergar", Title = "Invisibility (Recharges after a Short or Long Rest)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically turns invisible until it attacks, casts a spell, uses its Enlarge or until concentration is broken, up to 1 hour (as if concentrating on a spell). Any equipment the {CREATURENAME} wears or carries is invisible as well."},      
            });

            // new OGL_Ability() { OGL_Creature = "Duergar", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Duergar",
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

            OGLContent.OGL_Creatures.Add("Duergar");
        }
    }
}
