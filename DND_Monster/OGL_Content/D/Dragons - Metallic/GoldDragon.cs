using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class GoldDragon
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
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                                
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "17",
                    Reach = 15,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 10,
                    HitAverageDamage = 21,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "17",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 10,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "17",
                    Reach = 20,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 10,
                    HitAverageDamage = 19,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice that is within 120 feet of the {CREATURENAME} and aware of it must succeed on a DC 24 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 90-foot cone. Each creature in the area must make a DC 24 Dexterity saving throw, taking 71 (13d10) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Weakening Breath.</b> The {CREATURENAME} exhales gas in a 90-foot cone. Each creature in that area must succeed on a DC 24 Strength saving throw or have disadvantage on Strength-based attack rolls, Strength checks, and Strength-based saving throws for 1 minute. A creature can repeat this saving throw at the end of each of its turns, ending the effect on a success.</p>"},      
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a humanoid or beast that has a challenge rating no higher than its own, or back into its true form. It reverts to its true form if it dies. Any equipment it is wearing or carrying is absorbed or borne by the new form (the {CREATURENAME}'s choice). </br> In a new form, the {CREATURENAME} retains its alignment, hit points, Hit Dice, ability to speak, proficiencies, Legendary Resistance, lair actions and Intelligence, Wisdom and, Charisma scores, as well as this action. Its statistics and capabilities are otherwise replaced by those of the new form, except any class features or legendary actions of that form."},      
            });

            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Gold Dragon",
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
                    OGL_Creature = "Ancient Gold Dragon",
                    Title = "Ancient Gold Dragon Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                        new LegendaryTrait("Tail Attack", "The {CREATURENAME} makes a tail attack."),
                        new LegendaryTrait("Wing Attack (Costs 2 Actions)", "The {CREATURENAME} beats its wings. Each creature within 15 feet of the {CREATURENAME} must succeed on a DC 25 Dexterity saving throw or take 17 (2d6 + 10) bludgeoning damage and be knocked prone. The {CREATURENAME} can then fly up to half its flying speed."),
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Ancient Gold Dragon");
        }

        private static void Adult()
        {
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                                
                new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Frightful Presence. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 10,
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
                new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 5,
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
                new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 15,
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
                new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Frightful Presence", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature of the {CREATURENAME}'s choice that is within 120 feet of the {CREATURENAME} and aware of it must succeed on a DC 21 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Frightful Presence for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 60-foot cone. Each creature in the area must make a DC 21 Dexterity saving throw, taking 66 (12d10) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Weakening Breath.</b> The {CREATURENAME} exhales gas in a 60-foot cone. Each creature in that area must succeed on a DC 21 Strength saving throw or have disadvantage on Strength-based attack rolls, Strength checks, and Strength-based saving throws for 1 minute. A creature can repeat this saving throw at the end of each of its turns, ending the effect on a success.</p>"},      
               new OGL_Ability() { OGL_Creature = "Adult Gold Dragon", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a humanoid or beast that has a challenge rating no higher than its own, or back into its true form. It reverts to its true form if it dies. Any equipment it is wearing or carrying is absorbed or borne by the new form (the {CREATURENAME}'s choice). </br> In a new form, the {CREATURENAME} retains its alignment, hit points, Hit Dice, ability to speak, proficiencies, Legendary Resistance, lair actions and Intelligence, Wisdom and, Charisma scores, as well as this action. Its statistics and capabilities are otherwise replaced by those of the new form, except any class features or legendary actions of that form."},      
            });

            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Gold Dragon",
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
                    OGL_Creature = "Adult Gold Dragon",
                    Title = "Adult Gold Dragon Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                        new LegendaryTrait("Tail Attack", "The {CREATURENAME} makes a tail attack."),
                        new LegendaryTrait("Wing Attack (Costs 2 Actions)", "The {CREATURENAME} beats its wings. Each creature within 15 feet of the {CREATURENAME} must succeed on a DC 20 Dexterity saving throw or take 14 (2d6 + 7) bludgeoning damage and be knocked prone. The {CREATURENAME} can then fly up to half its flying speed."),
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Adult Gold Dragon");
        }

        private static void Young()
        {
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                                
                new OGL_Ability() { OGL_Creature = "Young Gold Dragon", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Young Gold Dragon", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Young Gold Dragon", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
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
                new OGL_Ability() { OGL_Creature = "Young Gold Dragon", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
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
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 30-foot cone. Each creature in the area must make a DC 17 Dexterity saving throw, taking 55 (10d10) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Weakening Breath.</b> The {CREATURENAME} exhales gas in a 30-foot cone. Each creature in that area must succeed on a DC 17 Strength saving throw or have disadvantage on Strength-based attack rolls, Strength checks, and Strength-based saving throws for 1 minute. A creature can repeat this saving throw at the end of each of its turns, ending the effect on a success.</p>"},      
            });

            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Gold Dragon",
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

            OGLContent.OGL_Creatures.Add("Young Gold Dragon");
        }

        private static void Wyrmling()
        {
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Gold Dragon Wyrmling", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gold Dragon", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Gold Dragon Wyrmling", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 10,
                    HitDamageBonus = 4,
                    HitAverageDamage = 9,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },                             
                new OGL_Ability() { OGL_Creature = "Ancient Gold Dragon", Title = "Breath Weapons (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} uses one of the following breath weapons: " + 
                    "<p><b>Fire Breath.</b> The {CREATURENAME} exhales fire in a 15-foot cone. Each creature in the area must make a DC 13 Dexterity saving throw, taking 22 (4d10) fire damage on a failed save, or half as much damage on a saving throw. </p>" + 
                    "<p><b>Weakening Breath.</b> The {CREATURENAME} exhales gas in a 15-foot cone. Each creature in that area must succeed on a DC 13 Strength saving throw or have disadvantage on Strength-based attack rolls, Strength checks, and Strength-based saving throws for 1 minute. A creature can repeat this saving throw at the end of each of its turns, ending the effect on a success.</p>"},      
            });

            OGLContent.OGL_Creatures.Add("Gold Dragon Wyrmling");
        }
    }
}
