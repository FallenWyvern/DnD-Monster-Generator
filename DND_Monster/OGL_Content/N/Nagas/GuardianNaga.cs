using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class GuardianNaga
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "Rejuvenation", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If it dies, the {CREATURENAME} returns to life in 1d6 days and regains all its hit points. Only a <i>wish</i> spell can prevent this trait from functioning." },
                new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                 Description = "druid|Wisdom|11|NotInnate|4,3,3,3,2,1,0,0,0|" +
                 "0:mending,0:sacred flame,0:thaumaturgy,1:command,1:cure wounds,1:shield of faith,2:calm emotions,2:hold person,3:bestow curse,3:clairvoyance,4:banishment,4:freedom of movement,5:flame strike,5:geas,6:true seeing,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 8,
                    HitText = "and the target must make a DC 15 Constitution saving throw, taking 45 (10d8) poison damage on a failed save, or half as much damage on a successful one.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "Spit Poison", isDamage = true, isSpell = false, saveDC = 0, 
                     Description = "<i>Ranged Weapon Attack:</i> +8 to hit, range 15/30 ft., one creature. <i>Hit:</i> the target must make a DC 15 Constitution saving throw, taking 45 (10d8) poison damage on a failed save, or half as much damage on a successful one."
                 },
            });

            // new OGL_Ability() { OGL_Creature = "Guardian Naga", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Guardian Naga",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", ""),                    
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Guardian Naga");
        }
    }
}
