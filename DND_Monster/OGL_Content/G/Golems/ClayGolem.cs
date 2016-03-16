using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class ClayGolem
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "Acid Absorption", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Whenever the {CREATURENAME} is subjected to acid damage, it takes no damage and instead regains a number of hit points equal to the acid damage dealt." },
                new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "Berserk", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Whenever the {CREATURENAME} starts its turn with 60 hit points or fewer, roll a d6. On a 6, the {CREATURENAME} goes berserk. On each of its turns while berserk, the {CREATURENAME} attacks the nearest creature it can see. If no creature is near enough to move to and attack, the {CREATURENAME} attacks an object, with preference for an object smaller than itself. Once the {CREATURENAME} goes berserk, it continues to do so until destroyed or regains all its hit points." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two slam attacks."},      
                 new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "Slam", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 5,
                    HitAverageDamage = 16,
                    HitText = "If the target is a creature, it must succeed on a DC 15 Constitution saving throw or have its hit point maximum reduced by an equal amount to the damage taken. The target dies if this attack reduces its hit point maximum to 0. The reduction lasts until removed by the <i>greater restoration</i> spell or other magic.",
                    HitDamageType = "bludgeoning"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "Haste (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "Until the end of its next turn, the golem magically gains +2 bonus to AC, has advantage on Dexterity saving throws, and can use its slam attack as a bonus action."},      
            });

            // new OGL_Ability() { OGL_Creature = "Clay Golem", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Clay Golem",
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

            OGLContent.OGL_Creatures.Add("Clay Golem");
        }
    }
}
