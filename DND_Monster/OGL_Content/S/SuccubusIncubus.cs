using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class SuccubusIncubus
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Telepathic Bond", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} ignores the range restriction on its telepathy when communicating with a creature it has charmed. The two don't even need to be on the same plane of existence." },
                new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its actions to polymorph into a Small or Medium humanoid, or back into its true form. Without wings, the {CREATURENAME} loses its flying speed. Other than its size and speed, its statistics are the same in each form. Any equipment it is wearing or carrying isn't transformed. It reverts to its true form if it dies." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Claw (Fiend Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "5",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 6,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                 new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Charm", isDamage = false, isSpell = false, saveDC = 0, Description = "One humanoid the {CREATURENAME} can see within 30 feet of it must succeed on a DC 15 Wisdom saving throw or be magically charmed for 1 day. The charmed target obeys the {CREATURENAME}'s verbal or telepathic commands. If the target suffers any harm or receives a suicidal command, it can repeat the saving throw, ending the effect on a success. If the target successfully saves against the effect, or if the effect on it ends, the target is immune to this {CREATURENAME}'s Charm for the next 24 hours. </br> The {CREATURENAME} can only have one target charmed at a time. If it charms another, the effect on the previous target ends."},      
                 new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Draining Kiss", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} kisses a creature charmed by it or a willing creature. The target must makes a DC 15 Constitution saving throw against this magic, taking 32 (5d10 + 5) psychic damage on a failed save, or half as much damage on a successful one. The target's hit point maximum is reduced by an amount equal to the damage taken. This reduction lasts until the target finishes a long rest. The target dies if this effect reduces its hit point maximum to 0."},      
                 new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "Etheralness", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically enters the Ethereal Plane from the Material Plane, or vice versa."},      
            });

            // new OGL_Ability() { OGL_Creature = "Succubus / Incubus", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Succubus / Incubus",
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

            OGLContent.OGL_Creatures.Add("Succubus / Incubus");
        }
    }
}
