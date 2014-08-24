using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class Terminator : Unit
    {
        public Terminator() : base(UnitConstants.SPACE_MARINES_ARMY, "Terminator")
        {
            this.name = "Terminator";
        }
    }
}
