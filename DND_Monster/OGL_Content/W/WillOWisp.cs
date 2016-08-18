using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class WillOWisp
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Consume Life", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "As a bonus action, the {CREATURENAME} can target one creature it can see within 5 feet of it that has 0 hit points and is still alive. The target must succeed on a DC 10 Constitution saving throw against this magic or die. If the target dies, the {CREATURENAME} regains 10 (3d6) hit points." },
                 new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Ephemeral", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can't wear or carry anything." },
                 new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Incoporeal Movement", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can move through other creatures and objects as if it were difficult terrain. It takes 5 (1d10) force damage if it ends its turn inside an object." },
                 new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Variable Illumination", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} sheds bright light in a 5- to 20-foot radius and dim light for an additional number of feet equal to the chosen radius. The {CREATURENAME} can alter the radius as a bonus action." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Shock", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                {
                    _Attack = "Melee Spell Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one creature",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 0,
                    HitAverageDamage = 9,
                    HitText = "",
                    HitDamageType = "lightning"
                }
                },
                 new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "Invisibility", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} and its light magically become invisible until it attacks or uses its Consume Life, or until its concentration ends (as if concentrating on a spell)"},
            });

            // new OGL_Ability() { OGL_Creature = "Will o' Wisp", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Will o' Wisp",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Will o' Wisp");
        }
    }
}
