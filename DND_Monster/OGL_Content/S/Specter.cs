using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Specter
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Specter", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Specter", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Specter", Title = "Incoporeal Movement", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can move through other creatures and objects as if they were difficult terrain. If takes 5 (1d10) force damage if it ends its turn inside an object." },
                new OGL_Ability() { OGL_Creature = "Specter", Title = "Sunlight Sensitivity", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While in sunlight, the {CREATURENAME} has disadvantage on attack rolls, as well as on Wisdom (Perception) checks that rely on sight." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Specter", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Specter", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Specter", Title = "Life Drain", isDamage = false, isSpell = false, saveDC = 0, Description = "<i>Melee Spell Attack</i>: +4 to hit, reach 5 ft., one creature. <i>Hit</i>: 10 (3d6) necrotic damage. The target must succeed on a DC 10 Constitution saving throw or its hit point maximum is reduced by an amount equal to the damage taken. This reduction lasts until the creature finishes a long rest. The target dies if this effect reduces its hit point maximum to 0."},      
            });

            // new OGL_Ability() { OGL_Creature = "Specter", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Specter",
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

            OGLContent.OGL_Creatures.Add("Specter");
        }
    }
}
