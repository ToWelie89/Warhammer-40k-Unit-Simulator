using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
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
    public class Faction : IFaction
    {
        #region IFaction members

        public string Name { get; set; }

        public List<IUnit> HQ
        {
            get { return this.hqList; }
        }

        public List<IUnit> Troops
        {
            get { return this.troopsList; }
        }

        public List<IUnit> Elites
        {
            get { return this.elitesList; }
        }

        public List<IUnit> DedicatedTransport
        {
            get { return this.dedicatedTransportList; }
        }

        public List<IUnit> HeavySupport
        {
            get { return this.heavySupportList; }
        }

        public List<IUnit> FastAttack
        {
            get { return this.fastAttackList; }
        }

        #endregion

        private List<IUnit> hqList = new List<IUnit>();
        private List<IUnit> troopsList = new List<IUnit>();
        private List<IUnit> elitesList = new List<IUnit>();
        private List<IUnit> dedicatedTransportList = new List<IUnit>();
        private List<IUnit> heavySupportList = new List<IUnit>();
        private List<IUnit> fastAttackList = new List<IUnit>();

        public Faction(string factionType)
        {
            foreach (string role in UnitConstants.UnitRoles.UNIT_ROLES_ARRAY)
            {
                var executingAssembly = Assembly.GetExecutingAssembly();
                var currentAssemblyDirectoryName = Path.GetDirectoryName(executingAssembly.Location);
                var factionDirectory = currentAssemblyDirectoryName + "\\ArmyData" + "\\" + factionType + "\\" + role;

                if (Directory.Exists(factionDirectory))
                {
                    var filesInDirectory = Directory.GetFiles(factionDirectory);
                    foreach (var file in filesInDirectory)
                    {
                        var fileInfo = new FileInfo(file);
                        var xmlDocument = new XmlDocument();
                        xmlDocument.Load(fileInfo.FullName);

                        if (xmlDocument.DocumentElement != null)
                        {
                            var baseNode = xmlDocument["unit"];
                            var name = baseNode["name"].InnerText;
                            var valuesNode = baseNode["values"];
                            List<IUnit> list;

                            switch (role)
                            {
                                case UnitConstants.UnitRoles.HQ_ROLE:
                                    list = this.hqList;
                                    break;
                                case UnitConstants.UnitRoles.TROOPS_ROLE:
                                    list = this.troopsList;
                                    break;
                                case UnitConstants.UnitRoles.ELITES_ROLE:
                                    list = this.elitesList;
                                    break;
                                case UnitConstants.UnitRoles.DEDICATED_TRANSPORTS_ROLE:
                                    list = this.dedicatedTransportList;
                                    break;
                                case UnitConstants.UnitRoles.HEAVY_SUPPORT_ROLE:
                                    list = this.heavySupportList;
                                    break;
                                case UnitConstants.UnitRoles.FAST_ATTACK_ROLE:
                                    list = this.fastAttackList;
                                    break;
                                default:
                                    list = new List<IUnit>();
                                    break;
                            }

                            list.Add(new Unit()
                            {
                                name = name,
                                weaponSkill = int.Parse(valuesNode["weaponskill"].InnerText),
                                ballisticSkill = int.Parse(valuesNode["ballisticskill"].InnerText),
                                strength = int.Parse(valuesNode["strength"].InnerText),
                                toughness = int.Parse(valuesNode["toughness"].InnerText),
                                wounds = int.Parse(valuesNode["wounds"].InnerText),
                                initiative = int.Parse(valuesNode["initiative"].InnerText),
                                attacks = int.Parse(valuesNode["attacks"].InnerText),
                                leadership = int.Parse(valuesNode["leadership"].InnerText),
                                armourSave = int.Parse(valuesNode["armorsave"].InnerText),
                                previewPicture = TryToMapCorrectPicture(factionType)
                            });
                        }
                    }
                }
            }
        }

        private Bitmap TryToMapCorrectPicture(string faction)
        {
            Bitmap picture;

            switch (faction)
            {
                //case UnitConstants.UnitFactions.SPACE_MARINES_ARMY:
                //    break;
                default:
                    picture = null;
                    break;
            }

            //string conString = Properties.Settings.Default.Database1ConnectionString;

            //// Open the connection using the connection string.
            //using (SqlCeConnection con = new SqlCeConnection(conString))
            //{
            //    con.Open();

            //    using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM Units", con))
            //    {
            //        SqlCeDataReader reader = com.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            var name = reader.GetString(0);
            //            var points = reader.GetInt32(1);
            //            Console.WriteLine(string.Format("Name: {0} (Points: {1}", name, points));
            //        }
            //    }
            //}

            return picture;
        }
    }
}
