using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class Scout : Unit
    {
        public Scout() : base(UnitConstants.SPACE_MARINES_ARMY, "Scout")
        {
            this.name = "Scout";
        }
    }
}
