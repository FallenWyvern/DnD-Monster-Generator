using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class Remorhaz
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "Heated Body", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "A creature that touches the {CREATURENAME} or hits it with a melee attack while within 5 feet of it takes 10 (3d6) fire damage." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "11",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 6,
                    HitDiceSize = 10,
                    HitDamageBonus = 7,
                    HitAverageDamage = 40,
                    HitText = "plus 10 (3d6) fire damage. If the target is a creature, it is grappled (escape DC 17). Until this grapple ends, the target is restrained, and the {CREATURENAME} can't bite another target.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "Swallow", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes one bite attack against a Medium or smaller creature it is grappling. If the attack hits, that creature takes the bite's damage and is swallowed, and the grapple ends. While swallowed, the creature is blinded and restrained, it has total cover against attacks and other effects outside the {CREATURENAME}, and it takes 21 (6d6) acid damage at the start of each of the {CREATURENAME}'s turns. </br> If the {CREATURENAME} takes 30 damage or more on a single turn from a creature inside it, the {CREATURENAME} must succeed on a DC 15 Constitution saving throw at the end of that turn or regurgitate all swallowed creatures, which fall prone in a space within 10 feet of the {CREATURENAME}. If the {CREATURENAME} dies, a swallowed creature is no longer restrained by it and can escape from the corpse using 15 feet of movement, exiting prone."},      
            });

            // new OGL_Ability() { OGL_Creature = "Remorhaz", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Remorhaz",
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

            OGLContent.OGL_Creatures.Add("Remorhaz");
        }
    }
}
