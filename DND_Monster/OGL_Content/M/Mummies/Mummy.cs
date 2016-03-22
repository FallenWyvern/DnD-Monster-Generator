using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Mummy
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Mummy", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Mummy", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Mummy", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Mummy", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Mummy", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Dreadful Glare and makes one attack with its rotting fist."},      
                 new OGL_Ability() { OGL_Creature = "Mummy", Title = "Rotting Fist", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 10,
                    HitText = "plus 10 (3d6) necrotic damage. If the target is a creature, it must succeed on a DC 12 Constitution saving throw or be cursed with mummy rot. The cursed target can't regain hit points, and its hit point maximum decreases by 10 (3d6) for every 24 hours that elapse. If the curse reduces the target's hit point maximum to 0, the target dies, and its body turns to dust. The curse lasts until removed by the <i>remove curse</i> spell or other magic.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Mummy", Title = "Dreadful Glare", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} targets one creature it can see within 60 feet of it. If the target can see the {CREATURENAME}, it must succeed on a DC 11 Wisdom saving throw against this magic or become frightened until the end of the {CREATURENAME}'s next turn. If the target fails the saving throw by 5 or more, it is also paralyzed for the same duration. A target that succeeds on the saving throw is immune to the Dreadful Glare of all mummies (but not mummy lords) for the next 24 hours."},      
            });

            // new OGL_Ability() { OGL_Creature = "Mummy", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Mummy",
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

            OGLContent.OGL_Creatures.Add("Mummy");
        }
    }
}
