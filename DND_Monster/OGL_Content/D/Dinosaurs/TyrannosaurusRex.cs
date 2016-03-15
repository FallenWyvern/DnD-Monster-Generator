using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class TyrannosaurusRex
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its bite and one with its tail. It can't make both attacks against the same target."},      
                 new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 12,
                    HitDamageBonus = 7,
                    HitAverageDamage = 33,
                    HitText = "If the target is a Medium or smaller creature, it is grappled (escape DC 17). Until this grapple ends, the target is restrained and the {CREATURENAME} can't bite another target.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 8,
                    HitDamageBonus = 7,
                    HitAverageDamage = 20,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Tyrannosaurus Rex", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Tyrannosaurus Rex",
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

            OGLContent.OGL_Creatures.Add("Tyrannosaurus	Rex");
        }
    }
}
