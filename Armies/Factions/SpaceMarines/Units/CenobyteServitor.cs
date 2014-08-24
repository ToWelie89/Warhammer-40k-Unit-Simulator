using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class CenobyteServitor : Unit
    {
        public CenobyteServitor() : base(UnitConstants.SPACE_MARINES_ARMY, "CenobyteServitor")
        {
            this.name = "Cenobyte Servitor";

            this.previewPicture = SpaceMarinesPictures.ceno;
        }
    }
}
