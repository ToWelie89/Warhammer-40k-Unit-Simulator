using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class SpaceMarineBiker : Unit
    {
        public SpaceMarineBiker() : base(UnitConstants.SPACE_MARINES_ARMY, "SpaceMarineBiker")
        {
            this.name = "Space Marine Biker";
        }
    }
}
