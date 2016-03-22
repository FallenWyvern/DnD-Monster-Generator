using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Magmin
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Magmin", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Magmin", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Magmin", Title = "Death Burst", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When the {CREATURENAME} dies, it explodes in a burst of fire and magma. Each creature within 10 feet of it must make a DC 11 Dexterity saving throw, taking 7 (2d6) fire damage on a failed save, or half as much damage on a successful one. Flammable objects that aren't being worn or carried in that area are ignited." },
                new OGL_Ability() { OGL_Creature = "Magmin", Title = "Ignited Illumination", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "As a bonus action, the {CREATURENAME} can set itself ablaze or extinguish its flames. While ablaze, the {CREATURENAME} sheds bright light in a 10-foot radius and dim light for an additional 10 feet." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Magmin", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Magmin", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Magmin", Title = "Touch", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 7,
                    HitAverageDamage = 0,
                    HitText = "If the target is a creature or flammable object, it ignites. Until a creature takes an action to douse the fire, the target takes 3 (1d6) fire damage at the end of each of its turns.",
                    HitDamageType = "fire"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Magmin", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Magmin",
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

            OGLContent.OGL_Creatures.Add("Magmin");
        }
    }
}
