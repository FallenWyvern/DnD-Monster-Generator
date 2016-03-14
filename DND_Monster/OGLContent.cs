using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class OGLContent
    {
        public static List<OGL_Ability> OGL_Abilities = new List<OGL_Ability>()
        {
            new OGL_Ability() { OGL_Creature = "", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },

            // Aboleth
            #region            
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Mucous Cloud", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While underwater, the {CREATURENAME} is surrounded by a transformative mucus. A creature that touches the {CREATURENAME} while within 5 feet of it must make a DC 14 Constitution saving throw. On a failure, the creature is diseased for 1d4 hours. The diseased creature can breathe only underwater." },
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Probing Telepath", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If a creature communicates telepathicall with the {CREATURENAME}, the {CREATURENAME} learns the creature's greatest desires if the {CREATURENAME} can see the creature." },            
            #endregion

            // Deva
            #region
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Angelic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical. When the {CREATURENAME} hits with any weapon, the weapon deals an extra 4d8 radiant damage (included in the attack)." },
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect good and evil,1:commune,1:raise dead,|" },
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            #endregion
        };

        public static List<OGL_Ability> OGL_Actions = new List<OGL_Ability>()
        {     
            // template
            #region
            new OGL_Ability() { OGL_Creature = "", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            new OGL_Ability() { OGL_Creature = "", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
            { 
                _Attack = "Melee Weapon Attack",
                Bonus = "1",
                Reach = 5,
                RangeClose = 10,
                RangeFar = 15,
                Target = "one target",
                HitDiceNumber = 2,
                HitDiceSize = 6,
                HitDamageBonus = 3,
                HitAverageDamage = 10,
                HitText = "plus this text",
                HitDamageType = "Acid"
            }
            },  
            #endregion

            // Aboleth
            #region  
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three tentacle attacks."},      
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Tentacle", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()             
            { 
                _Attack = "Melee Weapon Attack",
                Bonus = "9",
                Reach = 10,
                RangeClose = 0,
                RangeFar = 0,
                Target = "one target",
                HitDiceNumber = 2,
                HitDiceSize = 6,
                HitDamageBonus = 5,
                HitAverageDamage = 12,
                HitText = "If the target is a creature, it must succeed on a DC 14 Constitution saving throw or become diseased. The disease has no effect for 1 minute and can be removed by any magic that cures disease. After 1 minute, the diseased creature's skin becomes translucent and slimy, the creature can't regain hit points unless it is underwater, and the disease can only be removed by <i>heal</i> or another disease curing spell of 6th level or higher. When the creature is outside a body of water, it takes 6 (1d12) acid damage every 10 minutes unless moisture is applied to the skin before 10 minutes have passed.",
                HitDamageType = "bludgeoning"
            }
            },
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()             
            { 
                _Attack = "Melee Weapon Attack",
                Bonus = "9",
                Reach = 10,
                RangeClose = 0,
                RangeFar = 0,
                Target = "one target",
                HitDiceNumber = 3,
                HitDiceSize = 6,
                HitDamageBonus = 5,
                HitAverageDamage = 15,
                HitText = "",
                HitDamageType = "bludgeoning"
            }
            },
            new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Enslave (3/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} targets one creature it can see within 30 feet of it. The target must succeed on a DC 14 Wisdom saving throw or be magically charmed by the {CREATURENAME} until the {CREATURENAME} dies or until it is on a different plane of existence from the target. The charmed target is under the {CREATURENAME}'s control and can't take reactions, and the {CREATURENAME} and the target can communicated telepathically with each other over any distance. </br> Whenever the charmed target takes damage, the target can repeat the saving throw. On a success, the effect ends. No more than once every 24 hours, the target can also repeat the saving throw when it is at least 1 mile away from the {CREATURENAME}." },
            #endregion

            // Deva
            #region
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two melee attacks."},      
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Mace", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
            { 
                _Attack = "Melee Weapon Attack",
                Bonus = "8",
                Reach = 5,
                RangeClose = 0,
                RangeFar = 0,
                Target = "one target",
                HitDiceNumber = 1,
                HitDiceSize = 6,
                HitDamageBonus = 4,
                HitAverageDamage = 7,
                HitText = "plus 18 (4d8) radiant damage.",
                HitDamageType = "bludgeoning"
            }
            }, 
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Healing Touch (3/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} touches another creature. The target magically regains 20 (4d8+2) hit points and is freed from any curse, disease, poison, blindness, or deafness."},      
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a humanoid or beast with a challenge rating equal to or less than its own, or back into its true form. It reverts to its true form if it dies. Any equipment it is wearing or carrying is absorbed or borne by the new form (the {CREATURENAME}'s choice). </br> In a new form, the {CREATURENAME} retains its game statistics and the ability to speak, but its AC, movement modes, Strength, Dexterity, and special senses are replaced by those of the new form, and it gains any statistics and capabilities (except class features, legendary actions, and lair actions) that the new form has but that it lacks."},      
            #endregion
        };

        public static List<OGL_Ability> OGL_Reactions = new List<OGL_Ability>()
        {
            new OGL_Ability() { Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         

            // Aboleth
            #region
            #endregion

            // Deva
            #region
            #endregion
        };

        public static List<OGL_Legendary> OGL_Legendary = new List<OGL_Legendary>()
        {      
            // Template
            #region
            new OGL_Legendary() 
            { 
                OGL_Creature = "",
                Title = "",
                Traits = new List<LegendaryTrait>() 
                {
                    new LegendaryTrait("", "")                    
                }
            },            
            #endregion
           
            // Aboleth
            #region
            new OGL_Legendary() 
            { 
                OGL_Creature = "Aboleth",
                Title = "Aboleth Legendary Actions",
                Traits = new List<LegendaryTrait>() 
                {
                    new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                    new LegendaryTrait("Tail Swipe", "The {CREATURENAME} makes one tail attack."),                   
                    new LegendaryTrait("Psychic Drain (Costs 2 Actions)", "One creature charmed by the {CREATURENAME} takes 10 (3d6) psychic damage, and the {CREATURENAME} regains hit points equal to the damage the creature takes.")                    
                }
            }
            #endregion

            // Deva
            #region
            #endregion
        };
    }
}
