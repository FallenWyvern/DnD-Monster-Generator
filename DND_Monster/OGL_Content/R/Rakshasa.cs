using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{    
    public static class Rakshasa
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "Limited Magic Immunity", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can't be affected or detected by spells of 6th level or lower unless it wishes to be. It has advantage on saving throws against all other spells and magical effects." },
                new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 18, 
                    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect thoughts,0:disguise self,0:mage hand,0:minor illusion,1:dominate person,1:fly,1:plane shift,1:true seeing,3:charm person,3:detect magic,3:invisibility,3:major image,3:suggestion,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two claw attacks."},      
                 new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 9,
                    HitText = "and the target is cursed if it is a creature. The magical curse takes effect whenever the target takes a short or long rest, filling the target's thoughts with horrible images and dreams. The cursed target gains no benefit from finishing a short or long rest. The curse lasts until it is lifted by a <i>remove curse</i> spell or similar magic.",
                    HitDamageType = "slashing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Rakshasa", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Rakshasa",
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

            OGLContent.OGL_Creatures.Add("Rakshasa");
        }
    }
}
