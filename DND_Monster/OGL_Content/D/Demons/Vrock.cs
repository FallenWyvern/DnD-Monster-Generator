using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Vrock
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Vrock", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Vrock", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Vrock", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Vrock", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Vrock", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its beak and one with its talons."},      
                 new OGL_Ability() { OGL_Creature = "Vrock", Title = "Beak", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "6",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Vrock", Title = "Talons", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "1",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 3,
                    HitAverageDamage = 14,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Vrock", Title = "Spores (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "A 15-foot-radius cloud of toxic spores extends out from the {CREATURENAME}. The spores spread around corners. Each creature in that area must succeed on a DC 14 Constitution saving throw or become poisoned. While poisoned in this way, a target takes 5 (1d10) poison damage at the start of each of its turns. A target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. Emptying a vial of holy water on the target also ends the effect on it."},      
                new OGL_Ability() { OGL_Creature = "Vrock", Title = "Stunning Screech (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} emits a horrific screech. Each creature within 20 feet of it that can hear it and that isn't a demon must succeed on a DC 14 Constitution saving throw or be stunned until the end of the {CREATURENAME}'s next turn."},      
            });

            // new OGL_Ability() { OGL_Creature = "Vrock", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Vrock",
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

            OGLContent.OGL_Creatures.Add("Vrock");
        }
    }
}
