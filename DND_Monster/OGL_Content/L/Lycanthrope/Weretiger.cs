using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Weretiger
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Weretiger", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into a tiger-humanoid hybrid or into a tiger, or back into its true form, which is humanoid. Its statistics, other than its size and AC, are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Keen Hearing and Smell", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on Wisdom (Perception) checks that rely on hearing or smell." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Weretiger", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Weretiger", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Multiattack (Humanoid or Hybrid Form Only)", isDamage = false, isSpell = false, saveDC = 0, Description = "In Humanoid form, the {CREATURENAME} makes two scimitar attacks or two longbow attacks. In hybrid form, it can attack like a humanoid or make two claw attacks."},      
                 new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Bite (Tiger or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 10,
                    HitDamageBonus = 3,
                    HitAverageDamage = 8,
                    HitText = "If the target is a humanoid, it must succeed on a DC 13 Constitution saving throw or be cursed with weretiger lycanthropy.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Claw (Tiger or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Scimitar (Humanoid or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Weretiger", Title = "Longbow (Humanoid or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "5",
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

            // new OGL_Ability() { OGL_Creature = "Weretiger", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Weretiger",
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

            OGLContent.OGL_Creatures.Add("Weretiger");
        }
    }
}
