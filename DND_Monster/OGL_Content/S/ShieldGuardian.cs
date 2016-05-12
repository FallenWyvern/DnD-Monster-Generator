using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class ShieldGuardian
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Bound", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is magically bound to an amulet. As long as the {CREATURENAME} and its amulet are on the same plane of existence, the amulet's wearer can telepathically call the {CREATURENAME} to travel to it, and the {CREATURENAME} knows the distance and direction to the amulet. If the {CREATURENAME} is within 60 feet of the amulet's wearer, half of any damage the wearer takes (rounded up) is transferred to the {CREATURENAME}." },
                new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Regeneration", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} regains 10 hit points at the start of its turn if it has at least 1 hit point." },
                new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Spell Storing", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "A spellcaster who wears the {CREATURENAME}'s amulet can cause the {CREATURENAME} to store one spell of 4th level or lower. To do so, the wearer must cast the spell on the {CREATURENAME}. The spell has no effect but is stored within the {CREATURENAME}. When commanded to do so by the wearer or when a situation arises that was predefined by the spellcaster, the {CREATURENAME} casts the stored spell with any parameters set by the original caster, requiring no components. When the spell is cast or a new spell is stored, any previously stored spell is lost." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
                 new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Fist", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
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
            });

            // new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Shield Guardian", Title = "Shield", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When a creature makes an attack against the wearer of the {CREATURENAME}'s amulet, the {CREATURENAME} grants a +2 bonus to the wearer's AC if the {CREATURENAME} is within 5 feet of the wearer." }         
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Shield Guardian",
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

            OGLContent.OGL_Creatures.Add("Shield Guardian");
        }
    }
}
