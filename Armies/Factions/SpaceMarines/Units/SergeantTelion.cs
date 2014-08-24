using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class SergeantTelion : Unit
    {
        public SergeantTelion() : base(UnitConstants.SPACE_MARINES_ARMY, "SergeantTelion")
        {
            this.name = "Sergeant Telion";

            this.previewPicture = SpaceMarinesPictures.telion;
        }
    }
}
