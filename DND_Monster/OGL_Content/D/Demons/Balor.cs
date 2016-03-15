using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Balor
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Balor", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Death Throes", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When the {CREATURENAME} dies, it explodes and each creature within 30 feet of it must make a DC 20 Dexterity saving throw, taking 70 (20d6) fire damage on a failed save, or half as much damage on a successful one. The explosion ignites flammable objects in that area that aren't being worn or carried, and it destroys the {CREATURENAME}'s weapons." },
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Fire Aura", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "At the start of each of the {CREATURENAME}'s turns, each creature within 5 feet of it takes 10 (3d6) fire damage, and flammable objects in the aura that aren't being worn or carried ignite. A creature that touches the {CREATURENAME} or hits it with a melee attack while within 5 feet of it takes 10 (3d6) fire damage." },
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapons are magical." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Balor", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Balor", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks: one with its longsword and one with its whip."},      
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Longsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 10,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 8,
                    HitDamageBonus = 8,
                    HitAverageDamage = 21,
                    HitText = "plus 13 (3d8) lightning damage. If the {CREATURENAME} scores a critical hit, it rolls damage dice three times, instead of twice.",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Whip", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "14",
                    Reach = 30,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 6,
                    HitDamageBonus = 8,
                    HitAverageDamage = 15,
                    HitText = "plus 10 (3d6) fire damage, and the target must succeed at a DC 20 Strength saving throw or be pulled up to 25 feet toward the {CREATURENAME}.",
                    HitDamageType = "slashing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Balor", Title = "Teleport", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically teleports, along with any equipment it is wearing or carrying, up to 120 feet to an unoccupied space it can see."},      
            });

            // new OGL_Ability() { OGL_Creature = "Balor", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Balor",
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

            OGLContent.OGL_Creatures.Add("Balor");
        }
    }
}
