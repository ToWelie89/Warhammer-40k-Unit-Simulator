using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class TerminatorSergeant : Unit
    {
        public TerminatorSergeant() : base(UnitConstants.SPACE_MARINES_ARMY, "TerminatorSergeant")
        {
            this.name = "Terminator Sergeant";
        }
    }
}
