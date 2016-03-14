using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Deva
    {
        static public void Add()
        {
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>() {
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Angelic Weapons", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME}'s weapon attacks are magical. When the {CREATURENAME} hits with any weapon, the weapon deals an extra 4d8 radiant damage (included in the attack)." },
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
                Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect good and evil,1:commune,1:raise dead,|" },
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Magic Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against spells and other magical effects." }
            });

            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>() {
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Multiattack", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} makes two melee attacks."},      
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Mace", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
            { 
                _Attack = "Melee Weapon Attack",
                Bonus = "8",
                Reach = 5,
                RangeClose = 0,
                RangeFar = 0,
                Target = "one target",
                HitDiceNumber = 1,
                HitDiceSize = 6,
                HitDamageBonus = 4,
                HitAverageDamage = 7,
                HitText = "plus 18 (4d8) radiant damage.",
                HitDamageType = "bludgeoning"
            }
            }, 
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Healing Touch (3/Day)", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} touches another creature. The target magically regains 20 (4d8+2) hit points and is freed from any curse, disease, poison, blindness, or deafness."},      
            new OGL_Ability() { OGL_Creature = "Deva", Title = "Change Shape", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} magically polymorphs into a humanoid or beast with a challenge rating equal to or less than its own, or back into its true form. It reverts to its true form if it dies. Any equipment it is wearing or carrying is absorbed or borne by the new form (the {CREATURENAME}'s choice). </br> In a new form, the {CREATURENAME} retains its game statistics and the ability to speak, but its AC, movement modes, Strength, Dexterity, and special senses are replaced by those of the new form, and it gains any statistics and capabilities (except class features, legendary actions, and lair actions) that the new form has but that it lacks."},      
            });

            OGLContent.OGL_Creatures.Add("Deva");
        }
    }
}
