using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class OchreJelly
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "Amorphous", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREAUTRENAME} can move through a space as narrow as 1 inch wide without squeezing." },
                new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREAUTRENAME} can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "Pseudopod", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 9,
                    HitText = "plus 3 (1d6) acid damage.",
                    HitDamageType = "bludgeoning"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Ochre Jelly", Title = "Split", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When a {CREAUTRENAME} that is Medium or larger is subjected to lightning or slashing damage, it splits into two new {CREAUTRENAME} if it has at least 10 hit points. Each new {CREAUTRENAME} has hit points equal to half the original {CREAUTRENAME}'s, rounded down. New {CREAUTRENAME} are one size smaller than the original {CREAUTRENAME}." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Ochre Jelly",
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

            OGLContent.OGL_Creatures.Add("Ochre Jelly");
        }
    }
}
