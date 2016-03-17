using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class NightHag
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Night Hag", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Night Hag", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 13, 
                Description = "bard|Wisdom|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:magic missile,2:plane shift (self only),2:ray of enfeeblement,2:sleep,|" },
                new OGL_Ability() { OGL_Creature = "Night Hag", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells or other magical effects." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Night Hag", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Night Hag", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Night Hag", Title = "Claws (Hag Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 13,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Night Hag", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a Small or Medium female humanoid, or back into its true form. Its statistics are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies."},      
                new OGL_Ability() { OGL_Creature = "Night Hag", Title = "Etherealness", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically enters the Ethereal Plane from the Material Plane, or vice versa. To do so, the {CREATURENAME} must have a <i>heartstone</i> in its possession."},      
                new OGL_Ability() { OGL_Creature = "Night Hag", Title = "Nightmare Haunting (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "While on the Ethereal Plane, the {CREATURENAME} magically touches a sleeping humanoid on the Material Plane. A <i>protection from evil and good</i> spell cast on the target prevents this contact, as does a <i>magic circle</i>. As long as the contact persists, the target has dreadful visions. If these visions last at least 1 hour, the target gains no benefit from its rest, and its hit point maximum is reduced by 5 (1d10). If this effect reduces the target's hit point maximum to 0, the target dies and if the target was evil, its soul is trapped in the {CREATURENAME}'s <i>soul bag</i>. The reduction to the target's hit point maximum lasts until removed by the <i>greater restoration</i> spell or similar magic."},      
            });

            // new OGL_Ability() { OGL_Creature = "Night Hag", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Night Hag",
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

            OGLContent.OGL_Creatures.Add("Night Hag");
        }
    }
}
