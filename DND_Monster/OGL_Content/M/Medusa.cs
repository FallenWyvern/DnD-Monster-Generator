using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Medusa
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Medusa", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Medusa", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Medusa", Title = "Petrifying Gaze", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When a creature that can see the {CREATURENAME}'s eyes starts its turn within 30 feet of the {CREATURENAME}, the {CREATURENAME} can force it to make a DC 14 Consitution saving throw if the {CREATURENAME} isn't incapacitated and can see the creature. If the saving throw fails by 5 or more, the creature is instantly petrified. Otherwise, a creature that fails its save begins to turn to stone and is restrained. The restrained creature must repeat the saving throw at the end of its next turn, becoming petrified on a failure or ending the effect on a success. The petrification lasts until the creature is freed by the <i>greater restoration</i> spell or other magic. </br> Unless surprised, a creature can avert its eyes to avoid the saving throw at the start of its turn. If the creature does so, it can't see the {CREATURENAME} until the start of its next turn, when it can avert its eyes again. If the creature looks at the {CREATURENAME} in the meantime, it must immediately make the save. </br> If the {CREATURENAME} sees itself reflected on a polished surface within 30 feet of it and in an area of bright light, the {CREATURENAME} is, due to its curse, affected by its own gaze." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Medusa", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Medusa", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Medusa", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes either three melee attacks - one with its snake hair and two with its shortsword - or two ranged attacks with its longbow."},      
                 new OGL_Ability() { OGL_Creature = "Medusa", Title = "Snake Hair", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 4,
                    HitDamageBonus = 2,
                    HitAverageDamage = 4,
                    HitText = "plus 14 (4d6) poison damage.",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Medusa", Title = "Shortsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 2,
                    HitAverageDamage = 5,
                    HitText = "",
                    HitDamageType = "piercing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Medusa", Title = "Longbow", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "5",
                    Reach = 0,
                    RangeClose = 150,
                    RangeFar = 600,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 2,
                    HitAverageDamage = 6,
                    HitText = "plus 7 (2d6) poison damage.",
                    HitDamageType = "Acid"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Medusa", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Medusa",
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

            OGLContent.OGL_Creatures.Add("Medusa");
        }
    }
}
