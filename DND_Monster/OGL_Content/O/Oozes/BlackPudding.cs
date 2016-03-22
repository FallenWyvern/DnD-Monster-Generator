using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class BlackPudding
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "Amorphous", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can move through a space as narrow as 1 inch wide without squeezing." },
                new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "Corrosive Form", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "A creature that touches the {CREATURENAME} or hits it with a melee attack while within 5 feet of it takes 4 (1d8) acid damage, the weapon takes a permanent and cumulative -1 penalty to damage rolls. If its penalty drops to -5, the weapon is destroyed. Nonmagical ammunition made of metal or wood that hits the pudding is destroyed after dealing damage. </br> The pudding can eat through 2-inch-thick non-magical wood or metal in 1 round." },
                new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can climb difficult surfaces including upside down on ceilings, without needing to make an ability check." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "Pseudopod", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "plus 18 (4d8) acid damage. In addition, nonmagical armor worn by the target is partly dissolved and takes a permanent and cumulative -1 penalty to the AC it offers. The armor is destroyed if the penalty reduces its AC to 10.",
                    HitDamageType = "bludgeoning"
                }
                }, 
            });

            // new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Black Pudding", Title = "Split", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When a {CREATURENAME} that is Medium or larger is subjected to lightning or slashing damage, it splits into two new {CREATURENAME}s if it has at least 10 hit points. Each new {CREATURENAME} has hit points equal to half the original {CREATURENAME}'s, rounded down. New {CREATURENAME}s are one size smaller than their parent." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Black Pudding",
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

            OGLContent.OGL_Creatures.Add("Black Pudding");
        }
    }
}
