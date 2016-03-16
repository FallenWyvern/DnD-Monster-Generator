using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Drider
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Drider", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Fey Ancestry", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against being charmed, and magic can't put the drider to sleep." },
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 13, 
                Description = "bard|Wisdom|0|Innate|0,0,0,0,0,0,0,0,0|0:dancing lights,1:darkness,1:faerie fire,|" },
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check." },
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Sunlight Sensitivity", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While in sunlight, the {CREATURENAME} has disadvantage on attack rolls, as well as on Wisdom (Perception) checks that rely on sight." },
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Web Walker", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} ignores movement restrictions caused by webbing." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Drider", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Drider", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Drider", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three attacks, either with its longsword or its longbow. It can replace one of those attacks with a bite attack."},      
                 new OGL_Ability() { OGL_Creature = "Drider", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 0,
                    HitAverageDamage = 2,
                    HitText = "plus 9 (2d8) poison damage.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Longsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "or 8 (1d10 + 3) slashing damage if used with two hands.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Drider", Title = "Longbow", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "1",
                    Reach = 0,
                    RangeClose = 150,
                    RangeFar = 600,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "plus 4 (1d8) poison damage.",
                    HitDamageType = "piercing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Drider", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Drider",
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

            OGLContent.OGL_Creatures.Add("Drider");
        }
    }
}
