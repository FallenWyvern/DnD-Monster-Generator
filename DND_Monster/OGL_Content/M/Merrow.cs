using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Merrow
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Merrow", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Merrow", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Merrow", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Merrow", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Merrow", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Merrow", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its bite and one with its claws or harpoon."},      
                new OGL_Ability() { OGL_Creature = "Merrow", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 8,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Merrow", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 4,
                    HitDamageBonus = 4,
                    HitAverageDamage = 9,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Merrow", Title = "Harpoon", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee or Ranged Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 20,
                    RangeFar = 60,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 11,
                    HitText = "If the target is a Huge or smaller creature, it must succeed on a Strength contest against the {CREATURENAME} or be pulled up to 20 feet towards the {CREATURENAME}",
                    HitDamageType = "piercing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Merrow", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Merrow",
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

            OGLContent.OGL_Creatures.Add("");
        }
    }
}
