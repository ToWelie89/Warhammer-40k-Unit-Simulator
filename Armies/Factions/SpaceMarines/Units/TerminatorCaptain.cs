using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class TerminatorCaptain : Unit
    {
        public TerminatorCaptain() : base(UnitConstants.SPACE_MARINES_ARMY, "TerminatorCaptain")
        {
            this.name = "Terminator Captain";

            this.previewPicture = SpaceMarinesPictures.terminatorcaptain;
        }
    }
}
