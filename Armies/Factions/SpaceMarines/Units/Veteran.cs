using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class Veteran : Unit
    {
        public Veteran() : base(UnitConstants.SPACE_MARINES_ARMY, "Veteran")
        {
            this.name = "Veteran";
        }
    }
}
