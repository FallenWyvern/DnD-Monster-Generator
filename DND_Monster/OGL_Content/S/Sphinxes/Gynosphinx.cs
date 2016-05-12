using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Gynosphinx
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "Inscrutable", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is immune to anny effect that woudl sense its emotions or read its thoughts as well as any divination spell that it refuses. Wisdom (Insight) checks made to ascertain the {CREATURENAME}'s intentions or sincerity have disadvantage." },
                new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
                new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                    Description = "wizard|Intelligence|9|NotInnate|4,3,3,3,1,0,0,0,0|0:mage hand,0:minor illusion,0:prestidigitation,1:detect magic,1:identify,1:shield,2:darkness,2:locate object,2:suggestion,3:dispel magic,3:remove curse,3:tongues,4:banishment,4:greater invisibility,5:legend lore,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two claw attacks."},      
                 new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "8",
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
            });

            // new OGL_Ability() { OGL_Creature = "Gynosphinx", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Gynosphinx",
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
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Gynosphinx",
                    Title = "Gynosphinx Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Claw Attack.", "The {CREATURENAME} makes one claw attack."),  
                        new LegendaryTrait("Teleport (Costs 2 Actions).", "The {CREATURENAME} magically teleports, along with any equipment it is wearing or carrying, up to 120 feet to an unoccupied space it can see."),
                        new LegendaryTrait("Cast a Spell (Costs 3 Actions).", "The {CREATURENAME} casts a spell from its list of prepared spells, using a spell slot as normal."),                    
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Gynosphinx");
        }
    }
}
