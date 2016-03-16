using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class FleshGolem
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Berserk", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Whenever the {CREATURENAME} starts its turn with 40 hit points or fewer, roll a d6. On a 6, the {CREATURENAME} goes berserk. On each of its turns while berserk, the {CREATURENAME} attacks the nearest creature it can see. If no creature is near enough to move to and attack, the {CREATURENAME} attacks an object, with preference for an object smaller than itself. Once the {CREATURENAME} goes berserk, it continues to do so until destroyed or regains all its hit points. </br> The {CREATURENAME}'s creator, if within 60 feet of the berserk {CREATURENAME}, can try to calm it by speaking firmly and persuasively. The {CREATURENAME} must be able to hear its creator, who must take an action to make a DC 15 Charisma (Persuasion) check. If the check succeeds, the {CREATURENAME} ceases being berserk. If it takes damage while still at 40 hit points or fewer, the {CREATURENAME} might go berserk agan." },
                new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Aversion of Fire", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} takes fire damage, it has disadvantage on attack rolls and ability checks until the end of its next turn." },
                new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Immutable Form", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} is immune to any spell or effect that would alter its form." },
                new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Lightning Absorption", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "Whenever the {CREATURENAME} is subjected to lightning damage, it takes no damage and instead regains a number of hit points equal to the lightning damage instead." },
                new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." },
                new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Magic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two slam attacks."},      
                 new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "Slam", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "7",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 13,
                    HitText = "",
                    HitDamageType = "bludgeoning"
                }
                },
            });

            // new OGL_Ability() { OGL_Creature = "Flesh Golem", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Flesh Golem",
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

            OGLContent.OGL_Creatures.Add("Flesh Golem");
        }
    }
}
