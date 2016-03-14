using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Aboleth
    {
        static public void Add()
        {
            OGLContent.OGL_Abilities.Add(new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." });
            OGLContent.OGL_Abilities.Add(new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Mucous Cloud", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While underwater, the {CREATURENAME} is surrounded by a transformative mucus. A creature that touches the {CREATURENAME} while within 5 feet of it must make a DC 14 Constitution saving throw. On a failure, the creature is diseased for 1d4 hours. The diseased creature can breathe only underwater." });
            OGLContent.OGL_Abilities.Add(new OGL_Ability() { OGL_Creature = "Aboleth", Title = "Probing Telepath", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If a creature communicates telepathicall with the {CREATURENAME}, the {CREATURENAME} learns the creature's greatest desires if the {CREATURENAME} can see the creature." });

            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>() {
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
            });

            OGLContent.OGL_Legendary.Add(new OGL_Legendary()
            {
                OGL_Creature = "Aboleth",
                Title = "Aboleth Legendary Actions",
                Traits = new List<LegendaryTrait>() 
                {
                    new LegendaryTrait("Detect", "The {CREATURENAME} makes a Wisdom (Perception) check."),                    
                    new LegendaryTrait("Tail Swipe", "The {CREATURENAME} makes one tail attack."),                   
                    new LegendaryTrait("Psychic Drain (Costs 2 Actions)", "One creature charmed by the {CREATURENAME} takes 10 (3d6) psychic damage, and the {CREATURENAME} regains hit points equal to the damage the creature takes.")                    
                }
            });

            OGLContent.OGL_Creatures.Add("Aboleth");        
        }
    }
}
