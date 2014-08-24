using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class CaptainLysander : Unit
    {
        public CaptainLysander() : base(UnitConstants.SPACE_MARINES_ARMY, "CaptainLysander")
        {
            this.name = "Captain Lysander";

            this.previewPicture = SpaceMarinesPictures.lysander;
        }
    }
}
