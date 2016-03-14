using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Centaur
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Centaur", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
                {
                    new OGL_Ability() { OGL_Creature = "Centaur", Title = "Charge", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} moves at least 30 feet in a straight line toward a target and then hits it with a pike attack on the same turn, the target takes an extra 10 (3d6) piercing damage." },
                });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Centaur", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Centaur", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitText = "plus this text",
            //    HitDamageType = "Acid"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
                {
                     new OGL_Ability() { OGL_Creature = "Centaur", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its pike and one with its hooves or two with its longbow."},      
                     new OGL_Ability() { OGL_Creature = "Centaur", Title = "Pike", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                    { 
                        _Attack = "Melee Weapon Attack",
                        Bonus = "6",
                        Reach = 10,
                        RangeClose = 0,
                        RangeFar = 0,
                        Target = "one target",
                        HitDiceNumber = 1,
                        HitDiceSize = 10,
                        HitDamageBonus = 4,
                        HitAverageDamage = 9,
                        HitText = "",
                        HitDamageType = "piercing"
                    }
                    },  
                    new OGL_Ability() { OGL_Creature = "Centaur", Title = "Hooves", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                    { 
                        _Attack = "Melee Weapon Attack",
                        Bonus = "6",
                        Reach = 5,
                        RangeClose = 0,
                        RangeFar = 0,
                        Target = "one target",
                        HitDiceNumber = 2,
                        HitDiceSize = 6,
                        HitDamageBonus = 4,
                        HitAverageDamage = 11,
                        HitText = "",
                        HitDamageType = "bludgeoning"
                    }
                    }, 
                    new OGL_Ability() { OGL_Creature = "Centaur", Title = "Longbow", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                    { 
                        _Attack = "Ranged Weapon Attack",
                        Bonus = "4",
                        Reach = 0,
                        RangeClose = 150,
                        RangeFar = 600,
                        Target = "one target",
                        HitDiceNumber = 1,
                        HitDiceSize = 8,
                        HitDamageBonus = 2,
                        HitAverageDamage = 6,
                        HitText = "",
                        HitDamageType = "piercing"
                    }
                    }, 
                });

            // new OGL_Ability() { OGL_Creature = "Centaur", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Centaur",
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

            OGLContent.OGL_Creatures.Add("Centaur");
        }
    }
}