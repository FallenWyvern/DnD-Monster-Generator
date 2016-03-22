using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class MagmaMephit
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "Death Burst", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When the {CREATURENAME} dies, it explodes in a burst of lava. Each creature within 5 feet of it must then succeed on a DC 11 Dexterity saving throw taking 7 (2d6) slashing damage on a failed save, or half as much damage on a successful one." },
                new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "False Appearance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} remains motionless, it is indistinguishable from an ordinary mound of magma." },
                new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "Innate Spellcasting (1/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can innately cast <i>heat metal</i>, requiring no material components. Its innate spellcasting ability is Charisma." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 1,
                    HitAverageDamage = 3,
                    HitText = "plus 2 (1d4) fire damage.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "Fire Breath (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales a 15-foot cone of fire. Each creature in the area must succeed on a DC 11 Dexterity saving throw, taking 7 (2d6) fire damage on a failed save, or half as much on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Magma Mephit", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Magma Mephit",
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

            OGLContent.OGL_Creatures.Add("Magma Mephit");
        }
    }
}
