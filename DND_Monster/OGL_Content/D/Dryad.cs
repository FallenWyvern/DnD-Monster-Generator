using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Dryad
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Dryad", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Dryad", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 13, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:druidcraft,1:barkskin,1:pass without trace,1:shillelagh,3:entangle,3:goodberry,|" },
                new OGL_Ability() { OGL_Creature = "Dryad", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Dryad", Title = "Speak with Beasts and Plants", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can communicate with beasts and plants as if they shared a language." },
                new OGL_Ability() { OGL_Creature = "Dryad", Title = "Tree Stride", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Once on its turn, the {CREATURENAME} can use 10 feet of its movement to step magically into one living tree within its reach and emerge from a second living tree within 60 feet of the first tree, appearing in an unoccupied space within 5 feet of the second tree. Both trees must be Large or bigger." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Dryad", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Dryad", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Dryad", Title = "Club", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "2 to hit (+6 to hit with <i>shillelagh</i>), ",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 0,
                    HitAverageDamage = 2,
                    HitText = "or 8 (1d8 + 4) bludgeoning damage with <i>shillelagh</i>.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Dryad", Title = "Fey Charm", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} targets one humanoid or beast that it can see within 30 feet of it. If the target can see the {CREATURENAME}, it must succeed on a DC 14 Wisdom saving throw or be magically charmed. The charmed creature regards the {CREATURENAME} as a trusted friend to be heeded and protected. Although the target isn't under the {CREATURENAME}'s control, it takes the {CREATURENAME}'s request or actions in the most favorable way it can. </br> Each time the {CREATURENAME} or its allies do anything harmful to the target, it can repeat the saving throw, ending the effect on itself on a success. Otherwise, the effect lasts 24 hours, or until the {CREATURENAME} dies, is on a different plane of existence from the target, or ends the effect as a bonus action. If a target's saving throw is successful, the target is immune to the {CREATURENAME}'s Fey Charm for the next 24 hours. </br> The {CREATURENAME} can have no more than one humanoid and up to three beasts charmed at the same time."},      
            });

            // new OGL_Ability() { OGL_Creature = "Dryad", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Dryad",
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

            OGLContent.OGL_Creatures.Add("Dryad");
        }
    }
}
