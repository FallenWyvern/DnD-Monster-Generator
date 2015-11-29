using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Monster
{
    // Class based on Valloric's template.
    public static partial class Monster
    {        
        private static List<string> Parameters = new List<string>();
        private static string LastFile = "";

        // Writes out the HTML needed to render the stat block
        public static string CustomStatBlock(string file = "")        
        {
            Console.WriteLine("Custom: " + file + " : " + LastFile);
            if (file == "" && LastFile == "") return "";
            if (LastFile == "")
            {
                Console.WriteLine("Setting last file: " + file);
                LastFile = file;                
            }

            if (file == "")
            {
                Console.WriteLine("Using last file: " + LastFile);
                file = LastFile;                
            }

            output.Clear();
            if (!System.IO.File.Exists(file)) { Console.WriteLine("File Not Found: " + file); return ""; }
            Parameters = System.IO.File.ReadAllLines(file).ToList<string>();
         
            // Templates and Scripts            
            #region
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
            output.Add(@"margin: " + ParseParameters("body margin", "0") + ";");
            output.Add(@"}");
            output.Add(@"stat-block {");
            output.Add(@"margin-left: " + ParseParameters("body margin-left", "20px") + ";");
            output.Add(@"margin-top: " + ParseParameters("body margin-top", "20px") + ";");
            output.Add(@"margin-bottom: " + ParseParameters("body margin-bottom", "20px") + ";");
            output.Add(@"</style>");
            output.Add(@"</head>");
            #endregion

            // Body Style
            #region
            output.Add(@"<body style=""background-image: url('" + Help.BackgroundImage() + @"'); background-repeat: repeat-y;"">");
            output.Add(@"<template id=""tapered-rule"">");
            output.Add(@"<style>");
            output.Add(@"svg {");
            output.Add(@"fill: " + ParseParameters("rule svg fill", "#922610") + ";");
            output.Add(@"stroke: " + ParseParameters("rule svg stroke", "#922610") + ";");
            output.Add(@"margin-top: " + ParseParameters("rule svg margin-top", "0.7em") + ";");
            output.Add(@"margin-bottom: " + ParseParameters("rule svg margin-bottom", "0.35em") + ";");
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
            output.Add(@"color: " + ParseParameters("creature-h1 heading color", "#7A200D") + ";");
            output.Add(@"font-weight: " + ParseParameters("creature-h1 font-weight", "700") + ";");
            output.Add(@"margin-top: " + ParseParameters("creature-h1 margin-top", "-6px") + ";");
            output.Add(@"margin-bottom: " + ParseParameters("creature-h1 margin-bottom", "-2px") + ";");
            output.Add(@"font-size: " + ParseParameters("creature-h1 font-size", "25px") + ";");
            output.Add(@"letter-spacing: " + ParseParameters("creature-h1 letter-spacing", "2px") + ";");
            output.Add(@"font-variant: " + ParseParameters("creature-h1 font-variant", "small-caps") + ";");
            output.Add(@"}");

            output.Add(@"::content > h2 {");
            output.Add(@"font-weight: " + ParseParameters("creature-h2 font-weight", "normal") + ";");
            output.Add(@"font-style: " + ParseParameters("creature-h2 font-style", "italic") + ";");
            output.Add(@"font-size: " + ParseParameters("creature-h2 font-size", "12px") + ";");
            output.Add(@"margin: " + ParseParameters("creature-h2 margin", "0") + ";");
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
            output.Add(@"color: " + ParseParameters("abilities-host color", "#7A200D") + ";");
            output.Add(@"}");

            output.Add(@"table {");
            output.Add(@"width: " + ParseParameters("abilities-host-table width", "100%") + ";");
            output.Add(@"border: " + ParseParameters("abilities-host-table border", "100%") + ";");
            output.Add(@"border-collapse: " + ParseParameters("abilities-host-table border-collapse", "collapse") + ";");
            output.Add(@"}");

            output.Add(@"th, td {");
            output.Add(@"width: " + ParseParameters("abilities-host-table-thtd width", "50px") + ";");
            output.Add(@"text-align: " + ParseParameters("abilities-host-table-thtd text-align", "center") + ";");
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
            output.Add(@"display: " + ParseParameters("property-block-h4 display", "inline") + ";");
            output.Add(@"font-weight: " + ParseParameters("property-block-h4 font-weight", "bold") + ";");
            output.Add(@"font-style: " + ParseParameters("property-block-h4 font-style", "italic") + ";");
            output.Add(@"}");

            output.Add(@"::content > p {");
            output.Add(@"display: " + ParseParameters("property-block-p display", "inline") + ";");
            output.Add(@"}");

            output.Add(@"p {");
            output.Add(@"margin-top: " + ParseParameters("property-block-p margin-top", "0.3em") + ";");
            output.Add(@"margin-bottom: " + ParseParameters("property-block-p margin-top", "0.9em") + ";");
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
            output.Add(@"color: " + ParseParameters("property-line-host color", "#7A200D") + ";");
            output.Add(@"}");

            output.Add(@"div {");
            output.Add(@"text-indent: " + ParseParameters("property-line-host-div text-indent", "-1em") + ";");
            output.Add(@"margin-left: " + ParseParameters("property-line-host-div margin-left", "1em") + ";");
            output.Add(@"}");

            output.Add(@"::content > * {");
            output.Add(@"display: " + ParseParameters("property-line-host-all display", "inline") + ";");
            output.Add(@"}");

            output.Add(@"::content > p {");
            output.Add(@"margin-left: " + ParseParameters("property-line-host-p margin-left", "0.4em") + ";");
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
            output.Add(@"display: " + ParseParameters("stat-block-host display", "block") + ";");
            output.Add(@"}");

            output.Add(@"#content-wrap {");
            output.Add(@"-webkit-column-count: " + columns + ";");
            output.Add(@"-webkit-column-gap: " + ParseParameters("stat-block-wrap -webkit-column-gap", "40px") + ";");
            output.Add(@"font-family: 'Noto Sans', 'Myriad Pro', Scala Sans, Helvetica, Arial, sans-serif;");            
            output.Add(@"font-size: " + ParseParameters("stat-block-wrap font-size", "13px") + ";");
            output.Add(@"display: " + ParseParameters("stat-block-wrap display", "block") + ";");
            output.Add(@"background: " + ParseParameters("stat-block-wrap background", "#FDF1DC") + ";");
            output.Add(@"padding: " + ParseParameters("stat-block-wrap padding", "0.6em") + ";");
            output.Add(@"border: " + ParseParameters("stat-block-wrap border", "1px #DDD solid") + ";");
            output.Add(@"box-shadow: " + ParseParameters("stat-block-wrap box-shadow", "0 0 1.5em #867453") + ";");

            output.Add(@"z-index: " + ParseParameters("stat-block-wrap z-index", "0") + ";");

            output.Add(@"margin-left: " + ParseParameters("stat-block-wrap margin-left", "2px") + ";");
            output.Add(@"margin-right: " + ParseParameters("stat-block-wrap margin-right", "2px") + ";");
            output.Add(@"}");

            output.Add(@"::content > h3 {");
            output.Add(@"border-bottom: " + ParseParameters("stat-block-h3 border-bottom", "1px solid #7A200D") + ";");
            output.Add(@"color: " + ParseParameters("stat-block-h3 color", "#7A200D") + ";");
            output.Add(@"font-size: " + ParseParameters("stat-block-h3 font-size", "18px") + ";");
            output.Add(@"font-variant: " + ParseParameters("stat-block-h3 font-variant", "small-caps") + ";");
            output.Add(@"font-weight: " + ParseParameters("stat-block-h3 font-weight", "normal") + ";");
            output.Add(@"letter-spacing: " + ParseParameters("stat-block-h3 letter-spacing", "1px") + ";");
            output.Add(@"margin: " + ParseParameters("stat-block-h3 margin", "0") + ";");
            output.Add(@"}");

            output.Add(@"::content property-block:last-child /deep/ p {");
            output.Add(@"margin-bottom: " + ParseParameters("stat-block-property-block margin-bottom", "0") + ";");
            output.Add(@"}");

            output.Add(@".bar {");
            output.Add(@"height: " + ParseParameters("stat-block-bar height", "5px") + ";");
            output.Add(@"background: " + ParseParameters("stat-block-bar background", "#E69A28") + ";");
            output.Add(@"border: " + ParseParameters("stat-block-bar border", "1px solid #000") + ";");
            output.Add(@"position: " + ParseParameters("stat-block-bar position", "relative") + ";");
            output.Add(@"z-index: " + ParseParameters("stat-block-bar z-index", "1") + ";");
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
            #endregion

            // Insert Data into Template
            #region
            output.Add(@"");
            output.Add(@"");
            output.Add(@"");            

            // Generates the actual HTML            
            // Stat-Block Add Variables
            output.Add(@"<stat-block>");

            // Creature Heading            
            output.Add(@"<creature-heading>");
            output.Add(@"<h1>" + CreatureName.Replace('*', ' ').Trim() + "</h1>");
            output.Add(@"<h2>" + CreatureSize + " " + CreatureType.ToLower() + ", " + CreatureAlign.ToLower() + "</h2>");
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
            output.Add(@"<p>" + Speed.Replace(':', ' ').Trim() + "</p>");
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
                    output.Add(@"<h4>" + ability.ProperName() + ".</h4>");
                    string abilityDescription = "";

                    foreach (string abilityWord in ability.Description.Split(' '))
                    {
                        if (!abilityWord.Contains('\n'))
                        {                            
                            abilityDescription += abilityWord + " ";
                        }
                        else
                        {
                            string breakString = "</p></br><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                            abilityDescription += abilityWord.Replace('\n'.ToString(), breakString) + " ";
                        }
                    }

                    output.Add(@"<p>" + abilityDescription + "</p>");                      
                    output.Add(@"</property-block>");
                }
            }

            foreach (Ability ability in _Abilities)
            {
                if (ability.isSpell)
                {
                    output.Add(@"<property-block>");
                    output.Add(ability.WebSpellcasterBoilerplate(CreatureName));
                    if (ability.Description.Contains("NotInnate"))
                    {
                        output.Add(ability.WebSpellBlockFormat_NotInnate());
                    }
                    else
                    {
                        output.Add(ability.WebSpellBlockFormat_Innate());
                    }
                    output.Add(@"</property-block>");
                }
            }

            if (_Actions.Count > 0)
            {                
                output.Add(@"<h3 style=""border-bottom: 1px solid #7A200D; color:#7A200D; font-size: 18px; font-variant: small-caps; font-weight: normal; letter-spacing: 1px; margin: 0;"">Actions</h3>");                
            }            

            // Actions            
            foreach (Ability ability in _Actions)
            {                                
                    output.Add(@"<property-block>");
                    output.Add(@"<h4>" + ability.ProperName() + ".</h4>");
                    Console.WriteLine(ability.ProperName() + " " + ability.isDamage);
                    if (ability.isDamage) 
                    {
                        output.Add(@"<p>" + ability.attack.WebDescribe()+ "</p>");
                    }
                    else
                    {
                        string abilityDescription = "";
                        
                        foreach (string abilityWord in ability.Description.Split(' '))
                        {
                            if (!abilityWord.Contains('\n'))
                            {                                
                                abilityDescription += abilityWord + " ";
                            }
                            else
                            {
                                string breakString = "</p></br><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                                abilityDescription += abilityWord.Replace('\n'.ToString(), breakString) + " " ;
                            }
                        }

                        output.Add(@"<p>" + abilityDescription + "</p>");                        
                    }
                    output.Add(@"</property-block>");                
            }            

            if (_Reactions.Count > 0)
            {
                output.Add(@"<h3 style=""border-bottom: 1px solid #7A200D; color:#7A200D; font-size: 18px; font-variant: small-caps; font-weight: normal; letter-spacing: 1px; margin: 0;"">Reactions</h3>");

                foreach (Ability ability in _Reactions)
                {
                    output.Add(@"<property-block>");
                    output.Add(@"<h4>" + ability.ProperName() + ".</h4>");
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
                    output.Add(@"<p>" + ability.WebBoilerplate(CreatureName) + "</p></br></br>");
                    foreach (LegendaryTrait trait in ability.TraitList())
                    {
                        output.Add(@"<h4>" + trait.ProperName() + ". </h4>");
                        output.Add(@"<p>" + trait.Ability + "</p><br>");
                    }
                    output.Add(@"</property-block>");
                }
            }

            // Writeout
            output.Add("</stat-block>");
            output.Add("</body>");
            output.Add("</html>");
            #endregion

            // Writes out to file            
            string returnString = "";
            foreach (string item in output)
            {
                returnString += item + Environment.NewLine;
            }

            // Fix proper names, if needed.
            if (CreatureName.Contains('*'))
            {
                returnString = returnString.Replace("The " + CreatureName, CreatureName.Replace('*', ' ').Trim());
            }

            // Provide the string back to the caller.
            return returnString;            
        }

        private static string ParseParameters(string parameterName, string defaultParameter)
        {
            foreach (string s in Parameters)
            {
                if (s.Contains(parameterName))
                {
                    return s.Split(':')[1].Trim();
                }
            }
            return defaultParameter;
        }
    }
}