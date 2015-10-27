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
                
            }

            if (target is AddAbilityForm)
            {

            }

            if (target is AddActionForm)
            {
            
            }

            if (target is AddLegendaryForm)
            {

            }

            if (target is CustomSpeed)
            {

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
