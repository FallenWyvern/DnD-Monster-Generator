using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Sprite
    {
        public static void Add()
        {
            // new OGL_Ability() {OGL_Creature = "Sprite", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() {OGL_Creature = "Sprite", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
            });

            // template
            #region
            // new OGL_Ability() {OGL_Creature = "Sprite", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() {OGL_Creature = "Sprite", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() {OGL_Creature = "Sprite", Title = "Longsword", isDamage = false, isSpell = false, saveDC = 0, Description = "<i>Melee Weapon Attack</i>: +2 to hit, reach 5 ft., one target. <i>Hit</i>: 1 slashing damage."},    
                new OGL_Ability() {OGL_Creature = "Sprite", Title = "Shortbow", isDamage = false, isSpell = false, saveDC = 0, Description = "<i>Ranged Weapon Attack</i>: +6 to hit, range 40/160 ft., one target. <i>Hit</i>: 1 piercing damage and the target must succeed on a DC 10 Constitution saving throw or become poisoned for 1 minute. If its saving throw result is 5 or lower, the poisoned target falls unconscious for the same duration, or until it takes damage or another creature takes an action to shake it awake."},    
                new OGL_Ability() {OGL_Creature = "Sprite", Title = "Heart Sight", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} touches a creature and magically knows the creature's current emotional state. If the target fails a DC 10 Charisma saving throw, the sprite also knows the creature's alignment. Celestials, fiends, and undead automatically fail the saving throw."},      
                new OGL_Ability() {OGL_Creature = "Sprite", Title = "Invisibility", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically turns invisible until it attacks or casts a spell, or until its concentration ends (as if concentrating on a spell). Any equipment the {CREATURENAME} wears or carries is invisible with it."},      
            });

            // new OGL_Ability() {OGL_Creature = "Sprite", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //   OGL_Creature = "Sprite",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Sprite");
        }
    }
}
