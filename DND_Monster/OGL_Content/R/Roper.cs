using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class Roper
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Roper", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Roper", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Roper", Title = "False Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from a normal cave formation such as a stalagmite." },
                new OGL_Ability() { OGL_Creature = "Roper", Title = "Grasping Tentacles", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can have up to six tendrils at a time. Each tendril can be attacked (AC 20; 10 hit points; immunity to poison and psychic damage). Destroying a tendril deals no damage to the {CREATURENAME}, which can extrude a replacement tendril on its next turn. A tendril can also be broken if a creature takes an action and succeeds on a DC 15 Strength check against it." },
                new OGL_Ability() { OGL_Creature = "Roper", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can climb difficult surfaces including upside down on ceilings, without needing to make an ability check." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Roper", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Roper", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Roper", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes four attacks with its tendrils, uses Reel, and makes one attack with its bite."},      
                 new OGL_Ability() { OGL_Creature = "Roper", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 22,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },                  
                 new OGL_Ability() { OGL_Creature = "Roper", Title = "Tendril", isDamage = false, isSpell = false, saveDC = 0, 
                     Description = "<i>Melee Weapon Attack:</i> +7 to hit, reach 50 ft., one creature. <i>Hit:</i> The target is grappled (escape DC 15). Until the grapple ends, the target is restrained and has disadvantage on Strength checks and Strength saving throws, and the {CREATURENAME} can't use the same tendril on another target."},      
                 new OGL_Ability() { OGL_Creature = "Roper", Title = "Reel", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} pulls each creature grappled by it up to 25 feet straight toward it."},      
            });

            // new OGL_Ability() { OGL_Creature = "Roper", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Roper",
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

            OGLContent.OGL_Creatures.Add("Roper");
        }
    }
}
