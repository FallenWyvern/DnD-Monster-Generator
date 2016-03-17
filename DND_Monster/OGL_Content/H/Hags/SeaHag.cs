using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class SeaHag
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "Horrific Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Any humanoid that starts its turn within 30 feet of the {CREATURENAME} and can see the {CREATURENAME}'s true form must make a DC 11 Wisdom saving throw. On a failed save, the creature is frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, with disadvantage if the {CREATURENAME} is within line of sight, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Horrific Appearance for the next 24 hours. </br> Unless the target is surprised or the revelation of the {CREATURENAME}'s true form is sudden, the target can avert its eyes and avoid making the initial saving throw. Until the start of its next turn, a creature that averts its eyes has disadvantage on attack rolls against the {CREATURENAME}." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "Death Glare", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} targets one frightened creature it can see within 30 feet of it. If the target can see the {CREATURENAME}, it must succeed on a DC 11 Wisdom saving throw against this magic or drop to 0 hit points."},      
                new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "Illusionary Appearance", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} covers itself and anything it is wearing or carrying with a magical illusion that makes it look like another creature of its general size and humanoid shape. The illusion ends if the hag takes a bonus action to end it or if it dies. </br> The changes wrought by this effect fail to hold up to physical inspection. For example, the {CREATURENAME} could appear to have smooth skin, but someone touching it would feel its rough flesh. Otherwise a creature must take an action to visually inspect the illusion and succeed on a DC 20 Intelligence (Investigation) check to discern that the {CREATURENAME} is disguised."},      
            });

            // new OGL_Ability() { OGL_Creature = "Sea Hag", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Sea Hag",
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

            OGLContent.OGL_Creatures.Add("Sea Hag");
        }
    }
}
