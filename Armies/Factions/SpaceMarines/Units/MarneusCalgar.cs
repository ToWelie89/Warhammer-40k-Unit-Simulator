using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class MarneusCalgar : Unit
    {
        public MarneusCalgar() : base(UnitConstants.SPACE_MARINES_ARMY, "MarneusCalgar")
        {
            this.name = "Marneus Calgar";

            this.chapterRestrictions = new string[] { SpaceMarines.ULTRAMARINES };

            this.previewPicture = SpaceMarinesPictures.Gareth_Marneus2;
        }
    }
}
