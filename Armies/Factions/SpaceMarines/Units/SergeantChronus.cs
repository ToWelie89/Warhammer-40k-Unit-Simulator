using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class SergeantChronus : Unit
    {
        public SergeantChronus() : base(UnitConstants.SPACE_MARINES_ARMY, "SergeantChronus")
        {
            this.name = "Sergeant Chronus";

            this.previewPicture = SpaceMarinesPictures.chronus;
        }
    }
}
