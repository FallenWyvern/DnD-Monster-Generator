using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Doppleganger
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into a Small or Medium humanoid it has seen, or back into its true form. Its statistics, other than its size, are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "Ambusher", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on attack rolls against any creature it has surprised." },
                new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "Surprise Attack", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} surprises a creature and hits it with an attack during the first round of combat, the target takes an extra 10 (3d6) damage from the attack." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two melee attacks."},      
                 new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "Slam", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 7,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },
                new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "Read Thoughts", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically reads the surface thoughts of one creature within 60 feet of it. The effect can penetrate barriers, but 3 feet of wood or dirt, 2 feet of stone, 2 inches of metal, or a thin sheet of lead blocks it. While the target is in range, the {CREATURENAME} can continue reading its thoughts, as long as the {CREATURENAME}'s concentration isn't broken (as if concentrating on a spell). While reading the target's mind, the {CREATURENAME} has advantage on Wisdom (Insight) and Charisma (Deception, Intimidation, and Persuasion) checks against the target."},      
            });

            // new OGL_Ability() { OGL_Creature = "Doppleganger", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Doppleganger",
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

            OGLContent.OGL_Creatures.Add("Doppleganger");
        }
    }
}
