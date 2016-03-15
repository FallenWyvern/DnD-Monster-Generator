using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class IceDevil
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three attacks: one with its bite, one with its claws, and one with its tail."},      
                 new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 5,
                    HitAverageDamage = 12,
                    HitText = "plus 10 (3d6) cold damage.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 4,
                    HitDamageBonus = 5,
                    HitAverageDamage = 10,
                    HitText = "plus 10 (3d6) cold damage.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 5,
                    HitAverageDamage = 12,
                    HitText = "plus 10 (3d6) cold damage.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "Wall of Ice (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically forms an opaque wall of ice on a solid surface it can see within 60 feet of it. The wall is 1 foot thick and up to 30 feet long and 10 feet high, or it's a hemispherical dome up to 20 feet in diameter. </br> When the wall appears, each creature in its space is pushed out of it by the shortest route. The creature chooses which side of the wall to end up on, unless the creature is incapacitated. The creature then makes a DC 17 Dexterity saving throw, taking 35 (10d6) cold damage on a failed save, or half as much damage on a successful one. </br> The wall lasts for 1 minute or until the devil is incapacitated or dies. The wall can be damaged and breached; each 10-foot section has AC 5, 30 hit points, vulnerability to fire damage, and immunity to acid, cold, necrotic, poison, and psychic damage. If a section is destroyed, it leaves behind a sheet of frigid air in the space the wall occupied. Whenever a creature finishes moving through the frigid air on a turn, willing or otherwise, the creature must make a DC 17 Constitution saving throw, taking 17 (5d6) cold damage on a failed save, or half as much damage on a successful one. The frigid air dissipates when the rest of the wall vanishes."},      
            });

            // new OGL_Ability() { OGL_Creature = "Ice Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Ice Devil",
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

            OGLContent.OGL_Creatures.Add("Ice Devil");
        }
    }
}
