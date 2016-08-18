using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    // {CREATURENAME}
    public static class Vampire
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Vampire", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Vampire", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Shapechanger", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} isn't in sunlight or running water, it can use its action to polymorph into a Tiny bat or Medium cloud of mist, or back to its true form.</br>While in bat form, the {CREATURENAME} can't speak, its walking speed is 5 feet, and it has a flying speed of 30 feet. Its statistics, other than its size and speed, are unchanged. Anything it is wearing transforms with it, but nothing it is carrying does. It reverts to its true form if it dies.</br>While in mist form, the {CREATURENAME} can't take any actions, speak, or manipulate objects. It is weightless, has a flying speed of 20 feet, can hover and can enter a hostile creature's space and stop there. In addition if air can pass through a space, the mist can do so without squeezing, and it can't pass through water. It has advantage on Strength, Dexterity, and Constitution saving throws, and it is immune to all nonmagical damage, except the damage it takes from sunlight." },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Legendary Resistance (3/Day)", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "If the {CREATURENAME} fails a saving throw, it can choose to succeed instead." },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Misty Escape", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "When it drops to 0 hit points outside its resting place, the {CREATURENAME} transofrms into a cloud of mist (as in the Shapechanger trait) instead of falling unconscious, provided that it isn't in sunlight or running water. If it can't transform, it is destroyed.</br>While it has 0 hit points in mist form, it can't revert to its {CREATURENAME} form, and it must reach its resting place within 2 hours or be destroyed. Once in its resting place, it reverts to its {CREATURENAME} form. It is then paralyzed until it regains at least 1 hit point. After spending 1 hour in its resting place with 0 hit points, it regains 1 hit point." },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Regeneration", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} regains 20 hit points at the start of its turn if it has at least 1 hit point and isn't in sunlight or running water. If the {CREATURENAME} takes radiant damage or damage from holy water, this trait doesn't function at the start of the {CREATURENAME}'s next turn." },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Spider Climb", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check." },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Vampire Weaknesses", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has the following flaws:</br><i>Forbiddance.</i> The {CREATURENAME} can't enter a residence without an invitation from one of the occupants.</br><i>Harmed by Running Water.</i> The {CREATURENAME} takes 20 acid damage if it ends its turn in running water.</br><i>Stake to the Heart.</i> If a piercing weapon made of wood is driven into the {CREATURENAME}'s heart while the {CREATURENAME} is incapacitated in its resting place, the {CREATURENAME} is paralyzed until the stake is removed.</br><i>Sunlight Hypersensitivity.</i> The {CREATURENAME} takes 20 radiant damage when it starts its turn in sunlight. While in sunlight, it has disadvantage on attack rolls and ability checks." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Vampire", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Vampire", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Multiattack (Vampire Form Only)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two attacks, only one of which can be a bite attack."},
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Unarmed Strike (Vampire Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                {
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one creature",
                    HitDiceNumber = 1,
                    HitDiceSize = 8,
                    HitDamageBonus = 4,
                    HitAverageDamage = 8,
                    HitText = "Instead of dealing damage, the {CREATURENAME} can grapple the target (escape DC 18).",
                    HitDamageType = "bludgeoning"
                }
                },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Bite (Bat or Vampire Form Only)", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                {
                    _Attack = "Melee Weapon Attack",
                    Bonus = "9",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one willing creature, or a creature that is grappled by the {CREATURENAME}, incapacitated or restrained.",
                    HitDiceNumber = 1,
                    HitDiceSize = 6,
                    HitDamageBonus = 4,
                    HitAverageDamage = 7,
                    HitText = "plus 10 (3d6) necrotic damage. The target's hit point maximum is reduced by an amount equal to the necrotic damage taken, and the {CREATURENAME} regains hit points equal to that amount. The reduction lasts until the target finishes a long rest. The target dies if this effect reduces its hit point maximum to 0. A humanoid slain in this way and then buried in the ground rises the following night as a {CREATURENAME} spawn under the {CREATURENAME}'s control.",
                    HitDamageType = "piercing"
                }
                },
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Charm", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} targets one humanoid it can see within 30 feet of it. If the target can see the {CREATURENAME}, the target must succeed on a DC 17 Wisdom saving throw against this magic or be charmed by the {CREATURENAME}. The charmed target regards the {CREATURENAME} as a trusted friend to be heeded and protected. Although the target isn't under the {CREATURENAME}'s control, it takes the {CREATURENAME}'s requests or actions in the most favourable way it can, and is a willing target for the {CREATURENAME}'s bite attack.</br>Each time the {CREATURENAME} or the {CREATURENAME}'s companions do anything harmful to the target, it can repeat the saving throw, ending the effect on itself on a success. Otherwise, the effect lasts 24 hours or until the {CREATURENAME} is destroyed, is on a different plane of existence than the target, or takes a bonus action to end the effect."},
                new OGL_Ability() { OGL_Creature = "Vampire", Title = "Children of the Night (1/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically calls 2d4 swarms of bats or rats, provided that the sun isn't up. While outdoors, the {CREATURENAME} can call 3d6 wolves instead. The called creatures arrive in 1d4 rounds, acting as allies of the {CREATURENAME} and obeying its spoken commands. The beasts remain for 1 hour, until the {CREATURENAME} dies, or until the {CREATURENAME} dismisses them as a bonus action."},
            });

            // new OGL_Ability() { OGL_Creature = "Vampire", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Vampire",
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
                    OGL_Creature = "Vampire",
                    Title = "Vampire Legendary Actions",
                    Traits = new List<LegendaryTrait>()
                    {
                        new LegendaryTrait("Move", "The {CREATURENAME} moves up to its speed without provoking opportunity attacks."),
                        new LegendaryTrait("Unarmed Strike", "The {CREATURENAME} makes one unarmed strike."),
                        new LegendaryTrait("Bite (Costs 2 Actions)", "The {CREATURENAME} makes one bite attack."),
                    }
                },
            });

            OGLContent.OGL_Creatures.Add("Vampire");
        }
    }
}
