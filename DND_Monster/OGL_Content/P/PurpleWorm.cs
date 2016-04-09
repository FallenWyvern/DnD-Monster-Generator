using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class PurpleWorm
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "Tunneler", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can burrow through solid rock at half its burrow speed and leaves a 10-foot-diameter tunnel in its wake." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one it its bite and one with its stinger."},      
                 new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 8,
                    HitDamageBonus = 9,
                    HitAverageDamage = 22,
                    HitText = "If the target is a Large or smaller creature, it must succeed on a DC 19 Dexterity saving throw or be swallowed by the {CREATURENAME}. A swallowed creature is blinded and restrained, it has total cover against attacks and other effects outside the {CREATURENAME}, and it takes 21 (6d6) acid damage at the start of each of the {CREATURENAME}'s turns. </br> If the {CREATURENAME} takes 30 or more damage on a single turn from a creature inside it, the {CREATURENAME} must succeed on DC 21 Constitution saving throw at the end of that turn or regurgitate all the swallowed creatures, which fall prone in a space within 10 feet of the {CREATURENAME}. If the {CREATURENAME} dies, a swallowed creature is no longer restrained by it and can escape from the corpse by using 20 feet of movement, exiting prone.",
                    HitDamageType = "piercing"
                }
                },
                 new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "Tail Stinger", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 8,
                    HitAverageDamage = 19,
                    HitText = "and the target must make a DC 19 Constitution saving throw, taking 42 (12d6) poison damage on a failed save, or half as much on a successful one.",
                    HitDamageType = "piercing"
                }
                },
                
            });

            // new OGL_Ability() { OGL_Creature = "Purple Worm", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Purple Worm",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")  
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Purple Worm");
        }
    }
}
