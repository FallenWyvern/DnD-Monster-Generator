using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DND_Monster
{
    public static class Translation
    {
        static List<string> translation = new List<string>();

        public static void Translate(Form target)
        {
            if (target is Main)
            {
                Main temp = (Main)target;                
            }

            if (target is AddAbilityForm)
            {
                AddAbilityForm temp = (AddAbilityForm)target;
            }

            if (target is AddActionForm)
            {
                AddActionForm temp = (AddActionForm)target;
            }

            if (target is AddLegendaryForm)
            {
                AddLegendaryForm temp = (AddLegendaryForm)target;
            }

            if (target is CustomSpeed)
            {
                CustomSpeed temp = (CustomSpeed)target;
            }
        }

        public static void LoadTranslationFile(string target)
        {
            if (File.Exists(target))
            {
                translation = File.ReadAllLines(target).ToList<string>();
            }
        }
    }
}
