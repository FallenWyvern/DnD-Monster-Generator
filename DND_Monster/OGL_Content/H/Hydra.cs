using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Hydra
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Hydra", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Hydra", Title = "Hold Breath", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can hold its breath for 1 hour." },
                new OGL_Ability() { OGL_Creature = "Hydra", Title = "Multiple Heads", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has five heads. While it has more than one head, the {CREATURENAME} has advantage on saving throws against being blinded, charmed, deafened, frightened, stunned and knocked unconscious. </br> Whenever the {CREATURENAME} takes 25 or more damage in a single turn, one of its heads dies. If all of its heads die, the {CREATURENAME} dies. </br> At the end of its turn, it grows two heads for each of its heads that died since its last turn, unless it has taken fire damage since its last turn. The {CREATURENAME} regains 10 hit points for each head regrown this way." },
                new OGL_Ability() { OGL_Creature = "Hydra", Title = "Reactive Heads", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "For each head the {CREATURENAME} has beyond one, it gets an extra reaction that can only be used for opportunity attacks." },
                new OGL_Ability() { OGL_Creature = "Hydra", Title = "Wakeful", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "While the {CREATURENAME} sleeps, at least one of its heads is awake." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Hydra", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Hydra", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Hydra", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes as many bite attacks as it has heads."},      
                 new OGL_Ability() { OGL_Creature = "Hydra", Title = "Bite", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 10,
                    HitDamageBonus = 5,
                    HitAverageDamage = 10,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Hydra", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Hydra",
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

            OGLContent.OGL_Creatures.Add("Hydra");
        }
    }
}
