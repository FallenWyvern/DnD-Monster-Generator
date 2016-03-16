using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class DeepGnome
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "Stone Camouflage", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on Dexterity (Stealth) checks made to hide in rocky terrain." },
                new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "Gnome Cunning", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on Intelligence, Wisdom, and Charisma saving throws against magic." },                
                new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                Description = "bard|Intelligence|0|Innate|0,0,0,0,0,0,0,0,0|0:nondetection (self only),1:blindness/deafness,1:blur,1:disguise self,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "War Pick", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 2,
                    HitAverageDamage = 6,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },
                 new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "Poisoned Dart", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "4",
                    Reach = 0,
                    RangeClose = 30,
                    RangeFar = 120,
                    Target = "one creature",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 2,
                    HitAverageDamage = 4,
                    HitText = "and the target must succeed on a DC 12 Constitution saving throw or be poisoned for 1 minute. The target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.",
                    HitDamageType = "piercing"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Deep Gnome", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Deep Gnome",
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

            OGLContent.OGL_Creatures.Add("Deep Gnome");
        }
    }
}
