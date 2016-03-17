using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class GreenHag
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Green Hag", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Green Hag", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Green Hag", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 13, 
                Description = "bard|Wisdom|0|Innate|0,0,0,0,0,0,0,0,0|0:dancing lights,0:minor illusion,0:vicious mockery,|" },
                new OGL_Ability() { OGL_Creature = "Green Hag", Title = "Mimicry", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can mimic animal sounds and humanoid voices. A creature that hears the sounds can tell they are imitations with a successful DC 14 Wisdom (Insight) check." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Green Hag", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Green Hag", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Green Hag", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 13,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Green Hag", Title = "Illusionary Appearance", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} covers itself and anything it is wearing or carrying with a magical illusion that makes it look like another creature of its general size and humanoid shape. The illusion ends if the hag takes a bonus action to end it or if it dies. </br> The changes wrought by this effect fail to hold up to physical inspection. For example, the {CREATURENAME} could appear to have smooth skin, but someone touching it would feel its rough flesh. Otherwise a creature must take an action to visually inspect the illusion and succeed on a DC 20 Intelligence (Investigation) check to discern that the {CREATURENAME} is disguised."},      
                new OGL_Ability() { OGL_Creature = "Green Hag", Title = "Invisible Passage", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically turns invisible until it attacks or casts a spell, or until its concentration ends (as if concentrating on a spell). While invisible, it leaves no physical evidence of its passage, so it can be tracked only by magic. Any equipment it wears or carries is invisible with the {CREATURENAME}."},      
            });

            // new OGL_Ability() { OGL_Creature = "Green Hag", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Green Hag",
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

            OGLContent.OGL_Creatures.Add("Green Hag");
        }
    }
}
