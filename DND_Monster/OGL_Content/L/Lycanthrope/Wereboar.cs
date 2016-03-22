using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Wereboar
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Wereboar", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into a boar-humanoid hybrid or into a boar, or back into its true form, which is humanoid. Its statistics, other than its size and AC, are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Charge (Boar or Hybrid Form Only)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} moves at least 15 feet straight foward toward a target and then hits it with its tusks on the same turn, the target takes an extra 7 (2d6) slashing damage. If the target is a creature, it must succeed on a DC 13 Strength saving throw or be knocked prone." },
                new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Relentless (Recharges after a Short or Long Rest)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} takes 14 damage or less that would reduce it to 0 hit points, it is reduced to 1 hit point instead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Wereboar", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Wereboar", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "In bear form, the {CREATURENAME} makes two attacks, only one of which can be with its tusks."},      
                 new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Maul (Humanoid or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Wereboar", Title = "Tusks (Boar or Hybrid Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "If the target is a humanoid, it must succeed on a DC 12 Constitution saving throw or be cursed with wereboar lycanthropy.",
                    HitDamageType = "slashing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Wereboar", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Wereboar",
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

            OGLContent.OGL_Creatures.Add("Wereboar");
        }
    }
}
