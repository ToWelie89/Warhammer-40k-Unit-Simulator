using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class ChaplainGrimaldus : Unit
    {
        public ChaplainGrimaldus() : base(UnitConstants.SPACE_MARINES_ARMY, "ChaplainGrimaldus")
        {
            this.name = "Chaplain Grimaldus";

            this.previewPicture = SpaceMarinesPictures.grimaldus;
        }
    }
}
