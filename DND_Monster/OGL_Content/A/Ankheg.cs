using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
     public static class Ankheg
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Ankheg", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Ankheg", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Ankheg", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
            //{ 
            //    _Attack = "Melee Weapon Attack",
            //    Bonus = "1",
            //    Reach = 5,
            //    RangeClose = 10,
            //    RangeFar = 15,
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
                new OGL_Ability() { OGL_Creature = "Ankheg", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "plus 3 (1d6) acid damage. If the target is a Large or smaller creature, it is grappled (escape DC 13). Until this grapple ends, the {CREATURENAME} can bite only the grappled creature and has advantage on attack rolls to do so.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ankheg", Title = "Acid Spray (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} spits acid in a line that is 30 feet long and 5 feet wide, provided that it has no creature grappled. Each creature in that line must make a DC 13 Dexterity saving throw, taking 10 (3d6) acid damage on a failed save, or half as much damage on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Ankheg", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Ankheg",
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

            OGLContent.OGL_Creatures.Add("Ankheg");
        }
    }
}
