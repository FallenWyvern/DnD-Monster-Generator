using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{
    public static partial class Monster
    {
        public static int columns = 0;
        public static int width = 212;

        // Writes out the HTML needed to render the stat block
        public static string ValloricStatBlock()        
        {
            output.Clear();

            // Templates and Scripts            
            output.Add(@"<!DOCTYPE html>");
            output.Add(@"<html>");

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
            output.Add(@"<body style=""background-image: url('" + Help.BackgroundURI() + @"'); background-repeat: repeat-y;"">");
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
            //TaperedRule();
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
            output.Add(@"width: " + (width + (width * columns)) + "px;");
            output.Add(@"display: block;");
            output.Add(@"}");

            output.Add(@"#content-wrap {");
            output.Add(@"-webkit-column-count: " + columns + ";");
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

            // Generates the actual HTML            
            // Stat-Block Add Variables
            output.Add(@"<stat-block>");

            // Creature Heading            
            output.Add(@"<creature-heading>");
            output.Add(@"<h1>" + CreatureName.Replace('*', ' ').Trim() + "</h1>");
            output.Add(@"<h2>" + CreatureSize + " " + CreatureType + ", " + CreatureAlign + "</h2>");
            output.Add(@"</creature-heading>");            

            // Top Stats            
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
            output.Add(@"<p>" + Speed + "</p>");
            output.Add(@"</property-line>");            

            // Stats            
            string stats = "<abilities-block data-";
            stats += "cha=\"" + CHA + "\" ";
            stats += "data-con=\"" + CON + "\" ";
            stats += "data-dex=\"" + DEX + "\" ";
            stats += "data-int=\"" + INT + "\" ";
            stats += "data-str=\"" + STR + "\" ";
            stats += "data-wis=\"" + WIS + "\">";
            stats += "</abilities-block>";

            output.Add(stats);            

            // Immunities, Resistances, Senses, Languages            
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

            output.Add(@"<property-line>");
            output.Add(@"<h4>Challenge</h4>");
            output.Add(@"<p>" + CR.CR + " (" + CR.XP + " XP)"  + "</p>");
            output.Add(@"</property-line>");
            TaperedRule();

            // Abilities            
            foreach (Ability ability in _Abilities)
            {
                if (!ability.isSpell)
                {
                    output.Add(@"<property-block>");
                    output.Add(@"<h4>" + ability.Title + "</h4>");
                    output.Add(@"<p>" + " " + ability.Description + "</p>");
                    output.Add(@"</property-block>");
                }
            }

            foreach (Ability ability in _Abilities)
            {
                if (ability.isSpell)
                {
                    output.Add(@"<property-block>");
                    output.Add(ability.SpellcasterBoilerplate(CreatureName));
                    output.Add(ability.SpellBlockFormat());
                    //output.Add(@"<h4>" + ability.Title + "</h4>");
                    //output.Add(@"<p>" + " " + ability.Description + "</p>");
                    output.Add(@"</property-block>");
                }
            }

            if (_Attacks.Count > 0)
            {                
                output.Add(@"<h3 style=""border-bottom: 1px solid #7A200D; color:#7A200D; font-size: 18px; font-variant: small-caps; font-weight: normal; letter-spacing: 1px; margin: 0;"">Actions</h3>");                
            }            

            // Actions            
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

            if (_Legendaries.Count > 0)
            {
                output.Add(@"<h3 style=""border-bottom: 1px solid #7A200D; color:#7A200D; font-size: 18px; font-variant: small-caps; font-weight: normal; letter-spacing: 1px; margin: 0;"">Legendary Actions</h3>");
                
                foreach (Legendary ability in _Legendaries)
                {
                    output.Add(@"<property-block>");                    
                    output.Add(@"<p>" + ability.Boilerplate(CreatureName) + "</p></br></br>");
                    foreach (LegendaryTrait trait in ability.TraitList())
                    {
                        output.Add(@"<h4>" + trait.Title + ". </h4>");
                        output.Add(@"<p>" + trait.Ability + "</p><br>");
                    }
                    output.Add(@"</property-block>");
                }
            }

            // Writeout
            output.Add("</stat-block>");
            output.Add("</body>");
            output.Add("</html>");
            
            
            // Writes out to file            
            string returnString = "";
            foreach (string item in output)
            {
                returnString += item + Environment.NewLine;
            }

            if (CreatureName.Contains('*'))
            {
                returnString = returnString.Replace("The " + CreatureName, CreatureName.Replace('*', ' ').Trim());
            }

            return returnString;            
        }

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

    }
}