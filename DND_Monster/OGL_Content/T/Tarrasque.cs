using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Tarrasque
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
                new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Reflective Carapace", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Any time the {CREATURENAME} is targeted by a <i>magic missile</i> spell, a line spell, or a spell that requires a ranged attack roll, roll a d6. On a 1 to 5, th e{CREATURENAME} is unaffected. On a 6, the {CREATURENAME} is unaffected, and the effect is reflected back at the caster as though it originated from the {CREATURENAME}, turning the caster into the target." },
                new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Siege Monster", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} deals double damage to objects and structures." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes five attacks: one with its bite, two with its claws, one with its horns, and one with its tail. It can use its Swallow instead of bite."},      
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "19",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 12,
                    HitDamageBonus = 10,
                    HitAverageDamage = 36,
                    HitText = "If the target is a creature, it is grappled (escape DC 20). Until the grapple ends, the target is restrained, and the {CREATURENAME} can't bite another target.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "19",
                    Reach = 15,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 8,
                    HitDamageBonus = 10,
                    HitAverageDamage = 28,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Horns", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "19",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 10,
                    HitDamageBonus = 10,
                    HitAverageDamage = 32,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "19",
                    Reach = 20,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 6,
                    HitDamageBonus = 10,
                    HitAverageDamage = 24,
                    HitText = "If the target is a creature, it must succeed on a DC 20 Strength saving throw or be knocked prone.",
                    HitDamageType = "bludgeoning"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice within 120 feet of it and aware of it must succeed on a DC 17 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, with disadvantage if the {CREATURENAME} is within line of sight, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                 new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "Swallow", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes one bite attack against a Large or smaller target it is grappling. If the attack hits, the target takes the bite's damage, the target is swallowed, and the grapple ends. While swallowed, the creature is blinded and restrained, it has total cover against attacks and other effects outside the {CREATURENAME}, and it takes 56 (16d6) acid damage at the start of each of the {CREATURENAME}'s turns. </br> If the {CREATURENAME} takes 60 damage or more on a single turn from a creature inside it, the {CREATURENAME} must succeed on a DC 20 Constitution saving throw at the end of that turn or regurgitate all swallowed creatures, which fall prone in a space within 10 feet of the {CREATURENAME}. If the {CREATURENAME} dies, a swallowed creature is no longer restrained by it and can escape from the corpse by using 30 feet of movement, exiting prone."},      
            });

            // new OGL_Ability() { OGL_Creature = "Tarrasque", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Tarrasque",
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
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Tarrasque",
                    Title = "Tarrasque Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Attack", "The {CREATURENAME} makes one claw attack or tail attack."),
                        new LegendaryTrait("Move", "The {CREATURENAME} moves up to half its speed."),
                        new LegendaryTrait("Chomp (Costs 2 Actions)", "The {CREATURENAME} makes one bite attack or uses its Swallow."),                  
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Tarrasque");
        }
    }
}
