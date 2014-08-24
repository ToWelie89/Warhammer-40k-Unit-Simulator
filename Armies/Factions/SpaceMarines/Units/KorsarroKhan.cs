using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class KorsarroKhan : Unit
    {
        public KorsarroKhan() : base(UnitConstants.SPACE_MARINES_ARMY, "KorsarroKhan")
        {
            this.name = "Kor'sarro Khan";

            this.chapterRestrictions = new string[] { SpaceMarines.SALAMANDERS };

            this.previewPicture = SpaceMarinesPictures.khan;
        }
    }
}
