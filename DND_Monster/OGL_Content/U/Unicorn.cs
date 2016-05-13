using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Unicorn
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Unicorn", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Charge", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} moves at least 20 feet straight towards a target and then hits it with a horn attack on the same turn, the target takes an extra 9 (2d8) piercing damage. If the target is a creature, it must succeed on a DC 15 Strength saving throw or be knocked prone." },
                new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 14, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect evil and good,0:druidcraft,0:pass without trace,1:calm emotions,1:dispel evil and good,1:entangle,|" },
                new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Unicorn", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Unicorn", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its hooves and one with its horn."},      
                 new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Hooves", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 11,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },                  
                 new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Horn", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 8,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Healing Touch (3/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} touches another creature with its horn. The target magically regains 11 (2d8 + 2) hit points. In addition, the touch removes all diseases and neutralizes all poisons affecting the target."},      
                 new OGL_Ability() { OGL_Creature = "Unicorn", Title = "Teleport (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "Teh {CREATURENAME} magically teleports itself and up to three willing creatures it can see within 5 feet of it, along with any equipment they are wearing or carryign, to a location the {CREATURENAME} is familiar with, up to 1 mile away."},      
            });

            // new OGL_Ability() { OGL_Creature = "Unicorn", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
                     
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Unicorn",
                    Title = "Unicorn Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Hooves", "The {CREATURENAME} makes one attack with its hooves."),
                        new LegendaryTrait("Shimmering Shield (Costs 2 Actions)", "The {CREATURENAME} creates a shimmering, magical field around itself or another creature it can see within 60 feet of it. The target gains a +2 bonus to AC until the end of the {CREATURENAME}'s next turn."),
                        new LegendaryTrait("Heal Self (Costs 3 Actions)", "The {CREATURENAME} magically regains 11 (2d8 + 2) hit points."),                  
                    }
                },   
            });

            OGLContent.OGL_Creatures.Add("Unicorn");
        }
    }
}
