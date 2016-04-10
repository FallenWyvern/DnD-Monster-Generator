using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class RustMonster
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "Iron Scent", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can pinpoint, by scent, the location of ferrous metal within 30 feet of it." },
                new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "Rust Metal", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Any nonmagical weapon made of metal that hits the {CREATURENAME} corrodes. After dealing damage, the weapon takes a permanent and cumulative -1 penalty to damage rolls. If its penalty drops to -5, the weapon is destroyed. Nonmagical ammunition made of metal that hits the {CREATURENAME} is destroyed after dealing damage." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "3",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 1,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "Antennae", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} corrodes a nonmagical ferrous metal object it can see within 5 feet of it. If the object isn't being worn or carried, the touch destroys a 1-foot cube of it. If the object is being worn or carried by a creature, the creature can make a DC 11 Dexterity saving throw to avoid the {CREATURENAME}'s touch. </br> If the object touched is either metal armor or a metal shield being worn or carried, it takes a permanent and cumulative -1 penalty to the AC it offers. Armor reduced to an AC of 10 or a shield that drops to a +0 bonus is destroyed. If the object touched is a held metal weapon, it rusts as described in the Rust Metal trait."},      
            });

            // new OGL_Ability() { OGL_Creature = "Rust Monster", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Rust Monster",
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

            OGLContent.OGL_Creatures.Add("Rust Monster");
        }
    }
}
