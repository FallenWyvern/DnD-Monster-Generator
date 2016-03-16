using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class FireElemental
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "Fire Form", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can move through a space as narrow as 1 inch wide without squeezing. A creature that touches the {CREATURENAME} or hits it with a melee attack while within 5 feet of it takes 5 (1d10) fire damagage. In addition, the {CREATURENAME} can enter a hostile creature's space and stop there. The first time it enters a creature's space on a turn, that creature takes 5 (1d10) fire damage and catches fire; until someone takes an action to douse the fire, the creature takes 5 (1d10) fire damage at the start of each of its turns." },
                new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "Illumination", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} sheds bright light in a 30-foot radius and dim light in an additional 30 feet." },
                new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "Water Susceptibility", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "For ever 5 feet the elemental moves in water, or for ever gallon of water splashed on it, it takes 1 cold damage." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two touch attacks."},      
                 new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                    HitText = "If the target is a creature or a flammable object, it ignites. Until a creature takes an action to douse the fire, the target takes 5 (1d10) fire damage at the start of each of its turns.",
                    HitDamageType = "fire"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Fire Elemental", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Fire Elemental",
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

            OGLContent.OGL_Creatures.Add("Fire Elemental");
        }
    }
}
