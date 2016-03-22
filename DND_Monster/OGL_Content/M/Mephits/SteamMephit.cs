using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class SteamMephit
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "Death Burst", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When the {CREATURENAME} dies, it explodes in a cloud of steam. Each creature within 5 feet of it must then succeed on a DC 10 Dexterity saving throw taking 4 (1d8) fire damage on a failed save." },                
                new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "Innate Spellcasting (1/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can innately cast <i>blur</i>, requiring no material components. Its innate spellcasting ability is Charisma." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "2",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 0,
                    HitAverageDamage = 2,
                    HitText = "plus 2 (1d4) fire damage.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "Steam Breath (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales a 15-foot cone of scalding steam. Each creature in the area must succeed on a DC 10 Dexterity saving throw, taking 4 (1d8) fire damage on a failed save, or half as much on a successful one."},      
            });

            // new OGL_Ability() { OGL_Creature = "Steam Mephit", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Steam Mephit",
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

            OGLContent.OGL_Creatures.Add("Steam Mephit");
        }
    }
}
