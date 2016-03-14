using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Bugbear
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Bugbear", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Bugbear", Title = "Brute", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "A melee weapon deals one extra die of its damage when the {CREATURENAME} hits with it (included in the attack)." },
                new OGL_Ability() { OGL_Creature = "Bugbear", Title = "Surprise Attack", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} surprises a creature and hits it with an attack during the first round of combat, the target takes an extra 7 (2d6) damage from the attack." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Bugbear", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            //new OGL_Ability() { OGL_Creature = "Bugbear", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Bugbear", Title = "Morningstar", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 2,
                    HitAverageDamage = 11,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Bugbear", Title = "Javelin", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee or Ranged Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 30,
                    RangeFar = 120,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 9,
                    HitText = "or 5 (1d6 + 2) piercing damage at range.",
                    HitDamageType = "piercing"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Bugbear", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Bugbear",
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

            OGLContent.OGL_Creatures.Add("Bugbear");
        }
    }
}
