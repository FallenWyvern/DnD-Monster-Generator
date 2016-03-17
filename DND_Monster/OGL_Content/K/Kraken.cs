using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Kraken
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
                new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
                new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "Acid"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Tentacle", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "Acid"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Fling", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Lightning Storm", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            });

            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Kraken",
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

            OGLContent.OGL_Creatures.Add("Kraken");
        }
    }
}
