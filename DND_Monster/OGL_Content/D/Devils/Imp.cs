using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Imp
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Imp", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Imp", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its action to polymorph into a beast form that resembles a bat (speed 10 ft. fly 40 ft.), a centipede (40 ft., climb 40 ft.), or a toad (40 ft., swim 40 ft.), or back into its true form. Its statistics are the same in each form, except for th espeed changes noted. Any equipment it is wearing or carrying isn't transformed. It reverts back to its true form if it dies." },
                new OGL_Ability() { OGL_Creature = "Imp", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Imp", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Imp", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Imp", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Imp", Title = "Sting", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 3,
                    HitAverageDamage = 5,
                    HitText = "and must immediately make a DC 11 Constitution saving throw, taking 10 (3d6) poison damage on a failed save, or half on a successful one.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Imp", Title = "Invisibility", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically turns invisible until it attacks or uses Scare, or until its concentration ends (as if concentrating on a spell). Any equipment the {CREATURENAME} wears or carries is invisible with it."},      
            });

            // new OGL_Ability() { OGL_Creature = "Imp", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Imp",
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

            OGLContent.OGL_Creatures.Add("Imp");
        }
    }
}
