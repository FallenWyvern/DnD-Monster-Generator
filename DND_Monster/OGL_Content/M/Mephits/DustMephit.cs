using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class DustMephit
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "Death Burst", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When the {CREATURENAME} dies, it explodes in a burst of dust. Each creature within 5 feet of it must then succeed on a DC 10 Constitution saving throw or be blinded for 1 minute. A blinded creature can repeat the saving throw on each of its turns, ending the effect on itself on a success." },
                new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "Innate Spellcasting (1/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can innately cast <i>sleep</i>, requiring no material components. Its innate spellcasting ability is Charisma." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "Claws", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 2,
                    HitAverageDamage = 4,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "Blinding Breath (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} exhales a 15-foot cone of blinding dust. Each creature in that area must succeed on a DC 10 Dexterity saving throw or be blinded for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success."},      
            });

            // new OGL_Ability() { OGL_Creature = "Dust Mephit", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {             
            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Dust Mephit",
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

            OGLContent.OGL_Creatures.Add("Dust Mephit");
        }
    }
}
