using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Behir
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Behir", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Behir", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Behir", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Behir", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its bite and one to constrict."},      
                new OGL_Ability() { OGL_Creature = "Behir", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 22,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Behir", Title = "Constrict", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one Large or smaller creature.",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 17,
                    HitText = "plus 17 (2d10 + 6) slashing damage. The target is grappled (escape DC 16) if the {CREATURENAME} isn't already constricting a creature, and the target is restrained until this grapple ends.",
                    HitDamageType = "bludgeoning"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Behir", Title = "Lightning Breath (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales a line of lightning that is 20 feet long and 5 feet wide. Each creature in that line must make a DC 16 Dexterity saving throw, taking 66 (12d10) lightning damage on a failed save, or half as much damage on a successful one."},      
                new OGL_Ability() { OGL_Creature = "Behir", Title = "Swallow", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes one bite attack against a Medium or smaller target it is grappling. If the attack hits, the target is also swallowed, and the grapple ends. While swallowed, the target is blinded and restrained, it has total cover against attacks and other effects outside the {CREATURENAME}, and it takes 21 (6d6) acid damage at the start of each of the {CREATURENAME}'s turns. A {CREATURENAME} can have only one creature swallowed at a time. </br> If the {CREATURENAME} takes 30 damage or more on a single turn from the swallowed creature, the {CREATURENAME} must succeed on a DC 14 Constitution saving throw at the end of that turn or regurgitate the creature, which falls prone in a space within 10 feet of the {CREATURENAME}. If the {CREATURENAME} dies, a swallowed creature is no longer restrained by it and can escape from the corpse by using 15 feet of movement, exiting prone."},      
            });

            // new OGL_Ability() { OGL_Creature = "Behir", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Behir",
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

            OGLContent.OGL_Creatures.Add("Behir");
        }
    }
}
