using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class GibberingMouther
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "Aberrant Ground", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The ground in a 10-foot radius around the {CREATURENAME} is doughlike difficult terrain. Each creature that starts its turn in that area must succeed on a DC 10 Strength saving throw or have its speed reduced to 0 until the start of its next turn." },
                new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "Gibbering", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} babbles incoherently while it can see any creature that isn't incapacitated. Each creature that starts its turn within 20 feet of the {CREATURENAME} and can hear the gibbering must succeed on a DC 10 Wisdom saving throw. On a failure, the creature can't take reactions until the start of its next turn and rolls a d8 to determine what it does on its turn. On a 1 to 4, the creature does nothing. On a 5 or 6, the creature takes no action or bonus action and uses it's movement to move in a randomly determined direction. On a 7 or 8, the creature makes a melee attack against a randomly determined creature within its reach or does nothing if it can't make such an attack." },                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes one bite attack and, if it can, uses its Blinding Spittle."},      
                 new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "Bites", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "2",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 5,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 17,
                    HitText = "If the target is MEdium or smaller, it must succeed on a DC 10 Strength saving throw or be knocked prone. If the target is killed by this damage, it is absorbed into the {CREATURENAME}.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "Blinding Spittle (Recharge 5-6)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} spits a chemical glob at a point it can see wtihin 15 feet of it. The glob explodes in a blinding flash of light on impact. Each creature within 5 feet of ht eflash must succeed on a DC 13 Dexterity saving throw or be blinded at the end of the {CREATURENAME}'s next turn."},      
            });

            // new OGL_Ability() { OGL_Creature = "Gibbering Mouther", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Gibbering Mouther",
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

            OGLContent.OGL_Creatures.Add("Gibbering Mouther");
        }
    }
}
