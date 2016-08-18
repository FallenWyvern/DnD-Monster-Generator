using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class VampireSpawn
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                
                new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Regeneration", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} regains 20 hit points at the start of its turn if it has at least 1 hit point and isn't in sunlight or running water. If the {CREATURENAME} takes radiant damage or damage from holy water, this trait doesn't function at the start of the {CREATURENAME}'s next turn." },
                new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check." },
                new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Vampire Weaknesses", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has the following flaws:</br><i>Forbiddance.</i> The {CREATURENAME} can't enter a residence without an invitation from one of the occupants.</br><i>Harmed by Running Water.</i> The {CREATURENAME} takes 20 acid damage if it ends its turn in running water.</br><i>Stake to the Heart.</i> If a piercing weapon made of wood is driven into the {CREATURENAME}'s heart while the { CREATURENAME} is incapacitated in its resting place, the { CREATURENAME} is paralyzed until the stake is removed.</ br >< i > Sunlight Hypersensitivity.</ i > The { CREATURENAME} takes 20 radiant damage when it starts its turn in sunlight.While in sunlight, it has disadvantage on attack rolls and ability checks." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = ""},
                 new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                {
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one creature",
                    HitDiceNumber = 2,
                    HitDiceSize = 4,
                    HitDamageBonus = 3,
                    HitAverageDamage = 8,
                    HitText = "Instead of dealing damage, the {CREATURENAME} can grapple the target (escape DC 13).",
                    HitDamageType = "slashing"
                }
                },
                  new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                {
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one willing creature, or a creature that is grappled by the {CREATURENAME}, incapacitated or restrained.",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 6,
                    HitText = "plus 7 (2d6) necrotic damage. The target's hit point maximum is reduced by an amount equal to the necrotic damage taken, and the {CREATURENAME} regains hit points equal to that amount. The reduction lasts until the target finishes a long rest. The target dies if this effect reduces its hit point maximum to 0.",
                    HitDamageType = "piercing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Vampire Spawn", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Vampire Spawn",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Vampire Spawn");
        }
    }
}
