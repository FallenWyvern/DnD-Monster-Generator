using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Efreeti
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Efreeti", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Efreeti", Title = "Elemental Demise", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} dies, its body disintegrates into a flash of fire and puff of smoke, leaving behind only equipment the djinni was wearing or carrying." },
                new OGL_Ability() { OGL_Creature = "Efreeti", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,1:conjure elemental (fire elemental only),1:gaseous form,1:invisibility,1:major image,1:plane shift,1:wall of fire,3:enlarge/reduce,3:tongues,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Efreeti", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Efreeti", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Efreeti", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three scimitar attacks."},      
                 new OGL_Ability() { OGL_Creature = "Efreeti", Title = "Scimitar", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 6,
                    HitAverageDamage = 7,
                    HitText = "plus 7 (2d6) fire damage",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Efreeti", Title = "Hurl Flame", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Spell Attack",
                    Bonus = "7",
                    Reach = 0,
                    RangeClose = 120,
                    RangeFar = 120,
                    Target = "one target",
                    HitDiceNumber = 5,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "fire"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Efreeti", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Efreeti",
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

            OGLContent.OGL_Creatures.Add("Efreeti");
        }
    }
}
