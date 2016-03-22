using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class SpiritNaga
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "Rejuvenation", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If it does, the {CREATURENAME} returns to live in 1d6 days and regains all its hit points. Only a <i>wish</i> spell can prevent this trait from functioning." },
                new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                 Description = "wizard|Intelligence|10|NotInnate|4,3,3,3,2,0,0,0,0|" + 
                 "0:mage hand,0:minor illusion,0:ray of frost,1:charm person,1:detect magic,1:sleep,2:detect thoughts,2:hold person,3:lightning bolt,3:water breathing,4:blight,4:dimension door,5:dominate person,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 7,
                    HitText = "and the target must make a DC 13 Constiution saving throw, taking 31 (7d8) poison damage on a failed save, or half as much on a successful one.",
                    HitDamageType = "piercing"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Spirit Naga", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Spirit Naga",
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

            OGLContent.OGL_Creatures.Add("Spirit Naga");
        }
    }
}
