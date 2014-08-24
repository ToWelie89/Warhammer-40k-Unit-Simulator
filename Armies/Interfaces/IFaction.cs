using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Interfaces
{
    public interface IFaction
    {
        string Name { get; set; }

        List<IUnit> HQ { get; set; }

        List<IUnit> Troops { get; set; }
    }
}
