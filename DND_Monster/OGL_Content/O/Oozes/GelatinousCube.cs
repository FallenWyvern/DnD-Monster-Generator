using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class GelatinousCube
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "Ooze Cube", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} takes up its entire space. Other creatures can enter the space, but a creature that does so is subjected to the {CREATURENAME}'s Engulf and has disadvantage on the saving throw.</br>Creautres inside the {CREATURENAME} can be seen but have total cover. </br>A creature within 5 feet of the {CREATURENAME} can take an action to pull a creature or object out of the {CREATURENAME}. Doing so requires a successful DC 12 Strength check, and the creature making the attempt takes 10 (3d6) acid damage. </br>The {CREATURENAME} can hold only one Large creature or up to four Medium or smaller creatures inside at a time." },
                new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "Transparent", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Even when the {CREATURENAME} is in plain sight, it takes a successful DC 15 Wisdom (Perception) check to spot a {CREATURENAME} that has neither moved nor attacked. A creature that tries to enter the {CREATURENAME}'s space while unaware of the {CREATURENAME} is surprised by the {CREATURENAME}." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "Pseudopod", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "4",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one creature",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "acid"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "Engulf", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} moves up to its speed. While doing so, it can enter Large or smaller creatures' spaces. Whenever teh {CREATURENAME} enters a creature's space, the creature must make a DC 12 Dexterity saving throw. </br>On a successful save, the creature can choose to be pushed 5 feet back or to the side of the {CREATURENAME}. A creature that chooses not to be pushed suffers the consequences of a failed saving throw.</br>On a failed save, the {CREATURENAME} enters the creature's space, and the creature takes 10 (3d6) acid damage and is engulfed. The engulfed creature can't breathe, is restrained, and takes 21 (6d6) acid damage at the start of each of the {CREATURENAME}'s turns. When the {CREATURENAME} moves, the engulfed creature moves with it.</br>An engulfed creature can try to escabe by taking an action to make a DC 12 Strength check. On a success, the creature escapes and enters a space of its choice within 5 feet of the {CREATURENAME}."},      
            });

            // new OGL_Ability() { OGL_Creature = "Gelatinous Cube", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Gelatinous Cube",
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

            OGLContent.OGL_Creatures.Add("Gelatinous Cube");
        }
    }
}
