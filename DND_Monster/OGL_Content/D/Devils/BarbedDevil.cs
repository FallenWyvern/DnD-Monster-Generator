using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class BarbedDevil
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Barbed Hide", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "At the start of each of its turns, the {CREATURENAME} deals 5 (1d10) piercing damage to any creature grappling it." },
                new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three melee attacks: one with its tail and two with its claws. Alternatively it can use Hurl Flame twice."},      
                 new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 6,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "Hurl Flame", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Spell Attack",
                    Bonus = "5",
                    Reach = 0,
                    RangeClose = 150,
                    RangeFar = 150,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 10,
                    HitText = "If the target is a flammable object that isn't being worn or carried, it also catches fire.",
                    HitDamageType = "fire"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Barbed Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Barbed Devil",
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

            OGLContent.OGL_Creatures.Add("Barbed Devil");
        }
    }
}
