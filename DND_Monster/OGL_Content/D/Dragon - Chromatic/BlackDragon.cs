using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class BlackDragon
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
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "15",
                    Reach = 15,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 8,
                    HitAverageDamage = 19,
                    HitText = "plus 9 (2d8) acid damage.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "15",
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
                new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "15",
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
                new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice that is within 120 feet of the {CREATURENAME} and aware of it must succeed on a DC 19 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Ancient Black Dragon", Title = "Acid Breath (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales acid in a 90-foot line that is 10 feet wide. Each creature in that line must make a DC 22 Dexterity saving throw, taking 67 (15d8) acid damage on a failed save, or half as much damage on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Black Dragon",
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
                    OGL_Creature = "Ancient Black Dragon",
                    Title = "Ancient Black Dragon Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                        new LegendaryTrait("Tail Attack", "The {CREATURENAME} makes a tail attack."),
                        new LegendaryTrait("Wing Attack (Costs 2 Actions)", "The {CREATURENAME} beats its wings. Each creature within 15 feet of the {CREATURENAME} must succeed on a DC 23 Dexterity saving throw or take 15 (2d6 + 8) bludgeoning damage and be knocked prone. The {CREATURENAME} can then fly up to half its flying speed."),
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Ancient Black Dragon");
        }

        private static void Adult()
        {
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "plus 4 (1d8) acid damage.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "11",
                    Reach = 10,
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
                new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice that is within 120 feet of the {CREATURENAME} and aware of it must succeed on a DC 19 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Adult Black Dragon", Title = "Acid Breath (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales acid in a 60-foot line that is 5 feet wide. Each creature in that line must make a DC 18 Dexterity saving throw, taking 54 (12d8) acid damage on a failed save, or half as much damage on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Black Dragon",
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
                    OGL_Creature = "Adult Black Dragon",
                    Title = "Adult Black Dragon Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                        new LegendaryTrait("Tail Attack", "The {CREATURENAME} makes a tail attack."),
                        new LegendaryTrait("Wing Attack (Costs 2 Actions)", "The {CREATURENAME} beats its wings. Each creature within 15 feet of the {CREATURENAME} must succeed on a DC 19 Dexterity saving throw or take 13 (2d6 + 6) bludgeoning damage and be knocked prone. The {CREATURENAME} can then fly up to half its flying speed."),
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Adult Black Dragon");
        }

        private static void Young()
        {
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Young Black Dragon", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Young Black Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Young Black Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "plus 4 (1d8) acid damage.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Young Black Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Young Black Dragon", Title = "Acid Breath (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales acid in a 30-foot line that is 5 feet wide. Each creature in that line must make a DC 14 Dexterity saving throw, taking 49 (11d8) acid damage on a failed save, or half as much damage on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Black Dragon",
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

            OGLContent.OGL_Creatures.Add("Young Black Dragon");
        }

        private static void Wyrmling()
        {
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Black Dragon Wyrmling", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Black Dragon Wyrmling", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 10,
                    HitDamageBonus = 2,
                    HitAverageDamage = 7,
                    HitText = "plus 4 (1d8) acid damage.",
                    HitDamageType = "piercing"
                }
                },                    
                new OGL_Ability() { OGL_Creature = "Black Dragon Wyrmling", Title = "Acid Breath (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales acid in a 15-foot line that is 5 feet wide. Each creature in that line must make a DC 11 Dexterity saving throw, taking 22 (5d8) acid damage on a failed save, or half as much damage on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Black Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Black Dragon",
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

            OGLContent.OGL_Creatures.Add("Black Dragon Wyrmling");
        }
    }
}
