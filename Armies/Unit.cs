using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Warhammer40KSimulator.Armies.Interfaces;

namespace Warhammer40KSimulator.Armies
{
    public class Unit : IUnit
    {
        public int weaponSkill { get; set; }
        public int ballisticSkill { get; set; }
        public int strength { get; set; }
        public int toughness { get; set; }
        public int wounds { get; set; }
        public int initiative { get; set; }
        public int attacks { get; set; }
        public int leadership { get; set; }
        public int armourSave { get; set; }
        public string name { get; set; }
        public string chapter { get; set; }
        public string[] chapterRestrictions { get; set; }
        public Bitmap previewPicture { get; set; }

        public Unit(string factionPath, string unitFileName)
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var currentAssemblyDirectoryName = Path.GetDirectoryName(executingAssembly.Location);
            var factionDirectory = currentAssemblyDirectoryName + "\\ArmyData" + "\\" + factionPath;

            if (Directory.Exists(factionDirectory))
            {
                var filesInDirectory = Directory.GetFiles(factionDirectory);
                foreach (var file in filesInDirectory)
                {
                    var fileInfo = new FileInfo(file);
                    var xmlDocument = new XmlDocument();
                    xmlDocument.Load(fileInfo.FullName);

                    if (fileInfo.Name.Replace(".xml", "") == unitFileName)
                    {
                        if (xmlDocument.DocumentElement != null)
                        {
                            var baseNode = xmlDocument["unit"];
                            var valuesNode = baseNode["values"];

                            this.weaponSkill = int.Parse(valuesNode["weaponskill"].InnerText);
                            this.ballisticSkill = int.Parse(valuesNode["ballisticskill"].InnerText);
                            this.strength = int.Parse(valuesNode["strength"].InnerText);
                            this.toughness = int.Parse(valuesNode["toughness"].InnerText);
                            this.wounds = int.Parse(valuesNode["wounds"].InnerText);
                            this.initiative = int.Parse(valuesNode["initiative"].InnerText);
                            this.attacks = int.Parse(valuesNode["attacks"].InnerText);
                            this.leadership = int.Parse(valuesNode["leadership"].InnerText);
                            this.armourSave = int.Parse(valuesNode["armorsave"].InnerText);
                        }

                        return;
                    }
                }
            }
        }
    }
}
