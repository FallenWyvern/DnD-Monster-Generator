using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class ChainDevil
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks with its chains."},      
                 new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "Chain", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 11,
                    HitText = "The target is grappled (escape DC 14) if the {CREATURENAME} isn't already grappling a creature. Until this grapple ends, the target is restrained and takes 7 (2d6) piercing damage at the start of each of its turns.",
                    HitDamageType = "slashing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "Animate Chains (Recharges after a Short or Long Rest)", isDamage = false, isSpell = false, saveDC = 0, Description = "Up to four chains the {CREATURENAME} can see within 60 feet of it magically sprout razor-edged barbs and animate under the {CREATURENAME}'s control, provided that the chains aren't being worn or carried. </br> Each animated chain is an object with AC 20, 20 hit points, resistance to piercing damage and immunity to psychic and thunder damage. When the {CREATURENAME} uses Multiattack on its turn, it can use each animated chain to make one additional chain attack. An animated chain can grapple one creature of its own but can't make attacks while grappling. An animated chain reverts to its inanimate state if reduced to 0 hit points or if the {CREATURENAME} is incapacitated or dies."},      
            });

            // new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Chain Devil", Title = "Unnerving Mask", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When a creature the {CREATURENAME} can see starts its turn within 30 feet of the {CREATURENAME}, the {CREATURENAME} can create the illusion that it looks like one of the creature's departed loved ones or bitter enemies. If the creature can see the {CREATURENAME}, it must succeed on a DC 14 Wisdom saving throw or be frightened until the end of its turn." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Chain Devil",
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

            OGLContent.OGL_Creatures.Add("Chain Devil");
        }
    }
}
