using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class TheEmperorsChampion : Unit
    {
        public TheEmperorsChampion() : base(UnitConstants.SPACE_MARINES_ARMY, "TheEmperorsChampion")
        {
            this.name = "The Emperors Champion";

            this.previewPicture = SpaceMarinesPictures.emperors_champ;
        }
    }
}
