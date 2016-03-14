using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Cloaker
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Cloaker", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Damage Transfer", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While attached to a creature, the {CREATURENAME} takes only half the damage dealt to it (rounded down), and that creature takes the other half." },
                new OGL_Ability() { OGL_Creature = "Cloaker", Title = "False Apperance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless without its underside exposed, it is indistinguishable from a dark leather cloak." },
                new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Light Sensitivity", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While in bright light, the {CREATURENAME} has disadvantage on attack rolls and Wisdom (Perception) checks that rely on sight." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Cloaker", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Cloaker", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitText = "plus this text",
            //    HitDamageType = "Acid"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its bite and one with its tail."},      
                 new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "and if the target is Large or smaller, the {CREATURENAME} attaches to it. If the {CREATURENAME} has advantage against the target, the {CREATURENAME} attaches to the target's head and the {CREATURENAME} is attached. While attached, the {CREATURENAME} can make this attack only against the target and has advantage on the attack roll. The {CREATURENAME} can detach itself by spending 5 feet of its movement. A creature, including the target, can take its action to detach the cloaker by succeeding on a DC 16 Strength check.",
                    HitDamageType = "Acid"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Moan", isDamage = false, isSpell = false, saveDC = 0, Description = "Each creature within 60 feet of the {CREATURENAME} that can hear its moan and that isn't an aberration must succeed on a DC 13 Wisdom saving throw or become frightened until the end of the {CREATURENAME}'s next turn. If a creature's saving throw is successful, the creature is immune to the cloaker's moan for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Cloaker", Title = "Phantasms (Recharges after a Short or Long Rest)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically creates three illusionary duplicates of itself if it isn't in bright light. The duplicates move with it and mimic its actions, shifting position so as to make it impossible to track which {CREATURENAME} is the real one. If the cloaker is ever in an area of bright light, the duplicates disappear. </br> Whenever any creature targets the {CREATURENAME} with an attack or a harmful spell while a duplicate remains, that creature rolls randomly to determine weather it targets the {CREATURENAME} or one of the duplicates. A creature is unaffected by this magical effect if it can't see or if it relies on senses other than sight. </br> A duplicate has the {CREATURENAME}'s AC and uses its saving throws. If an attack hits a duplicate, or if a duplicate fails a saving throw against an effect that deals damage, the duplicate disappears."},      
            });

            // new OGL_Ability() { OGL_Creature = "Cloaker", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Cloaker",
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

            OGLContent.OGL_Creatures.Add("Cloaker");
        }
    }
}
