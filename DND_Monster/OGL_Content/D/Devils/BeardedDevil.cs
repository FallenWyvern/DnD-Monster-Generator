using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class BeardedDevil
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "Devil's Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Magical darkness doesn't impede the {CREATURENAME}'s darkvision." },
                new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "Steadfast", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can't be frightened while it can see an allied creature within 30 feet of it." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its beard and one with its glaive."},      
                 new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "Beard", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 2,
                    HitAverageDamage = 6,
                    HitText = "and the target must succeed on a DC 12 Constitution saving throw or be poisoned for 1 minute. While poisoned in this way, the target can't regain hit points. The target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "Glaive", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 10,
                    HitDamageBonus = 3,
                    HitAverageDamage = 8,
                    HitText = "If the target is a creature other than an undead or a construct, it must succeed on a DC 12 Constitution saving throw or lose 5 (1d10) hit points at the start of each of its turns due to an infernal wound. Each time the {CREATURENAME} hits the wounded target with this attack, the damage dealt by the wound increases by 5 (1d10). Any creature can take an action to staunch the wound with a successful DC 12 Wisdom (Medicine) check. The wound also closes if the target recieves magical healing.",
                    HitDamageType = "slashing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Bearded Devil", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Bearded Devil",
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

            OGLContent.OGL_Creatures.Add("Bearded Devil");
        }
    }
}
