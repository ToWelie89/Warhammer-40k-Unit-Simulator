using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Warhammer40KSimulator.Armies.Interfaces;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    public class SpaceMarine : Unit
    {
        public SpaceMarine() : base(UnitConstants.SPACE_MARINES_ARMY, "SpaceMarine")
        {
            this.name = "Space Marine";
        }
    }
}
