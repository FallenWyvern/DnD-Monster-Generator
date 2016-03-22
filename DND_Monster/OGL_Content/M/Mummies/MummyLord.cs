using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class MummyLord
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Rejuvenation", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
                new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                 Description = "cleric|Wisdom|10|NotInnate|4,3,3,3,2,1,0,0,0|" +
                 "0:sacred flame,0:thaumaturgy,1:command,1:guiding bolt,1:shield of faith,2:hold person,2:silence,2:spiritual weapon," + 
                 "3:animate dead,3:dispel magic,4:divination,4:guardian of faith,5:contagion,5:insect plague,6:harm,|" },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can use its Dreadful Glare and makes one attack with its rotting fist."},      
                 new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Rotting Fist", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 3,
                    HitAverageDamage = 14,
                    HitText = "plus 21 (6d6) necrotic damage. If the target is a creature, it must succeed on a DC 16 Constitution saving throw or be cursed with mummy rot. The cursed target can't regain hit points, and its hit point maximum decreases by 10 (3d6) for every 24 hours that elapse. If the curse reduces the target's hit point maximum to 0, the target dies, and its body turns to dust. The curse lasts until removed by the <i>remove curse</i> spell or other magic.",
                    HitDamageType = "bludgeoning"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "Dreadful Glare", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} targets one creature it can see within 60 feet of it. If the target can see the {CREATURENAME}, it must succeed on a DC 16 Wisdom saving throw against this magic or become frightened until the end of the {CREATURENAME}'s next turn. If the target fails the saving throw by 5 or more, it is also paralyzed for the same duration. A target that succeeds on the saving throw is immune to the Dreadful Glare of all mummies and mummy lords for the next 24 hours."},      
            });

            // new OGL_Ability() { OGL_Creature = "Mummy Lord", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Mummy Lord",
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
                    OGL_Creature = "Mummy Lord",
                    Title = "Mummy Lord Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Attack", "The {CREATURENAME} makes one attack with its rotting fist or uses its Dreadful Glare"),                    
                        new LegendaryTrait("Blinding Dust", "Blinding dust and sand swirls magically around the {CREATURENAME}. Each creature within 5 feet of teh {CREATURENAME} must succeed on a DC 16 Constitution saving throw or be blinded until the end of the creature's next turn."),                    
                        new LegendaryTrait("Blasphemous Word (Costs 2 Actions)", "The {CREATURENAME} utters a blasphemous word. Each non-undead creature within 10 feet of the {CREATURENAME} that can hear the magical utterance must succeed on a DC 16 Constitution saving throw or be stunned until the end of the {CREATURENAME}'s next turn."),                    
                    }
                },     
            });

            OGLContent.OGL_Creatures.Add("Mummy Lord");
        }
    }
}
