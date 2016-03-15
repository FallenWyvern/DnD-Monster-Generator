using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Erinyes
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Erinyes", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Erinyes", Title = "Hellish Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical and deal an extra 13 (3d8) poison damage on a hit (included in the attacks)." },
                new OGL_Ability() { OGL_Creature = "Erinyes", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against magical spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Erinyes", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Erinyes", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Erinyes", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three attacks."},      
                 new OGL_Ability() { OGL_Creature = "Erinyes", Title = "Longsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 8,
                    HitText = "or 9 (1d10 + 4) slashing damage if used with two hands, plus 13 (3d8) poison damage.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Erinyes", Title = "Longbow", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "7",
                    Reach = 0,
                    RangeClose = 150,
                    RangeFar = 600,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 3,
                    HitAverageDamage = 7,
                    HitText = "plus 13 (3d8) poison damage, and the target must succeed on a DC 14 Constitution saving throw or be poisoned. The poison lasts until it is removed by the <i>lesser restoration</i> spell or similar magic.",
                    HitDamageType = "piercing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Erinyes", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Erinyes", Title = "Parry", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} adds 4 to its AC against one melee attack that would hit it. To do so, the {CREATURENAME} must see the attacker and wielding a melee weapon." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Erinyes",
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

            OGLContent.OGL_Creatures.Add("Erinyes");
        }
    }
}
