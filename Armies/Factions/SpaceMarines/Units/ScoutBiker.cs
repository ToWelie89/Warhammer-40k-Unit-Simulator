using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class ScoutBiker : Unit
    {
        public ScoutBiker() : base(UnitConstants.SPACE_MARINES_ARMY, "ScoutBiker")
        {
            this.name = "Scout Biker";
        }
    }
}
