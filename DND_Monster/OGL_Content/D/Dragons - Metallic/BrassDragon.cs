using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class BrassDragon
    {
        public static void Add(DragonAge age)
        {
            switch (age)
            {
                case DragonAge.Ancient:
                    Ancient();
                    break;
                case DragonAge.Adult:
                    Adult();
                    break;
                case DragonAge.Young:
                    Young();
                    break;
                case DragonAge.Wyrmling:
                    Wyrmling();
                    break;
            }
        }

        private static void Ancient()
        {
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                                
                new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitDamageType = "fire"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 15,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 8,
                    HitAverageDamage = 19,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "",
                    HitDamageType = "slashing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 20,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 8,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice that is within 120 feet of the {CREATURENAME} and aware of it must succeed on a DC 18 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 90-foot cone. Each creature in the area must make a DC 21 Dexterity saving throw, taking 56 (16d6) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Sleep Breath.</b> The {CREATURENAME} exhales sleep gas in a 90-foot cone. Each creature in that area must succeed on a DC 21 Consitution saving throw or fall unconscious for 10 minutes. This effect ends for a creature if the creature takes damage or someone uses an action to wake it.</p>"},      
                new OGL_Ability() { OGL_Creature = "Ancient Brass Dragon", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a humanoid or beast that has a challenge rating no higher than its own, or back into its true form. It reverts to its true form if it dies. Any equipment it is wearing or carrying is absorbed or borne by the new form (the {CREATURENAME}'s choice). </br> In a new form, the {CREATURENAME} retains its alignment, hit points, Hit Dice, ability to speak, proficiencies, Legendary Resistance, lair actions and Intelligence, Wisdom and, Charisma scores, as well as this action. Its statistics and capabilities are otherwise replaced by those of the new form, except any class features or legendary actions of that form."},      
            });

            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Brass Dragon",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")                    
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Ancient Brass Dragon",
                    Title = "Ancient Brass Dragon Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                        new LegendaryTrait("Tail Attack", "The {CREATURENAME} makes a tail attack."),
                        new LegendaryTrait("Wing Attack (Costs 2 Actions)", "The {CREATURENAME} beats its wings. Each creature within 15 feet of the {CREATURENAME} must succeed on a DC 22 Dexterity saving throw or take 15 (2d6 + 8) bludgeoning damage and be knocked prone. The {CREATURENAME} can then fly up to half its flying speed."),
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Ancient Brass Dragon");
        }

        private static void Adult()
        {
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                                
                new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitDamageType = "fire"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "11",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "11",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 6,
                    HitAverageDamage = 13,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "11",
                    Reach = 15,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 6,
                    HitAverageDamage = 15,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice that is within 120 feet of the {CREATURENAME} and aware of it must succeed on a DC 16 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Adult Brass Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 60-foot cone. Each creature in the area must make a DC 18 Dexterity saving throw, taking 45 (13d6) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Sleep Breath.</b> The {CREATURENAME} exhales sleep gas in a 60-foot cone. Each creature in that area must succeed on a DC 18 Consitution saving throw or fall unconscious for 10 minutes. This effect ends for a creature if the creature takes damage or someone uses an action to wake it.</p>"},                      
            });

            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Brass Dragon",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")                    
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Adult Brass Dragon",
                    Title = "Adult Brass Dragon Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                        new LegendaryTrait("Tail Attack", "The {CREATURENAME} makes a tail attack."),
                        new LegendaryTrait("Wing Attack (Costs 2 Actions)", "The {CREATURENAME} beats its wings. Each creature within 15 feet of the {CREATURENAME} must succeed on a DC 19 Dexterity saving throw or take 13 (2d6 + 6) bludgeoning damage and be knocked prone. The {CREATURENAME} can then fly up to half its flying speed."),
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Adult Brass Dragon");
        }

        private static void Young()
        {
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                                                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitDamageType = "fire"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Young Brass Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Young Brass Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 4,
                    HitAverageDamage = 15,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Young Brass Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitDamageType = "slashing"
                }
                },                                 
                new OGL_Ability() { OGL_Creature = "Young Brass Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 30-foot cone. Each creature in the area must make a DC 14 Dexterity saving throw, taking 42 (12d6) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Sleep Breath.</b> The {CREATURENAME} exhales sleep gas in a 30-foot cone. Each creature in that area must succeed on a DC 14 Consitution saving throw or fall unconscious for 5 minutes. This effect ends for a creature if the creature takes damage or someone uses an action to wake it.</p>"},                      
            });

            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            OGLContent.OGL_Creatures.Add("Young Brass Dragon");
        }

        private static void Wyrmling()
        {
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Brass Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitDamageType = "fire"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {                 
                 new OGL_Ability() { OGL_Creature = "Brass Dragon Wyrmling", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 10,
                    HitDamageBonus = 2,
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },                             
                new OGL_Ability() { OGL_Creature = "Young Brass Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 15-foot cone. Each creature in the area must make a DC 14 Dexterity saving throw, taking 14 (4d6) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Sleep Breath.</b> The {CREATURENAME} exhales sleep gas in a 15-foot cone. Each creature in that area must succeed on a DC 11 Consitution saving throw or fall unconscious for 1 minutes. This effect ends for a creature if the creature takes damage or someone uses an action to wake it.</p>"},                      
            });

            OGLContent.OGL_Creatures.Add("Brass Dragon Wyrmling");
        }
    }
}
