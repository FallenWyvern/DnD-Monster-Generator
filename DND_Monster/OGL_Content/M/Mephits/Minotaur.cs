using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Minotaur
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Minotaur", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Minotaur", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Minotaur", Title = "Charge", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} moves at least 10 feet straight toward a target and then hits it with a gore attack on the same turn, the target takes an extra 9 (2d8) piercing damage. If the target is a creature, it must succeed on a DC 14 Strength saving throw or be pushed up to 10 feet away and knocked prone." },
                new OGL_Ability() { OGL_Creature = "Minotaur", Title = "Labyrinthine Recall", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can perfectly recall any path it has traveled." },
                new OGL_Ability() { OGL_Creature = "Minotaur", Title = "Reckless", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "At the start of its turn, the {CREATURENAME} can gain advantage on all melee weapon attack rolls it makes during that turn, but attack rolls against it have advantage until the start of its next turn." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Minotaur", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Minotaur", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Minotaur", Title = "Greataxe", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 12,
                    HitDamageBonus = 4,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Minotaur", Title = "Gore", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitDamageType = "piercing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Minotaur", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Minotaur",
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

            OGLContent.OGL_Creatures.Add("Minotaur");
        }
    }
}
