using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class ScoutSergeant : Unit
    {
        public ScoutSergeant() : base(UnitConstants.SPACE_MARINES_ARMY, "ScoutSergeant")
        {
            this.name = "Scout Sergeant";
        }
    }
}
