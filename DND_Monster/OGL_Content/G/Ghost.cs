using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Ghost
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Ghost", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Ghost", Title = "Ethereal Sight", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can see 60 feet into the Ethereal Plane when it is on the Material Plane, and vice versa." },
                new OGL_Ability() { OGL_Creature = "Ghost", Title = "Incorporeal Movement", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can move through other creatures and objects as if they were difficult terrain. It takes 5 (1d10) force damage if it ends its turn inside an object." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Ghost", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Ghost", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Ghost", Title = "Withering Touch", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "necrotic"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Ghost", Title = "Etherealness", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} enters the Ethereal Plane from the Material Plane, or vice versa. It is visible on the Material Plane while it is in the Border Ethereal, and vice versa, yet it can't affect or be affected by anything on the other plane."},      
                new OGL_Ability() { OGL_Creature = "Ghost", Title = "Horrifying Visage", isDamage = false, isSpell = false, saveDC = 0, Description = "Each non-undead creature within 60 feet of the {CREATURENAME} that can see it must succeed on a DC 13 Wisdom saving throw or be frightened for 1 minute. If the save fails by 5 or more, the target also ages 1d4 x 10 years. A frightened target can repeat the saving throw at the end of each of its turns, ending the frightened condition on itself on a success. If a target's saving throw is successful or the effect ends for it, the target is immune to this {CREATURENAME}'s Horrifying Visage for the next 24 hours. The aging effect can be reversed with a <i>greater restoration</i> spell, but only within 24 hours of occurring."},      
                new OGL_Ability() { OGL_Creature = "Ghost", Title = "Possession (Recharge 6)", isDamage = false, isSpell = false, saveDC = 0, Description = "One humanoid that the {CREATURENAME} can see within 5 feet of it must succeed on a DC 13 Charisma saving throw or be possessed by the {CREATURENAME}; the {CREATURENAME} then disappears, and the target is incapacitated and loses control of its body. The {CREATURENAME} now controls the body but doesn't deprive the target of awareness. The {CREATURENAME} can't be targeted by any attack, spell, or other effect, except ones that turn undead, and it retains its alignment, Intelligence, Wisdom, Charisma and immunity to being charmed and frightened. It otherwise uses the possessed creature's statistics, but doesn't gain access to the target's knowledge, class features or proficiencies. The possession lasts until the body drops to 0 hit points, the {CREATURENAME} ends it as a bonus action, or the ghost is turned or forced out by an effect like the <i>dispel evil and good</i> spell. When the possession ends, the {CREATURENAME} reappears in an unoccupied space within 5 feet of the body. The target is immune to this {CREATURENAME}'s Possession for 24 hours after succeeding on the saving throw after the possession ends."},      
            });

            // new OGL_Ability() { OGL_Creature = "Ghost", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Ghost",
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

            OGLContent.OGL_Creatures.Add("Ghost");
        }
    }
}
