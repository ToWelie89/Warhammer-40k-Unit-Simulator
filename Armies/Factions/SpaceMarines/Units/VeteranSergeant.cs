using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class VeteranSergeant : Unit
    {
        public VeteranSergeant() : base(UnitConstants.SPACE_MARINES_ARMY, "VeteranSergeant")
        {
            this.name = "Veteran Sergeant";
        }
    }
}
