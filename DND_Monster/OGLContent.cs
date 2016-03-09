using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class OGLContent
    {
        public static List<Ability> OGL_Abilities = new List<Ability>()
        {
            new Ability() { Title = "Amphibious", isDamage = false, isSpell = false, saveDC = 0, Description = "The {CREATURENAME} can breathe air and water." },
            new Ability() { Title = "Mucous Cloud", isDamage = false, isSpell = false, saveDC = 0, Description = "While underwater, the {CREATURENAME} is surrounded by a transformative mucus. A creature that touches the {CREATURENAME} while within 5 feet of it must make a DC 14 Constitution saving throw. On a failure, the creature is diseased for 1d4 hours. The diseased creature can breathe only underwater." }
        };

        public static List<Ability> OGL_Actions = new List<Ability>()
        {
            new Ability() { }
        };

        public static List<Ability> OGL_Reactions = new List<Ability>()
        {
            new Ability() { }
        };

        public static List<Legendary> OGL_Legendary = new List<Legendary>()
        {
            new Legendary() { }
        };
    }
}
