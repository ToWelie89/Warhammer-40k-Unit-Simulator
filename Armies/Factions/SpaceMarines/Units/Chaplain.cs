using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class Chaplain : Unit
    {
        public Chaplain() : base(UnitConstants.SPACE_MARINES_ARMY, "Chaplain")
        {
            this.name = "Chaplain";

            this.previewPicture = SpaceMarinesPictures.chaplain;
        }
    }
}
