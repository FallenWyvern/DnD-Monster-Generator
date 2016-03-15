using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Solar
    {
        public static void Add()
        {
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Angelic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical. When the {CREATURENAME} hits with any weapon, the weapon deals an extra 6d8 radiant damage (included in the attac)." },
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Divine Awareness", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} knows if it hears a lie." },
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 25, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect good and evil,0:invisibility (self only),1:commune,1:control weather,3:blade barrier,3:dispel evil and good,3:resurrection,|" },
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." }
            });

            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two greatsword attacks."},      
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Greatsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "15",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 6,
                    HitDamageBonus = 8,
                    HitAverageDamage = 22,
                    HitText = "plus 27 (6d8) radiant damage.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Slaying Longbow", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Ranged Weapon Attack",
                    Bonus = "13",
                    Reach = 0,
                    RangeClose = 150,
                    RangeFar = 600,
                    Target = "one target",
                    HitDiceNumber = 2,
                    HitDiceSize = 8,
                    HitDamageBonus = 6,
                    HitAverageDamage = 15,
                    HitText = "plus 27 (6d8) radiant damage. If the target is a creature that has 100 hit points of fewer, it must succeed on a DC 15 Constitution saving throw or die.",
                    HitDamageType = "piercing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Flying Sword", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} releases its greatsword to hover magically in an unoccupied space within 5 feet of it. If the {CREATURENAME} can see the sword, the {CREATURENAME} can mentally command it as a bonus action to fly up to 50 feet and either make one attack against a target or to return to the {CREATURENAME}'s hands. If the hovering sword is targeted by any effect, the {CREATURENAME} is considered to be holding it. The hovering sword falls if the {CREATURENAME} dies."},      
                new OGL_Ability() { OGL_Creature = "Solar", Title = "Healing Touch (4/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} touches another creature. The target magically regains 40 (8d8 + 4) hit points and is freed from any curse, disease, poison, blindness or deafness."},                  
            });

            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Solar",
                    Title = "Solar Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Teleport", "The {CREATURENAME} magically teleports, along with any equipment it is wearing or carrying, up to 120 feet to an unoccupied space it can see."),                    
                        new LegendaryTrait("Searing Burst (Costs 2 Actions)", "The {CREATURENAME} emits magical, divine energy. Each creature of its choice in a 10-foot radius must make a DC 23 Dexterity saving throw, taking 14 (4d6) fire damage plus 14 (4d6) radiant damage on a failed save, or half as much damage on a successful save."),
                        new LegendaryTrait("Blinding Gaze (Costs 3 Actions)", "The {CREATURENAME} targets one creature it can see within 30 feet of it. If the target can see it, the target must succeed on a DC 15 Constitution saving throw or be blinded until magic such as <i>lesser restoration</i> spell removes the blindness.")
                    }
                }, 
            });

            OGLContent.OGL_Creatures.Add("Solar");
        }
    }
}
