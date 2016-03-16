using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class StoneGiant
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "Stone Camouflage", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on Dexterity (Stealth) checks made to hide in rocky terrain." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two greatclub attacks."},      
                 new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "Greatclub", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 15,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 8,
                    HitDamageBonus = 6,
                    HitAverageDamage = 19,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "Rock", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "9",
                    Reach = 0,
                    RangeClose = 60,
                    RangeFar = 240,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 28,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Stone Giant", Title = "Rock Catching", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If a rock or similar object is hurled at the {CREATURENAME}, the {CREATURENAME} can, with a successful DC 10 Dexterity saving throw, catch the missile and take no bludgeoning damage from it." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Stone Giant",
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

            OGLContent.OGL_Creatures.Add("Stone Giant");
        }
    }
}
