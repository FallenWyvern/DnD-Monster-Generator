using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    static public class Planetar
    {
        public static void Add()
        {
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Planetar", Title = "Angelic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical. When the {CREATURENAME} hits with any weapon, the weapon deals an extra 5d8 radiant damage (included in the attac)." },
                new OGL_Ability() { OGL_Creature = "Planetar", Title = "Divine Awareness", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} knows if it hears a lie." },
                new OGL_Ability() { OGL_Creature = "Planetar", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 20, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect good and evil,0:invisibility (self only),1:commune,1:control weather,1:insect plague,3:blade barrier,3:dispel evil and good,3:flame strike,3:raise dead,|" },
                new OGL_Ability() { OGL_Creature = "Planetar", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." }
            });

            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {
                 new OGL_Ability() { OGL_Creature = "Planetar", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two melee attacks."},      
                 new OGL_Ability() { OGL_Creature = "Planetar", Title = "Greatsword", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Weapon Attack",
                    Bonus = "12",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 4,
                    HitDiceSize = 6,
                    HitDamageBonus = 7,
                    HitAverageDamage = 21,
                    HitText = "plus 22 (5d8) radiant damage.",
                    HitDamageType = "slashing"
                }
                },  
                new OGL_Ability() { OGL_Creature = "Planetar", Title = "Healing Touch (4/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} touches another creature. The target magically regains 30 (6d8 + 3) hit points and is freed from any curse, disease, poison, blindness or deafness."},      
            });

            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {

            });

            OGLContent.OGL_Creatures.Add("Planetar");
        }
    }
}
