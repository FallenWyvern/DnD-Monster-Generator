using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class HornedDevil
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes three melee attacks: two with its fork and one with its tail. It can use Hurl Flame in the place of any melee attack."},      
                 new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "Fork", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 6,
                    HitAverageDamage = 15,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "Tail", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 6,
                    HitAverageDamage = 10,
                    HitText = "If the target is a creature other than an undead or a construct, it must succeed on a DC 17 Constitution saving throw or lose 10 (3d6) hit points at the start of each of its turns due to an infernal wound. Each time the {CREATURENAME} hits the wounded target with this attack, the damage dealt by the wound increases by 10 (3d6). Any creature can take an action to staunch the wound with a successful DC 12 Wisdom (Medicine) check. The wound also closes if the target recieves magical healing.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "Hurl Flame", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Spell Attack",
                    Bonus = "7",
                    Reach = 0,
                    RangeClose = 150,
                    RangeFar = 150,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 14,
                    HitText = "If the target is a flammable object that isn't being worn or carried, it also catches fire.",
                    HitDamageType = "fire"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Horned Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Horned Devil",
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

            OGLContent.OGL_Creatures.Add("Horned Devil");
        }
    }
}
