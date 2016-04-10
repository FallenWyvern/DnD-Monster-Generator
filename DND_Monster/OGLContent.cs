using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_Monster
{
    public enum DragonAge { Ancient, Adult, Young, Wyrmling }
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
            // Angels
                Deva.Add();
                Planetar.Add();
                Solar.Add();
            // Animated Objects
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

            // D's
            #region
            Darkmantle.Add();
            // Demons
                Balor.Add();
                Dretch.Add();
                Glabrezu.Add();
                Hezrou.Add();
                Marilith.Add();
                Nalfeshnee.Add();
                Quasit.Add();
                Vrock.Add();
            // Devils
                BarbedDevil.Add();
                BeardedDevil.Add();
                BoneDevil.Add();
                ChainDevil.Add();
                Erinyes.Add();
                HornedDevil.Add();
                IceDevil.Add();
                Imp.Add();
                Lemure.Add();
                PitFiend.Add();
            // Dinosaurs
                Plesiosaurus.Add();
                Triceratops.Add();
                TyrannosaurusRex.Add();
            Doppleganger.Add();
            // Chromatic Dragons
                BlackDragon.Add(DragonAge.Ancient);
                BlackDragon.Add(DragonAge.Adult);
                BlackDragon.Add(DragonAge.Young);
                BlackDragon.Add(DragonAge.Wyrmling);
                BlueDragon.Add(DragonAge.Ancient);
                BlueDragon.Add(DragonAge.Adult);
                BlueDragon.Add(DragonAge.Young);
                BlueDragon.Add(DragonAge.Wyrmling);
                GreenDragon.Add(DragonAge.Ancient);
                GreenDragon.Add(DragonAge.Adult);
                GreenDragon.Add(DragonAge.Young);
                GreenDragon.Add(DragonAge.Wyrmling);
                RedDragon.Add(DragonAge.Ancient);
                RedDragon.Add(DragonAge.Adult);
                RedDragon.Add(DragonAge.Young);
                RedDragon.Add(DragonAge.Wyrmling);
                WhiteDragon.Add(DragonAge.Ancient);
                WhiteDragon.Add(DragonAge.Adult);
                WhiteDragon.Add(DragonAge.Young);
                WhiteDragon.Add(DragonAge.Wyrmling);
            // Metallic Dragons
                BrassDragon.Add(DragonAge.Ancient);
                BrassDragon.Add(DragonAge.Adult);
                BrassDragon.Add(DragonAge.Young);
                BrassDragon.Add(DragonAge.Wyrmling);
                BronzeDragon.Add(DragonAge.Ancient);
                BronzeDragon.Add(DragonAge.Adult);
                BronzeDragon.Add(DragonAge.Young);
                BronzeDragon.Add(DragonAge.Wyrmling);
                CopperDragon.Add(DragonAge.Ancient);
                CopperDragon.Add(DragonAge.Adult);
                CopperDragon.Add(DragonAge.Young);
                CopperDragon.Add(DragonAge.Wyrmling);
                GoldDragon.Add(DragonAge.Ancient);
                GoldDragon.Add(DragonAge.Adult);
                GoldDragon.Add(DragonAge.Young);
                GoldDragon.Add(DragonAge.Wyrmling);
                SilverDragon.Add(DragonAge.Ancient);
                SilverDragon.Add(DragonAge.Adult);
                SilverDragon.Add(DragonAge.Young);
                SilverDragon.Add(DragonAge.Wyrmling);
            DragonTurtle.Add();
            Drider.Add();
            Dryad.Add();
            Duergar.Add();
            #endregion

            // E's
            #region
            // Elementals
                AirElemental.Add();
                EarthElemental.Add();
                FireElemental.Add();
                WaterElemental.Add();
            DrowElf.Add();
            Ettercap.Add();
            Ettin.Add();
            #endregion

            // F's
            #region
            // Fungi
                Shrieker.Add();
                VioletFungus.Add();
            #endregion

            // G's
            #region
            Gargoyle.Add();
            // Genies
                Djinni.Add();
                Efreeti.Add();
            // Ghouls
                Ghast.Add();
                Ghoul.Add();
            // Giants
                CloudGiant.Add();
                FireGiant.Add();
                FrostGiant.Add();
                HillGiant.Add();
                StoneGiant.Add();
                StormGiant.Add();
            GibberingMouther.Add();
            Gnoll.Add();
            DeepGnome.Add();
            Goblin.Add();
            // Golems
                ClayGolem.Add();
                FleshGolem.Add();
                IronGolem.Add();
                StoneGolem.Add();
            Gorgon.Add();
            Grick.Add();
            Griffon.Add();
            Grimlock.Add();
            #endregion

            // H's
            #region
            // Hags
                GreenHag.Add();
                NightHag.Add();
                SeaHag.Add();
            Harpy.Add();
            HellHound.Add();
            Hippogriff.Add();
            Hobgoblin.Add();
            Homunculus.Add();
            Hydra.Add();
            #endregion

            // I's
            #region
            InvisibleStalker.Add();
            #endregion

            // K's    
            #region
            Kobold.Add();
            Kraken.Add();
            #endregion

            // L's
            #region
            Lamia.Add();
            Lich.Add();
            Lizardfolk.Add();
            // Lycanthropes
                Werebear.Add();
                Wereboar.Add();
                Wererat.Add();
                Weretiger.Add();
                Werewolf.Add();
            #endregion

            // M's
            #region
            Magmin.Add();
            Manticore.Add();
            Medusa.Add();
            // Mephits
                DustMephit.Add();
                IceMephit.Add();
                MagmaMephit.Add();
                SteamMephit.Add();
            Merfolk.Add();
            Merrow.Add();
            Mimic.Add();
            Minotaur.Add();
            // Mummies
                Mummy.Add();
                MummyLord.Add();
            #endregion

            // N's
            #region
            // Nagas
                GuardianNaga.Add();
                SpiritNaga.Add();
            Nightmare.Add();
            #endregion

            // O's
            #region
            Oni.Add();
            // Oozes
                BlackPudding.Add();
                GelatinousCube.Add();
                GrayOoze.Add();
                OchreJelly.Add();
            Orc.Add();
            Otyugh.Add();
            Owlbear.Add();
            #endregion

            // P's
            #region
            Pegasus.Add();
            Pseudodragon.Add();
            PurpleWorm.Add();
            #endregion

            // R's
            #region
            Rakshasa.Add();
            Remorhaz.Add();
            Roc.Add();
            Roper.Add();
            RustMonster.Add();
            #endregion
        }
    }

    public static class OGLContentTemplate
    {
        public static void Add()
        {
            // new OGL_Ability() { OGL_Creature = "", Title = "", attack = null, isDamage = false, isSpell = false, saveDC = 0, Description = "" },
            //new OGL_Ability() { OGL_Creature = "", Title = "Innate Spellcasting", attack = null, isDamage = false, isSpell = true, saveDC = 17, 
            //    Description = "bard|Charisma|0|Innate|0,0,0,0,0,0,0,0,0|0:detect magic,0:feather fall,0:levitate,0:light,3:control weather,3:water breathing,|" },
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
            //    HitText = "",
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
            //        new LegendaryTrait("", ""),
            //        new LegendaryTrait("", ""),                  
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
