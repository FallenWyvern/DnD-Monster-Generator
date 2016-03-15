using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Marilith
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Marilith", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Marilith", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Marilith", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
                new OGL_Ability() { OGL_Creature = "Marilith", Title = "Reactive", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can take one reaction on every turn in a combat." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Marilith", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Marilith", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Marilith", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
                 new OGL_Ability() { OGL_Creature = "Marilith", Title = "Longsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 13,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },                
                 new OGL_Ability() { OGL_Creature = "Marilith", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 4,
                    HitAverageDamage = 15,
                    HitText = "If the target is Medium or smaller, it is grappled (escape DC 19). Until this grapple ends, the target is restrained, the {CREATURENAME} can automatically hit the target with its tail, and the {CREATURENAME} can't make tail attacks against other targets.",
                    HitDamageType = "bludgeoning"
                }
                }, 
                 new OGL_Ability() { OGL_Creature = "Marilith", Title = "Teleport", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically teleports, along with any equipment it was wearing or carrying, up to 120 feet to an unoccupied space it can see."},      
            });

            // new OGL_Ability() { OGL_Creature = "Marilith", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Marilith", Title = "Parry", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} adds 5 to its ac against one melee attack that would hit it. To do so, the {CREATURENAME} must see the attacker and be wielding a melee weapon." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Marilith",
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

            OGLContent.OGL_Creatures.Add("Marilith");
        }
    }
}
