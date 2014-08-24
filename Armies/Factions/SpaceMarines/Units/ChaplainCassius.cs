using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class ChaplainCassius : Unit
    {
        public ChaplainCassius() : base(UnitConstants.SPACE_MARINES_ARMY, "ChaplainCassius")
        {
            this.name = "Chaplain Cassius";

            this.chapterRestrictions = new string[] { SpaceMarines.ULTRAMARINES };

            this.previewPicture = SpaceMarinesPictures.Chaplain_Cassius_Model;
        }
    }
}
