using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Werebear
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Werebear", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Werebear", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Werebear", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into a Large bear-humanoid hybrid or into a Large bear, or back into its true form, which is humanoid. Its statistics, other than its size and AC, are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Werebear", Title = "Keen Smell", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on Wisdom (Perception) checks that rely on smell." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Werebear", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Werebear", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Werebear", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "In bear form, the {CREATURENAME} makes two claw attacks. In humanoid form, it makes two greataxe attacks. In hybrid form, it can attack like a bear or a humanoid."},      
                 new OGL_Ability() { OGL_Creature = "Werebear", Title = "Bite (Bear or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 4,
                    HitAverageDamage = 15,
                    HitText = "If the target is a humanoid, it must succeed on a DC 14 Constitution saving throw or be cursed with werebear lycanthropy.",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Werebear", Title = "Claw (Bear or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
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
                new OGL_Ability() { OGL_Creature = "Werebear", Title = "Greataxe (Humanoid or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 12,
                    HitDamageBonus = 4,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Werebear", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Werebear",
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

            OGLContent.OGL_Creatures.Add("Werebear");
        }
    }
}
