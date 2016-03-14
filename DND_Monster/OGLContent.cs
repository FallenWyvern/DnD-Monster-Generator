using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public static class OGLContent
    {
        public static List<string> OGL_Creatures = new List<string>();        
        public static List<OGL_Ability> OGL_Abilities = new List<OGL_Ability>();
        public static List<OGL_Ability> OGL_Actions = new List<OGL_Ability>();        
        public static List<OGL_Ability> OGL_Reactions = new List<OGL_Ability>();        
        public static List<OGL_Legendary> OGL_Legendary = new List<OGL_Legendary>();

        public static void Init()
        {
            // A's
            #region
            Aboleth.Add();
            Deva.Add();
            Planetar.Add();
            Solar.Add();
            AnimatedArmor.Add();
            FlyingSword.Add();
            RugOfSmothering.Add();
            Ankheg.Add();
            Azer.Add();
            #endregion

            // B's
            #region
            Basilisk.Add();
            Behir.Add();
            Bugbear.Add();
            Bulette.Add();
            #endregion

            // C's
            #region
            Centaur.Add();
            Chimera.Add();
            Chuul.Add();
            Cloaker.Add();
            Cockatrice.Add();
            Couatl.Add();
            #endregion
        }
    }

    public static class OGLContentTemplate
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            OGLContent.OGL_Abilities.AddRange(new List<OGL_Ability>()
            {                
            });

            // template
            #region
            // new OGL_Ability() { OGL_Creature = "", Title = "", isDamage = false, isSpell = false, saveDC = 0, Description = ""},      
            // new OGL_Ability() { OGL_Creature = "", Title = "", isDamage = true, isSpell = false, saveDC = 0, Description = "", attack = new Attack()
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
            //    HitText = "plus this text",
            //    HitDamageType = "Acid"
            //}
            //},  
            #endregion
            OGLContent.OGL_Actions.AddRange(new List<OGL_Ability>()
            {

            });

            // new OGL_Ability() { OGL_Creature = "", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" }         
            OGLContent.OGL_Reactions.AddRange(new List<OGL_Ability>()
            {

            });

            // Template
            #region
            //new OGL_Legendary() 
            //{ 
            //    OGL_Creature = "",
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

            OGLContent.OGL_Creatures.Add("");
        }
    }
}
