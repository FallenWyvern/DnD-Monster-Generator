using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Wererat
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Wererat", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Wererat", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Wererat", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into a rat-humanoid hybrid or into a giant rat, or back into its true form, which is humanoid. Its statistics, other than its size and AC, are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Wererat", Title = "Keen Smell", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on Wisdom (Perception) checks that rely on smell." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Wererat", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Wererat", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Wererat", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "In bear form, the {CREATURENAME} makes two atacks, only one of which can be a bite."},      
                 new OGL_Ability() { OGL_Creature = "Wererat", Title = "Bite (Rat or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 2,
                    HitAverageDamage = 4,
                    HitText = "If the target is a humanoid, it must succeed on a DC 11 Constitution saving throw or be cursed with wererat lycanthropy.",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Wererat", Title = "Shortsword (Humanoid or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Wererat", Title = "Hand Crossbow (Humanoid or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "4",
                    Reach = 0,
                    RangeClose = 30,
                    RangeFar = 120,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Wererat", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Wererat",
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

            OGLContent.OGL_Creatures.Add("Wererat");
        }
    }
}
