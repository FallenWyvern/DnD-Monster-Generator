using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class Lich
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "Lich", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "Lich", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 20, 
            //    Description = "wizard|Intelligence|0|NotInnate|4,3,3,3,3,1,1,1,1||" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {
                new OGL_Ability() { OGL_Creature = "Lich", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 20, 
                Description = "wizard|Intelligence|18|NotInnate|4,3,3,3,3,1,1,1,1|0:mage hand,0:prestdigitation,0:ray of frost,1:detect magic,1:magic missile,1:shield,1:thunderwave," + 
                "2:acid arrow,2:detect thoughts,2:invisibility,2:mirror image," +
                "3:animate dead,3:counterspell,3:dispel magic,3:fireball," + 
                "4:blight,4:dimension door,5:cloudkill,5:scrying,6:disintegrate,6:globe of vulnerability," + 
                "7:finger of death,7:plane shift,8:dominate monster,8:power word stun,9:power word kill,|" },
                new OGL_Ability() { OGL_Creature = "Lich", Title = "Turn Resistance", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} has advantage on saving throws against any effect that turns undead." },
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "Lich", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "Lich", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
                 new OGL_Ability() { OGL_Creature = "Lich", Title = "Paralyzing Touch", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
                { 
                    _Attack = "Melee Spell Attack",
                    Bonus = "12",
                    Reach = 5,
                    RangeClose = 0,
                    RangeFar = 0,
                    Target = "one target",
                    HitDiceNumber = 3,
                    HitDiceSize = 6,
                    HitDamageBonus = 0,
                    HitAverageDamage = 10,
                    HitText = "The target must succeed on a DC 18 Constitution saving throw or be paralyzed for 1 minute. The target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success.",
                    HitDamageType = "cold"
                }
                },  
            });

            // new OGL_Ability() { OGL_Creature = "Lich", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "Lich",
            //    Title = "",
            //    Traits = new List<LegendaryTrait>() 
            //    {
            //        new LegendaryTrait("", "")                    
            //    }
            //},            
            #endregion
            OGLContent.OGL_Legendary.AddRange(new List<OGL_Legendary>()
            {
                new OGL_Legendary() 
                { 
                    OGL_Creature = "Lich",
                    Title = "Lich Legendary Actions",
                    Traits = new List<LegendaryTrait>() 
                    {
                        new LegendaryTrait("Cantrip", "The {CREATURENAME} casts a cantrip."),                    
                        new LegendaryTrait("Paralyzing Touch (Costs 2 Actions)", "The {CREATURENAME} uses its Paralyzing Touch."), 
                        new LegendaryTrait("Frightening Gaze (Costs 2 Actions)", "The {CREATURENAME} fixes its gaze on one creature it can see within 10 feet of it. The target must succeed on a DC 18 Wisdom saving throw against this magic or become frightened for 1 minute. The frightened target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a target's saving throw is successful or the effect ends for it, the target is immune to the {CREATURENAME}'s gaze for the next 24 hours."), 
                        new LegendaryTrait("Disrupt Life (Costs 3 Actions)", "Each living creature within 20 feet of the {CREATURENAME} must make a DC 18 Constitution saving throw against this magic, taking 21 (6d6) necrotic damage on a failed save, or half as much damage on a successful one."), 
                    }
                },  
            });

            OGLContent.OGL_Creatures.Add("Lich");
        }
    }
}
