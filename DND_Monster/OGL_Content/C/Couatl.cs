using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Couatl
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Couatl", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Couatl", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 14, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect good and evil,0:detect magic,0:detect thoughts,1:dream,1:greater restoration,1:scrying,3:bless,3:create food and water,3:cure wounds,3:lesser restoration,3:protection from poison,3:sanctuary,3:shield,|" },
                new OGL_Ability() { OGL_Creature = "Couatl", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
                new OGL_Ability() { OGL_Creature = "Couatl", Title = "Shielded Mind", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is immune to scrying and to any effect that would sense its emotions, read its thoughts, or detect its location." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Couatl", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Couatl", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitText = "plus this text",
            //    HitDamageType = "Acid"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {                 
                 new OGL_Ability() { OGL_Creature = "Couatl", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 5,
                    HitAverageDamage = 8,
                    HitText = "and the target must succeed on a DC 13 Constitution saving throw or be poisoned for 24 hours. Until this poison ends, the target is unconscious. Another creature can use an action to shake the target awake.",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Couatl", Title = "Constrict", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one Medium or smaller creature",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "and the target is grappled (escape DC 15). Until this grapple ends, the target is restrained, and the {CREATURENAME} can't constrict another target.",
                    HitDamageType = "bludgeoning"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Couatl", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a humanoid or beast that has a challenge rating equal to or less than its own, or back into its true form. It reverts to its true form if it dies. Any equipment it is wearing or carrying is absorbed or borne by the new form (the {CREATURENAME}'s choice). </br> In a new form, the {CREATURENAME} retains its game statistics and ability to speak, but its AC, movement modes, Strength, Dexterity, and other actions are replaced by those of the new form, and it gains any statistics and capabilities (except class features, legendary actions, and lair actions) that the new form has but that it lacks. If the new form has a bite attack, the {CREATURENAME} can use its bite in that form."},      
            });

            // new OGL_Ability() { OGL_Creature = "Couatl", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Couatl",
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

            OGLContent.OGL_Creatures.Add("Couatl");
        }
    }
}
