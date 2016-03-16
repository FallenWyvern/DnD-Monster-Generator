using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class WaterElemental
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "Water Form", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}  can enter a hostile creature's space and stop there. It can move through a space as narrow as 1 inch wide without squeezing." },
                new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "Freeze", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} takes cold damage, it partially freezes; its speed is reduced by 20 feet until the end of its next turn." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two slam attacks."},      
                 new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "Slam", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 13,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "Whelm (Recharge 4-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature in the {CREATURENAME}'s space must make a DC 15 Strength saving throw. On a failure, a target takes 13 (2d8 + 4) bludgeoning damage. If it is Large or smaller, it is also grappled (escape DC 14). Until this grapple ends, the target is restrained and unable to breathe unless it also can breathe water. If the saving throw is successful, the target is pushed out of the {CREATURENAME}'s space. </br> The {CREATURENAME} can grapple one Large creature or up to two Medium or smaller creatures at one time. At the start of each of the {CREATURENAME}'s turns, each target grappled by it takes 13 (2d8 + 4) bludgeoning damage. A creature within 5 feet of the {CREATURENAME} can pull a creature or object out of it by taking an action to make a DC 14 Strength and succeeding."},      
            });

            // new OGL_Ability() { OGL_Creature = "Water Elemental", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Water Elemental",
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

            OGLContent.OGL_Creatures.Add("Water Elemental");
        }
    }
}
