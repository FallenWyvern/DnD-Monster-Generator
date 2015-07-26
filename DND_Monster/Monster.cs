// This class is for storing monster data.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{    
    // To read this, the Monster class has a few important methods.
    // First, Create() fills the list output with all the strings needed
    // to apply the template.
    // Clear() removes all data from all variables, effectively resetting the monster.
    // Input() and Output() either copies all data to or from this static class to a Data instance.

    public static class Monster
    {      
        // Writes out the HTML needed to render the stat block
        public static string Create()
        {
            // Templates and Scripts
            #region
            output.Add(@"<!DOCTYPE html>");
            output.Add("<html>");

            // Head and Title
            #region
            output.Add(@"<head>");
            
            // Inline links
            output.Add(@"<link href=""http://fonts.googleapis.com/css?family=Lora:700"" rel=""stylesheet"" type=""text/css""/>");
            output.Add(@"<link href=""http://fonts.googleapis.com/css?family=Noto+Sans:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css""/><meta charset=""utf-8""/>");
            output.Add(@"<title>" + Title + "</title>");

            // Styles
            output.Add(@"<style>");
            output.Add(@"body {");
            output.Add(@"margin: 0");
            output.Add(@"}");
            output.Add(@"stat-block {");
            output.Add(@"margin-left: 20px;");
            output.Add(@"margin-top: 20px;");
            output.Add(@"margin-bottom: 20px;");
            output.Add(@"</style>");
            output.Add(@"</head>");
            #endregion

            // Body Style
            #region
            output.Add(@"<body>");
            output.Add(@"<template id=""tapered-rule"">");
            output.Add(@"<style>");
            output.Add(@"svg {");
            output.Add(@"fill: #922610;");
            output.Add(@"stroke: #922610;");
            output.Add(@"margin-top: 0.7em;");
            output.Add(@"margin-bottom: 0.35em;");
            output.Add(@"}");
            output.Add(@"</style>");
            output.Add(@"<svg height=""5"" width=""400"">");
            output.Add(@"<polyline points=""0,0 400,2.5 0,5""></polyline>");
            output.Add(@"</svg>");
            output.Add(@"</template>");
            #endregion

            // Scripts
            // Tapered Rule Template
            #region
            AddTemplateScript("tapered-rule");            
            #endregion

            // Tapered Rule Script and Top-Stats Template
            #region
            output.Add(@"<template id=""top-stats"">");
            TaperedRule();
            output.Add(@"<content></content>");
            TaperedRule();
            output.Add(@"</template>");
            #endregion

            // Top-Stats Script
            #region
            AddTemplateScript("top-stats");
            #endregion

            // Creature Heading Template
            #region
            output.Add(@"<template id=""creature-heading"">");
            output.Add(@"<style>");
            
            output.Add(@"::content > h1 {");
            output.Add(@"font-family: 'Lora', 'Calisto MT', 'Bookman Old Style', Bookman,");
            output.Add(@"'Goudy Old Style', Garamond, 'Hoefler Text',");
            output.Add(@"'Bitstream Charter', Georgia, serif;");
            output.Add(@"color: #7A200D;");
            output.Add(@"font-weight: 700;");
            output.Add(@"margin-top: -6px;");
            output.Add(@"margin-bottom: -2px;");
            output.Add(@"font-size: 25px;");
            output.Add(@"letter-spacing: 1px;");
            output.Add(@"font-variant: small-caps;");
            output.Add(@"}");

            output.Add(@"::content > h2 {");
            output.Add(@"font-weight: normal;");
            output.Add(@"font-style: italic;");
            output.Add(@"font-size: 12px;");
            output.Add(@"margin: 0;");
            output.Add(@"}");
            output.Add(@"</style>");
            output.Add(@"<content select=""h1""></content>");
            output.Add(@"<content select=""h2""></content>");
            output.Add(@"</template>");
            #endregion

            // Creature-Heading Script
            #region
            AddTemplateScript("creature-heading");
            #endregion

            // Abilities-Block Template
            #region
            output.Add(@"<template id=""abilities-block"">");
            output.Add(@"<style>");
            output.Add(@":host {");
            output.Add(@"color: #7A200D;");
            output.Add(@"}");

            output.Add(@"table {");
            output.Add(@"width: 100%;");
            output.Add(@"border: 0px;");
            output.Add(@"border-collapse: collapse;");
            output.Add(@"}");

            output.Add(@"th, td {");
            output.Add(@"width: 50px;");
            output.Add(@"text-align: center;");
            output.Add(@"}");
            output.Add(@"</style>");
            TaperedRule();

            // Stat Table
            output.Add(@"<table>");
            output.Add(@"<tbody>");
            output.Add(@"<tr>");
            output.Add(@"<th>STR</th>");
            output.Add(@"<th>DEX</th>");
            output.Add(@"<th>CON</th>");
            output.Add(@"<th>INT</th>");
            output.Add(@"<th>WIS</th>");
            output.Add(@"<th>CHA</th>");
            output.Add(@"</tr>");
            output.Add(@"<tr>");
            output.Add(@"<td id=""str""></th>");
            output.Add(@"<td id=""dex""></th>");
            output.Add(@"<td id=""con""></th>");
            output.Add(@"<td id=""int""></th>");
            output.Add(@"<td id=""wis""></th>");
            output.Add(@"<td id=""cha""></th>");
            output.Add(@"</tr>");
            output.Add(@"</tbody>");
            output.Add(@"</table>");
            TaperedRule();
            output.Add(@"</template>");
            #endregion

            // Abilities-Block Script
            #region
            output.Add(@"<script>");
            output.Add(@"(function(window, document) {");
            output.Add(@"function abilityModifier(abilityScore) {");
            output.Add(@"var score = parseInt(abilityScore, 10);");
            output.Add(@"return Math.floor((score - 10) / 2);");
            output.Add(@"}");

            output.Add(@"function formattedModifier(abilityModifier) {");
            output.Add(@"if (abilityModifier >= 0) {");
            output.Add(@"return '+' + abilityModifier;");
            output.Add(@"}");
            output.Add(@"return '-' + Math.abs(abilityModifier);");
            output.Add(@"}");

            output.Add(@"function abilityText(abilityScore) {");
            output.Add(@"return [String(abilityScore),");
            output.Add(@"' (',");
            output.Add(@"formattedModifier(abilityModifier(abilityScore)),");
            output.Add(@"')'].join('');");
            output.Add(@"}");

            output.Add(@"var elemName = 'abilities-block';");
            output.Add(@"var thatDoc = document;");
            output.Add(@"var thisDoc = (thatDoc.currentScript || thatDoc._currentScript).ownerDocument;");
            output.Add(@"var proto = Object.create(HTMLElement.prototype, {");
            output.Add(@"createdCallback: {");
            output.Add(@"value: function() {");
            output.Add(@"var template = thisDoc.getElementById(elemName);");
            output.Add(@"var clone = thatDoc.importNode(template.content, true);");
            output.Add(@"var root = this.createShadowRoot().appendChild(clone);");
            output.Add(@"}");
            output.Add(@"},");
            output.Add(@"attachedCallback: {");
            output.Add(@"value: function() {");
            output.Add(@"var root = this.shadowRoot;");
            output.Add(@"for (var i = 0; i < this.attributes.length; i++) {");
            output.Add(@"var attribute = this.attributes[i];");
            output.Add(@"var abilityShortName = attribute.name.split('-')[1];");
            output.Add(@"root.getElementById(abilityShortName).textContent =");
            output.Add(@"abilityText(attribute.value);");
            output.Add(@"}");
            output.Add(@"}");
            output.Add(@"}");
            output.Add(@"});");
            output.Add(@"thatDoc.registerElement(elemName, {prototype: proto});");
            output.Add(@"})(window, document);");
            output.Add(@"</script>");
            #endregion

            // Property-Block Template
            #region
            output.Add(@"<template id=""property-block"">");
            output.Add(@"<style>");
            output.Add(@"::content > h4 {");
            output.Add(@"display: inline;");
            output.Add(@"font-weight: bold;");
            output.Add(@"font-style: italic;");
            output.Add(@"}");

            output.Add(@"::content > p {");
            output.Add(@"display: inline;");
            output.Add(@"}");

            output.Add(@"p {");
            output.Add(@"margin-top: 0.3em;");
            output.Add(@"margin-bottom: 0.9em;");
            output.Add(@"}");
            output.Add(@"</style>");

            output.Add(@"<p><content></content></p>");
            output.Add(@"</template>");
            #endregion

            // Property-Block Script
            #region
            AddTemplateScript("property-block");
            #endregion

            // Property-Line Template
            #region
            output.Add(@"<template id=""property-line"">");
            output.Add(@"<style>");
            output.Add(@":host {");
            output.Add(@"color: #7A200D;");
            output.Add(@"}");

            output.Add(@"div {");
            output.Add(@"text-indent: -1em;");
            output.Add(@"margin-left: 1em;");
            output.Add(@"}");

            output.Add(@"::content > * {");
            output.Add(@"display: inline;");
            output.Add(@"}");

            output.Add(@"::content > p {");
            output.Add(@"margin-left: 0.4em;");
            output.Add(@"}");

            output.Add(@"</style>");
            output.Add(@"<div><content select=""h4""></content><content select=""p""></content></div>");
            output.Add(@"</template>");
            #endregion

            // Property-Line Script
            #region
            AddTemplateScript("property-line");
            #endregion

            // Stat-Block Template
            #region
            output.Add(@"<template id=""stat-block"">");
            output.Add(@"<style>");
            output.Add(@":host {");
            output.Add(@"width: 424px;");
            output.Add(@"display: block;");
            output.Add(@"}");

            output.Add(@"#content-wrap {");
            output.Add(@"font-family: 'Noto Sans', 'Myriad Pro', Scala Sans, Helvetica, Arial,");
            output.Add(@"sans-serif;");
            output.Add(@"font-size: 13px;");
            output.Add(@"display: block;");
            output.Add(@"background: #FDF1DC;");
            output.Add(@"padding: 0.6em;");
            output.Add(@"border: 1px #DDD solid;");
            output.Add(@"box-shadow: 0 0 1.5em #867453;");

            output.Add(@"z-index: 0;");

            output.Add(@"margin-left: 2px;");
            output.Add(@"margin-right: 2px;");
            output.Add(@"}");

            output.Add(@"::content > h3 {");
            output.Add(@"border-bottom: 1px solid #7A200D;");
            output.Add(@"color: #7A200D;");
            output.Add(@"font-size: 18px;");
            output.Add(@"font-variant: small-caps;");
            output.Add(@"font-weight: normal;");
            output.Add(@"letter-spacing: 1px;");
            output.Add(@"margin: 0;");
            output.Add(@"}");

            output.Add(@"::content property-block:last-child /deep/ p {");
            output.Add(@"margin-bottom: 0;");
            output.Add(@"}");

            output.Add(@".bar {");
            output.Add(@"height: 5px;");
            output.Add(@"background: #E69A28;");
            output.Add(@"border: 1px solid #000;");
            output.Add(@"position: relative;");
            output.Add(@"z-index: 1;");
            output.Add(@"}");
            output.Add(@"</style>");
            output.Add(@"<div class=""bar""></div>");
            output.Add(@"<div id=""content-wrap"">");
            output.Add(@"<content></content>");
            output.Add(@"</div>");            
            output.Add(@"<div class=""bar""></div>");
            output.Add(@"</template>");
            #endregion

            // Stat-Block Script
            #region
            AddTemplateScript("stat-block");
            #endregion
            
            output.Add(@"");
            output.Add(@"");
            output.Add(@"");
            #endregion

            // Generates the actual HTML
            #region
            // Stat-Block Add Variables
            output.Add(@"<stat-block>");

            // Creature Heading
            #region            
            output.Add(@"<creature-heading>");
            output.Add(@"<h1>" + CreatureName + "</h1>");
            output.Add(@"<h2>" + CreatureSize + " " + CreatureType + ", " + CreatureAlign + "</h2>");
            output.Add(@"</creature-heading>");
            #endregion

            // Top Stats
            #region
            #region
            output.Add(@"<top-stats>");
            
            output.Add(@"<property-line>");
            output.Add(@"<h4>Armor Class</h4>");
            output.Add(@"<p>" + AC + "</p>");
            output.Add(@"</property-line>");

            output.Add(@"<property-line>");
            output.Add(@"<h4>Hit Points</h4>");
            output.Add(@"<p>" + HP + "</p>");
            output.Add(@"</property-line>");

            output.Add(@"<property-line>");
            output.Add(@"<h4>Speed</h4>");
            output.Add(@"<p>" + Speed + "ft</p>");
            output.Add(@"</property-line>");
            #endregion

            // Stats
            #region            
            string stats = "<abilities-block data-";
            stats += "cha=\"" + CHA + "\" ";
            stats += "data-con=\"" + CON + "\" ";
            stats += "data-dex=\"" + DEX + "\" ";
            stats += "data-int=\"" + INT + "\" ";
            stats += "data-str=\"" + STR + "\" ";
            stats += "data-wis=\"" + WIS + "\">";
            stats += "</abilities-block>";

            output.Add(stats);
            #endregion

            // Immunities, Resistances, Senses, Languages
            #region
            if (SavingThrowBonuses.Count > 0)
            {
                output.Add(@"<property-line>");
                output.Add(@"<h4>Saving Throws</h4>");
                output.Add(@"<p>" + SavingThrows() + "</p>");
                output.Add(@"</property-line>");
            }
            
            if (SkillBonuses.Count > 0)
            {                
                output.Add(@"<property-line>");
                output.Add(@"<h4>Skills</h4>");
                output.Add(@"<p>" + Skills() + "</p>");
                output.Add(@"</property-line>");
            }

            if (DamageImmunities.Count > 0)
            {
                output.Add(@"<property-line>");
                output.Add(@"<h4>Damage Immunities</h4>");
                output.Add(@"<p>" + D_Immunities() + "</p>");
                output.Add(@"</property-line>");
            }

            if (DamageResistances.Count > 0)
            {
                output.Add(@"<property-line>");
                output.Add(@"<h4>Damage Resistances</h4>");
                output.Add(@"<p>" + D_Resistances() + "</p>");
                output.Add(@"</property-line>");
            }

            if (DamageVulnerability.Count > 0)
            {
                output.Add(@"<property-line>");
                output.Add(@"<h4>Damage Vulnerabilities</h4>");
                output.Add(@"<p>" + D_Vulnerabilities() + "</p>");
                output.Add(@"</property-line>");
            }

            if (ConditionImmunities.Count > 0)
            {
                output.Add(@"<property-line>");
                output.Add(@"<h4>Condition Immunities</h4>");
                output.Add(@"<p>" + C_Immunities() + "</p>");
                output.Add(@"</property-line>");
            }

            output.Add(@"<property-line>");
            output.Add(@"<h4>Senses</h4>");
            output.Add(@"<p>" + Senses() + "</p>");
            output.Add(@"</property-line>");

            output.Add(@"<property-line>");
            output.Add(@"<h4>Languages</h4>");
            output.Add(@"<p>" + Languages() + "</p>");
            output.Add(@"</property-line>");
            #endregion

            // CR
            #region
            output.Add(@"<property-line>");
            output.Add(@"<h4>Challenge</h4>");
            output.Add(@"<p>" + CR + "</p>");
            output.Add(@"</property-line>");
            output.Add(@"</top-stats>");
            #endregion            
            #endregion

            // Abilities
            #region            
            foreach (Ability ability in _Abilities)
            {                
                output.Add(@"<property-block>");
                output.Add(@"<h4>" + ability.Title + "</h4>");
                output.Add(@"<p>" + ability.Description + "</p>");
                output.Add(@"</property-block>");
            }
            TaperedRule();
            #endregion

            // Actions
            #region            
            foreach (Ability ability in _Attacks)
            {
                if (!ability.isDamage)
                {
                    output.Add(@"<property-block>");
                    output.Add(@"<h4>" + ability.Title + "</h4>");
                    output.Add(@"<p>" + ability.Description + "</p>");
                    output.Add(@"</property-block>");
                }
            }

            foreach (Ability ability in _Attacks)
            {
                if (ability.isDamage)
                {
                    output.Add(@"<property-block>");
                    output.Add(@"<h4>" + ability.Title + "</h4>");
                    output.Add(@"<p>" + ability.Description + "</p>");
                    output.Add(@"</property-block>");
                }
            }
            #endregion

            // Writeout
            output.Add("</stat-block>");
            output.Add("</body>");
            output.Add("</html>");
            #endregion

            // Writes out to file
            #region
            string returnString = "";
            foreach (string item in output)
            {
                returnString += item + Environment.NewLine;
            }
            return returnString;
            #endregion
        }

        // Top Stats methods.
        #region
        private static string D_Immunities()
        {
            string immunities = "";
            foreach (string item in DamageImmunities)
            {
                immunities += item + ", ";
            }
            if (immunities.Length > 2)
            {
                immunities = immunities.Substring(0, immunities.Length - 2);
            }
            return immunities;
        }

        public static void AddDamageImmunity(string immunity)
        {
            DamageImmunities.Add(immunity);
        }

        private static string D_Resistances()
        {
            string resistance = "";
            foreach (string item in DamageResistances)
            {
                resistance += item + ", ";
            }
            if (resistance.Length > 2)
            {
                resistance = resistance.Substring(0, resistance.Length - 2);
            }
            return resistance;
        }

        public static void AddDamageResistance(string resistance)
        {
            
            DamageResistances.Add(resistance);
        }

        private static string D_Vulnerabilities()
        {
            string vulnerability = "";
            foreach (string item in DamageVulnerability)
            {
                vulnerability += item + ", ";
            }
            if (vulnerability.Length > 2)
            {
                vulnerability = vulnerability.Substring(0, vulnerability.Length - 2);
            }
            return vulnerability;
        }

        public static void AddDamageVulnerabilities(string vulnerability)
        {
            DamageVulnerability.Add(vulnerability);
        }

        private static string C_Immunities()
        {
            string immunities = "";
            foreach (string item in ConditionImmunities)
            {
                immunities += item + ", ";
            }
            if (immunities.Length > 2)
            {
                immunities = immunities.Substring(0, immunities.Length - 2);
            }
            return immunities;
        }

        public static void AddConditionImmunity(string immunity)
        {            
            ConditionImmunities.Add(immunity);            
        }

        private static string SavingThrows()
        {
            string savingThrows = "";
            foreach (string item in SavingThrowBonuses)
            {
                savingThrows += item + ", ";
            }
            if (savingThrows.Length > 2)
            {
                savingThrows = savingThrows.Substring(0, savingThrows.Length - 2);
            }
            return savingThrows;
        }

        public static void AddSavingThrow(string savingThrow)
        {
            SavingThrowBonuses.Add(savingThrow);
        }

        private static string Skills()
        {
            string skills = "";
            foreach (string item in SkillBonuses)
            {                
                skills += item.Split(':')[1] + ", ";
            }
            if (skills.Length > 2)
            {
                skills = skills.Substring(0, skills.Length - 2);
            }
            return skills;
        }

        public static void AddSkillBonus(string skill)
        {            
            SkillBonuses.Add(skill);
        }

        private static string Senses()
        {            
            string senses = "";
            foreach (string item in _Senses)
            {
                string temp = item;

                if (temp.Contains("Passive"))
                {
                    string bonus = " " + (WIS + proficency) + " ";                    
                    temp = "Passive Perception" + bonus;
                }
                senses += temp + ", ";
            }
            if (senses.Length > 2)
            {
                senses = senses.Substring(0, senses.Length - 2);
            }

            return senses;
        }

        public static void AddSense(string sense)
        {
            _Senses.Add(sense);
        }

        private static string Languages()
        {
            string languages = "";
            foreach (string item in _Languages)
            {
                languages += item + ", ";
            }
            if (languages.Length > 2)
            {
                languages = languages.Substring(0, languages.Length - 2);
            }            
            return languages;
        }

        public static void AddLanguage(string language)
        {
            _Languages.Add(language);
        }
        #endregion

        // Methods for adding Abilities
        #region
        public static void AddAbility(string title, string description)
        {
            _Abilities.Add(new Ability { Title = title, Description = description });
        }
        #endregion

        // Methods for adding Actions
        #region
        public static void AddAttack(string title, string description)
        {
            _Attacks.Add(new Ability { Title = title, Description = description });
        }
        #endregion

        // Since the scripts in the original template were so
        // similar, I just wrote this to re-write them over and over.
        // Saves typing.
        private static void AddTemplateScript(string identifier)
        {
            output.Add(@"<script>");
            output.Add(@"(function(window, document) {");
            output.Add(@"var elemName = '" + identifier + "';");
            output.Add(@"var thatDoc = document;");
            output.Add(@"var thisDoc = (thatDoc.currentScript || thatDoc._currentScript).ownerDocument;");
            output.Add(@"var proto = Object.create(HTMLElement.prototype, {");
            output.Add(@"createdCallback: {");
            output.Add(@"value: function() {");
            output.Add(@"var template = thisDoc.getElementById(elemName);");
            output.Add(@"var clone = thatDoc.importNode(template.content, true);");
            output.Add(@"this.createShadowRoot().appendChild(clone);");
            output.Add(@"}");
            output.Add(@"}");
            output.Add(@"});");
            output.Add(@"thatDoc.registerElement(elemName, {prototype: proto});");
            output.Add(@"})(window, document);");
            output.Add(@"</script>");
        }

        // Tapered Rule
        private static void TaperedRule()
        {
            output.Add(@"<tapered-rule></tapered-rule>");
        }

        // Variables
        #region
        public static List<string> output = new List<string>();

        public static List<string> DamageImmunities = new List<string>();        
        public static List<string> ConditionImmunities = new List<string>();
        public static List<string> DamageResistances = new List<string>();
        public static List<string> DamageVulnerability = new List<string>();
        public static List<string> SavingThrowBonuses = new List<string>();
        public static List<string> SkillBonuses = new List<string>();

        public static List<string> _Senses = new List<string>();
        public static List<string> _Languages = new List<string>();

        public static List<Ability> _Abilities = new List<Ability>();
        public static List<Ability> _Attacks = new List<Ability>();

        public static string Title = "";        
        public static int STR = 0;
        public static int DEX = 0;
        public static int CON = 0;
        public static int INT = 0;
        public static int WIS = 0;
        public static int CHA = 0;
        public static int proficency = 0;

        public static string Speed = "";

        public static string AC = "";
        public static string HP = "";
        public static string CR = "";

        public static string CreatureName = "";
        public static string CreatureSize = "";
        public static string CreatureType = "";
        public static string CreatureAlign = "";
        
        #endregion

        public static void Clear(bool isNew = false)
        {
            Title = "";

            STR = 0;
            DEX = 0;
            CON = 0;
            INT = 0;
            WIS = 0;
            CHA = 0;

            Speed = "";            
            AC = "";
            HP = "";
            CR = "";            

            CreatureAlign = "";
            CreatureName = "";
            CreatureSize = "";
            CreatureType = "";

            output.Clear();
            output = new List<string>();

            DamageImmunities.Clear();
            DamageResistances.Clear();
            DamageVulnerability.Clear();
            ConditionImmunities.Clear();
            SavingThrowBonuses.Clear();
            SkillBonuses.Clear();

            if (isNew)
            {
                _Abilities.Clear();
                _Attacks.Clear();
            }

            _Languages.Clear();
            _Senses.Clear();
        }

        public static void Output(Data fillTarget)
        {
            fillTarget._Abilities = _Abilities;
            fillTarget._Attacks = _Attacks;
            fillTarget._Languages = _Languages;
            fillTarget._Senses = _Senses;
            fillTarget.AC = AC;
            fillTarget.CHA = CHA;
            fillTarget.CON = CON;
            fillTarget.ConditionImmunities = ConditionImmunities;
            fillTarget.CR = CR;
            fillTarget.CreatureAlign = CreatureAlign;
            fillTarget.CreatureName = CreatureName;
            fillTarget.CreatureSize = CreatureSize;
            fillTarget.CreatureType = CreatureType;
            fillTarget.DamageImmunities = DamageImmunities;
            fillTarget.DamageResistances = DamageResistances;
            fillTarget.DamageVulnerability = DamageVulnerability;
            fillTarget.DEX = DEX;
            fillTarget.HP = HP;
            fillTarget.INT = INT;
            //fillTarget.output = output;
            fillTarget.proficency = proficency;
            fillTarget.SavingThrowBonuses = SavingThrowBonuses;
            fillTarget.SkillBonuses = SkillBonuses;
            fillTarget.Speed = Speed;
            fillTarget.STR = STR;
            fillTarget.Title = Title;
            fillTarget.WIS = WIS;            
        }

        public static void Input(Data source)
        {
            _Abilities = source._Abilities;
            _Attacks = source._Attacks;
            _Languages = source._Languages;
            _Senses = source._Senses;
            AC = source.AC;
            CHA = source.CHA;
            CON = source.CON;
            ConditionImmunities = source.ConditionImmunities;
            CR = source.CR;
            CreatureAlign = source.CreatureAlign;
            CreatureName = source.CreatureName;
            CreatureSize = source.CreatureSize;
            CreatureType = source.CreatureType;
            DamageImmunities = source.DamageImmunities;
            DamageResistances = source.DamageResistances;
            DamageVulnerability = source.DamageVulnerability;
            DEX = source.DEX;
            HP = source.HP;
            INT = source.INT;
            //fillTarget.output = output;
            proficency = source.proficency;
            SavingThrowBonuses = source.SavingThrowBonuses;
            SkillBonuses = source.SkillBonuses;
            Speed = source.Speed;
            STR = source.STR;
            Title = source.Title;
            WIS = source.WIS;
        }
    }
}

public class Ability
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool isDamage { get; set; }
}

public class Attack : Ability
{    
    public string _Attack { get; set; }
    public string Bonus { get; set; }
    public int Reach { get; set; }
    public int RangeClose { get; set; }
    public int RangeFar { get; set; }    
    public string Target { get; set; }
    public int HitDiceNumber { get; set; }
    public int HitDiceSize { get; set; }
    public int HitDamageBonus { get; set; }
    public int HitAverageDamage { get; set; }
    public string HitText { get; set; }
    public string HitDamageType { get; set; }

    public Attack(string attack, string bonus, int reach, int rangeClose, int rangeFar, string target, int hitAverageDamage, int hitDiceNumber, int hitDiceSize, int hitDamageBonus, string damageType, string hit)
    {
        _Attack = attack;
        Bonus = bonus;
        Reach = reach;
        RangeClose = rangeClose;
        RangeFar = rangeFar;
        Target = target;
        HitAverageDamage = hitAverageDamage;
        HitDiceNumber = hitDiceNumber;
        HitDiceSize = hitDiceSize;
        HitDamageBonus = hitDamageBonus;
        HitDamageType = damageType;
        HitText = hit;
        Description = Describe();
    }
    
    public string Describe()
    {
        string returnstring = "<i>";
        returnstring += _Attack + ": </i>+";
        returnstring += Bonus + ", ";
        
        if (Reach > 0){
            returnstring += "Reach: " + Reach + " ft., ";
        }

        if (RangeClose > 0 ){
            returnstring += "Range: " + RangeClose;
            if (RangeFar > 0) {
                returnstring += "/" + RangeFar;
            }
            returnstring += " ft., ";        
        }

        returnstring += Target;
        returnstring += " <i>Hit:</i> " + HitAverageDamage + " (" + HitDiceNumber + "d" + HitDiceSize + "+" + HitDamageBonus + ") " + HitDamageType + " damage " + HitText;

        return returnstring;
    }
}