using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Chuul
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Chuul", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Chuul", Title = "Amphibious", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
                new OGL_Ability() { OGL_Creature = "Chuul", Title = "Sense Magic", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} senses magic within 120 feet of it at will. This trait otherwise works like the <i>detect magic</i> spell but isn't itself magical." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Chuul", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Chuul", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Chuul", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two pincer attacks. If the {CREATURENAME} is grappling a creature, the {CREATURENAME} can also use its tentacles once."},      
                 new OGL_Ability() { OGL_Creature = "Chuul", Title = "Pincer", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 11,
                    HitText = "The target is grappled (escape DC 14) if it is a Large or smaller creature and the {CREATURENAME} doesn't have two other creatures grappled.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Chuul", Title = "Tentacles", isDamage = false, isSpell = false, saveDC = 0, Description = "One creature grappled by the {CREATURENAME} must succeed on a DC 13 Constitution saving throw or be poisoned for 1 minute. Until this poison ends, the target is paralyzed. The target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success."},      
            });

            // new OGL_Ability() { OGL_Creature = "Chuul", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Chuul",
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

            OGLContent.OGL_Creatures.Add("Chuul");
        }
    }
}
