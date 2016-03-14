using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Bulette
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Bulette", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Bulette", Title = "Standing Leap", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s long jump is up to 30 feet and its high jump is up to 15 feet, with or without a running start." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Bulette", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Bulette", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Bulette", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 12,
                    HitDamageBonus = 4,
                    HitAverageDamage = 30,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                }, 
                new OGL_Ability() { OGL_Creature = "Bulette", Title = "Deadly Leap", isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} jumps at least 15 feet as part of its movement, it can then use this action to land on its feet in a space that contains one or more other creatures. Each of those creatures must succeed on a DC 16 Strength or Dexterity saving throw (target's choice) or be knocked prone and take 14 (3d6 + 4) bludgeoning damage plus 14 (3d6 + 4) slashing damage. On a successful save, the creature takes only half the damage, isn't knocked prone, an dis pushed 5 feet out of the {CREATURENAME}'s space into an unoccupied space of the creature's choice. If no unoccupied space is within range, the creature instead falls prone in the {CREATURENAME}'s space."},      
            });

            // new OGL_Ability() { OGL_Creature = "Bulette", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Bulette",
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

            OGLContent.OGL_Creatures.Add("Bulette");
        }
    }
}
