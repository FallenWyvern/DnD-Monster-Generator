using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Azer
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Azer", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Azer", Title = "Heated Body", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "A creature that touches the {CREATURENAME} or hits it with a melee attack while within 5 feet of it takes 5 (1d10) fire damage." },
                new OGL_Ability() { OGL_Creature = "Azer", Title = "Heated Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When the {CREATURENAME} hits with a metal melee weapon, it deals an extra 3 (1d6) fire damage (included in the attack)." },
                new OGL_Ability() { OGL_Creature = "Azer", Title = "Illumination", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} sheds bright light in a 10-foot radius and dim light for an additional 10 feet." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Azer", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Azer", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Azer", Title = "Warhammer", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "or 8 (1d10 + 3) bludgeoning damage if used with two hands to make a melee attack, plus 3 (1d6) fire damage.",
                    HitDamageType = "bludgeoning"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Azer", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Azer",
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

            OGLContent.OGL_Creatures.Add("Azer");
        }
    }
}