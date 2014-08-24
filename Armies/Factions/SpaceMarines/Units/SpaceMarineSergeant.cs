using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class SpaceMarineSergeant : Unit
    {
        public SpaceMarineSergeant() : base(UnitConstants.SPACE_MARINES_ARMY, "SpaceMarineSergeant")
        {
            this.name = "Space Marine Sergeant";
        }
    }
}
