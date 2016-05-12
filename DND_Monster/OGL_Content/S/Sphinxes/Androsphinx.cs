using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Androsphinx
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Inscrutable", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is immune to anny effect that woudl sense its emotions or read its thoughts as well as any divination spell that it refuses. Wisdom (Insight) checks made to ascertain the {CREATURENAME}'s intentions or sincerity have disadvantage." },
                new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
                new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 18, 
                Description = "cleric|Wisdom|12|NotInnate|4,3,3,3,2,1,0,0,0|0:sacred flame,0:spare the dying,0:thamaturgy,1:command,1:detect evil and good,1:detect magic,2:lesser restoration,2:zone of truth,3:dispel magic,3:tongues,4:banishment,4:freedom of movement,5:flame strike,5:greater restoration,6:heroes' feast,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two claw attacks."},      
                 new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Claw", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "12",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 10,
                    HitDamageBonus = 6,
                    HitAverageDamage = 17,
                    HitText = "",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "Roar (3/Day)", isDamage = false, isSpell = false, saveDC = 0, 
                    Description = "The {CREATURENAME} emits a magical roar. Each time it roars before finishing a long rest, the roar is louder and the effect is different, as detailed below. Each creature within 500 feet of the {CREATURENAME} and able to hear the roar must make a saving throw.</br>" +
                    "<b>First Roar.</b> Each creature that fails a DC 18 Wisdom saving throw is frightened for 1 minute. A frightened creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success</br>" +
                    "<b>Second Roar.</b> Each creature that fails a DC 18 Wisdom saving throw is deafened and frightened for 1 minute. A frightened creature is paralyzed and can releat the saving throw at the end of each of its turns, ending the effecton itself on a success.</br>" +
                    "<b>Third Roar.</b> Each creature makes a DC 18 Constitution saving throw. On a failed save, a creature takes 44 (8d10) thunder damage and is knocked prone. On a successful save, the creature takes half as much damage and isn't knocked prone."},      
            });

            // new OGL_Ability() { OGL_Creature = "Androsphinx", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Androsphinx",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")  
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Androsphinx",
                    Title = "Androsphinx Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Claw Attack.", "The {CREATURENAME} makes one claw attack."),  
                        new LegendaryTrait("Teleport (Costs 2 Actions).", "The {CREATURENAME} magically teleports, along with any equipment it is wearing or carrying, up to 120 feet to an unoccupied space it can see."),
                        new LegendaryTrait("Cast a Spell (Costs 3 Actions).", "The {CREATURENAME} casts a spell from its list of prepared spells, using a spell slot as normal."),                  
                    }
                },   
            });

            OGLContent.OGL_Creatures.Add("Androsphinx");
        }
    }
}
