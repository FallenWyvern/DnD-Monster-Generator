using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Djinni
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Djinni", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Djinni", Title = "Elemental Demise", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} dies, its body disintegrates into a warm breeze, leaving behind only equipment the djinni was wearing or carrying." },
                new OGL_Ability() { OGL_Creature = "Djinni", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect evil and good,0:detect magic,0:thunderwave,1:conjure elemental (air elemental only),1:creation,1:gaseous form,1:invisibility,1:major image,1:plane shift,3:create food and water (can create wine instead of water),3:tongues,3:wind walk,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Djinni", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Djinni", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Djinni", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three scimitar attacks."},      
                 new OGL_Ability() { OGL_Creature = "Djinni", Title = "Scimitar", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 5,
                    HitAverageDamage = 12,
                    HitText = "plus 3 (1d6) lightning or thunder damage ({CREATURENAME}'s choice)",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Djinni", Title = "Create Whirlwind", isDamage = false, isSpell = false, saveDC = 0, Description = "A 5-foot-radius, 30-foot-tall cylinder of swirling air magically forms on a point the {CREATURENAME} can see within 120 feet of it. The whirlwind lasts as long as the {CREATURENAME} maintains concentration (as if concentrating on a spell). Any creature but the {CREATURENAME} that enters the whirlwind must succeed on a DC 18 Strength saving throw or be restrained by it. The {CREATURENAME} can move the whirlwind up to 60 feet as an action, and creatures restrained by the whirlwind move with it. The whirlwind ends if the {CREATURENAME} loses sight of it. </br> A creature can use its action to free a creature restrained by the whirlwind, including itself, by succeeding on a DC 18 Strength check. If the check succeeds, the creature is no longer restrained and moves to the nearest space outside the whirlwind."},      
            });

            // new OGL_Ability() { OGL_Creature = "Djinni", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Djinni",
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

            OGLContent.OGL_Creatures.Add("Djinni");
        }
    }
}
