using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Manticore
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Manticore", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Manticore", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Manticore", Title = "Tail Spike Regrowth", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has twenty-four tail spikes. Used spikes regrow when the {CREATURENAME} finishes a long rest." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Manticore", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Manticore", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Manticore", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
                 new OGL_Ability() { OGL_Creature = "Manticore", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 6,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Manticore", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 6,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Manticore", Title = "Tail Spike", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "5",
                    Reach = 0,
                    RangeClose = 100,
                    RangeFar = 200,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  

            });

            // new OGL_Ability() { OGL_Creature = "Manticore", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Manticore",
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

            OGLContent.OGL_Creatures.Add("Manticore");
        }
    }
}
