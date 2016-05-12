using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Shadow
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Shadow", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Shadow", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Shadow", Title = "Amorphous", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can move through a space as narrow as 1 inch wide without squeezing." },
                new OGL_Ability() { OGL_Creature = "Shadow", Title = "Shadow Stealth", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While in dim light or darkness, the {CREATURENAME} can take the Hide action as a bonus action." },
                new OGL_Ability() { OGL_Creature = "Shadow", Title = "Sunlight Weakness", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While in sunlight, the {CREATURENAME} has disadvantage on attack rolls, ability checks, and saving throws." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Shadow", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Shadow", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Shadow", Title = "Strength Drain", isDamage = false, isSpell = false, saveDC = 0, Description = "<i>Melee Weapon Attack</i>: +4 to hit, reach 5 ft., one creature. <i>Hit</i>: 9 (2d6 + 2) necrotic damage, and the target's Strength score is reduced by 1d4. The target dies if this reduces its Strength to 0. Otherwise, this reduction lasts until the target finishes a short or long rest. </br> If a non-evil humanoid dies from this attack, a new shadow rises from the corpse 1d4 hours later."},                      
            });

            // new OGL_Ability() { OGL_Creature = "Shadow", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Shadow",
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

            OGLContent.OGL_Creatures.Add("Shadow");
        }
    }
}
