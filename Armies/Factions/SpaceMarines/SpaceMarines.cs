using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units;
using Warhammer40KSimulator.Armies.Interfaces;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines
{
    public class SpaceMarines : IFaction
    {
        #region Chapters

        public const string ULTRAMARINES = "Ultramarines";
        
        public const string SALAMANDERS = "Salamanders";

        public const string WHITE_SCARS = "White Scars";

        public const string RAVEN_GUARD = "Raven Guard";

        public const string IMPERIAL_FISTS = "Imperial Fists";

        public const string CRIMSON_FISTS = "Crimson Fists";

        public const string BLACK_TEMPLARS = "Black Templars";



        #endregion

        public string Name { get; set; }

        public List<IUnit> HQ { get; set; }

        public List<IUnit> Troops { get; set; }

        public SpaceMarines()
        {
            this.Name = "Space Marines";
            this.Troops = new List<IUnit>
                              {
                                  new SpaceMarine(),
                                  new Scout()
                              };
            this.HQ = new List<IUnit>
                          {
                              new MarneusCalgar(),
                              new VulkanHestan(),
                              new CaptainLysander(),
                              new CaptainSicarius(),
                              new ChaplainCassius(),
                              new ChaplainGrimaldus(),
                              new ChiefLibrarianTigurius(),
                              new HighMarshalHelbrecht(),
                              new KorsarroKhan(),
                              new Librarian(),
                              new PedroKantor(),
                              new SergeantChronus(),
                              new SergeantTelion(),
                              new ShadowCaptainShrike(),
                              new TheEmperorsChampion(),
                              new Captain(),
                              new CenobyteServitor(),
                              new Chaplain(),
                              new HonourGuard(),
                              new HonourGuardChampion(),
                              new TerminatorCaptain(),
                              new MasterOfTheForge()
                          };
        }
    }
}
