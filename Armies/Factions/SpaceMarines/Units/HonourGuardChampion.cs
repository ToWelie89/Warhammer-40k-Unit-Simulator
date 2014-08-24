using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class HonourGuardChampion : Unit
    {
        public HonourGuardChampion() : base(UnitConstants.SPACE_MARINES_ARMY, "HonourGuardChampion")
        {
            this.name = "Honour Guard Champion";

            this.previewPicture = SpaceMarinesPictures.chapterchampion;
        }
    }
}
