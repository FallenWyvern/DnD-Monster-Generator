using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DND_Monster
{
    public static class Settings
    {
        public static string SettingsFile = "DND_monster.ini";
        public static string sdoddler_file = "";
        public static string SpellTimesPerDay = "Times Per Day";
        public static string LegendaryActions = "3";
        public static string SpellLevel = "Spell Level";
        public static string TranslationFile = "";
        public static bool isFeet = true;
        public static bool isEpic = false;
        public static bool alwaysSavesDoddler = false;

        public static void Load()
        {
            List<string> Args = new List<string>();

            try
            {
                if (File.Exists(SettingsFile))
                {
                    Args = File.ReadAllLines(SettingsFile).ToList<string>();
                }
                else
                {
                    return;
                }

                foreach (string arg in Args)
                {
                    if (arg.Contains("Epic="))
                    {
                        if (arg.Split('=')[1].ToLower() == "true")
                        {
                            isEpic = true;                            
                        }
                    }
                    if (arg.Contains("Last Directory="))
                    {
                        Help.LastDirectory = arg.Split('=')[1];
                    }

                    if (arg.Contains("Translation="))
                    {
                        TranslationFile = arg.Split('=')[1];                        
                    }

                    if (arg.Contains("Last Template="))
                    {
                        Help.TemplateName = arg.Split('=')[1];
                    }

                    if (arg.Contains("sDoddler Suite="))
                    {
                        sdoddler_file = arg.Split('=')[1];
                    }
                    if (arg.Contains("Always Save sDoddler="))
                    {
                        if (arg.Split('=')[1].ToLower() == "true")
                        {
                            alwaysSavesDoddler = true;
                        }
                        else { alwaysSavesDoddler = false; }                        
                    }
                    if (arg.Contains("Skip Version="))
                    {
                        Help.SkipVersion = arg.Split('=')[1];
                    }
                }
            }
            catch { }
        }

        public static void Save()
        {
            try
            {
                File.WriteAllLines(SettingsFile, new List<string>()
                {
                    "Last Directory=" + Help.LastDirectory,
                    "Translation=" + Settings.TranslationFile,
                    "Last Template=" + Help.TemplateName,
                    "sDoddler Suite=" + sdoddler_file,
                    "Always Save sDoddler=" + alwaysSavesDoddler,
                    "Skip Version=" + Help.SkipVersion,
                    "Epic=" + isEpic
                });
            }
            catch { }
        }        
    }
}
