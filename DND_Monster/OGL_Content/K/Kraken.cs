using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Kraken
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Kraken", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Kraken", Title = "Freedom of Movement", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} ignores difficult terrain, and magical effects can't reduce its speed or cause it to be restrained. It can spend 5 feet of movement to escape from nonmagical restraints or being grappled." },
                new OGL_Ability() { OGL_Creature = "Kraken", Title = "Siege Monster", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} deals double damage to objects and structures." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three tentacle attacks, each of which can be replaced with one use of Fling."},      
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "17",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 8,
                    HitDamageBonus = 10,
                    HitAverageDamage = 23,
                    HitText = "If the target is a Large or smaller creature grappled by the {CREATURENAME}, that creature is swallowed, and the grapple ends. While swallowed, the creature is blinded and restrained, it has total cover against attacks and other effects outside the {CREATURENAME}, and it takes 42 (12d6) acid damage at the start of each of the {CREATURENAME}'s turns. </br> If the {CREATURENAME} takes 50 damage or more on a single turn from the creature inside it, the {CREATURENAME} must succeed on a DC 25 Constitution saving throw at the end of that turn or regurgitate all swallowed creatures, which fall prone in a space within 10 feet of the {CREATURENAME}. If the {CREATURENAME} dies, a swallowed creature is no longer restrained by it and can escape from the corpse using 15 feet of movement, exiting prone.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Tentacle", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "17",
                    Reach = 30,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 10,
                    HitAverageDamage = 20,
                    HitText = "and the target is grappled (escape DC 18). Until this grapple ends, the target is restrained. The {CREATURENAME} has ten tentacles, each of which can grapple one target.",
                    HitDamageType = "bludgeoning"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Fling", isDamage = false, isSpell = false, saveDC = 0, Description = "One Large or smaller object held or creature grappled by the {CREATURENAME} is thrown up to 60 feet in a random direction and knocked prone. If a thrown target strikes a solid surface, the target takes 3 (1d6) bludgeoning damage for every 10 feet it was thrown. If the target is thrown at another creature, that creature must succeed on a DC 18 Dexterity saving throw or take the same damage and be knocked prone."},      
                 new OGL_Ability() { OGL_Creature = "Kraken", Title = "Lightning Storm", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically creates three bolts of lightning, each of which can strike a target the {CREATURENAME} can see within 120 feet of it. A target must make a DC 23 Dexterity saving throw, taking 22 (4d10) lightning damage on a failed save, or half as much on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Kraken", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Kraken",
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
                    OGL_Creature = "Kraken",
                    Title = "Kraken Legendary Abilities",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Tentacle Attack or Fling", "The {CREATURENAME} makes one tentacle attack or uses its Fling"),
                        new LegendaryTrait("Lightning Storm (Costs 2 Actions)", "The {CREATURENAME} uses Lightning Storm"),
                        new LegendaryTrait("Ink Cloud (Costs 3 Actions)", "While underwater, the {CREATURENAME} expels an ink cloud in a 60-foot radius. The cloud spreads around corners, and the area is heavily obscured to creatures other than the {CREATURENAME}. Each creature other than the {CREATURENAME} that ends its turn there must succeed on a DC 23 Constitution saving throw, taking 16 (3d10) poison damage on a failed save, or half as much damage on a successful one. A strong current disperses the cloud, which otherwise disappears at the end of the {CREATURENAME}'s next turn."),

                    }
                },  
            });

            OGLContent.OGL_Creatures.Add("Kraken");
        }
    }
}
