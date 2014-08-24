using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class CaptainSicarius : Unit
    {
        public CaptainSicarius() : base(UnitConstants.SPACE_MARINES_ARMY, "CaptainSicarius")
        {
            this.name = "Captain Sicarius";

            this.chapterRestrictions = new string[] { SpaceMarines.ULTRAMARINES };

            this.previewPicture = SpaceMarinesPictures.Sicarius1;
        }
    }
}
