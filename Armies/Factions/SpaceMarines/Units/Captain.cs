using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class Captain : Unit
    {
        public Captain() : base(UnitConstants.SPACE_MARINES_ARMY, "Captain")
        {
            this.name = "Captain";

            this.previewPicture = SpaceMarinesPictures.captain;
        }
    }
}
