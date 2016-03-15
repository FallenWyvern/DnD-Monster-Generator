using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Nalfeshnee
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} uses Horror Nimbus if it can. It then makes three attacks: one with its bite and two with its claws."},      
                 new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 5,
                    HitDiceSize = 10,
                    HitDamageBonus = 5,
                    HitAverageDamage = 32,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },                  
                 new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "10",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 5,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "Horror Nimbus (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically emits scintillating, multicolored light. Each creature within 15 feet of the {CREATURENAME} that can see the light must succeed on DC 15 Wisdom saving throw or be frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the {CREATURENAME}'s Horror Nimbus for the next 24 hours."},      
                new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "Teleport", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically teleports, along iwth any equipment it is wearing or carrying, up to 120 feet to an unoccupied space it can see."},      
            });

            // new OGL_Ability() { OGL_Creature = "Nalfeshnee", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Nalfeshnee",
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

            OGLContent.OGL_Creatures.Add("Nalfeshnee");
        }
    }
}
