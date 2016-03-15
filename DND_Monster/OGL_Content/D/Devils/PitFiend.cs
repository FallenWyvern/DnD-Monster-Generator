using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class PitFiend
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Fear Aura", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Any creature hostile to the {CREATURENAME} that starts its turn within 20 feet of the {CREATURENAME} must make a DC 21 Wisdom saving throw, unless the {CREATURENAME} is incapacitated. On a failed save, the creature is frightened until the start of its next turn. If a creature's saving throw is successful, the creature is immune to the {CREATURENAME}'s Fear Aura for the next 24 hours." },
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:fireball,3:hold monster,3:wall of fire,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes four attacks: one with its bite, one with its claw, one with its mace, and one with its tail."},      
                 new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 6,
                    HitDamageBonus = 8,
                    HitAverageDamage = 22,
                    HitText = "The target must succeed on a DC 21 Constitution saving throw or become poisoned. While poisoned this way, the target can't regain hit points, and it takes 21 (6d6) poison damage at the start of each of its turns. The poisoned target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.",
                    HitDamageType = "piercing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 8,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Mace", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 8,
                    HitAverageDamage = 15,
                    HitText = "plus 21 (6d6) fire damage.",
                    HitDamageType = "bludgeoning"
                }
                },
                new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 10,
                    HitDamageBonus = 8,
                    HitAverageDamage = 24,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Pit Fiend", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Pit Fiend",
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

            OGLContent.OGL_Creatures.Add("Pit Fiend");
        }
    }
}
