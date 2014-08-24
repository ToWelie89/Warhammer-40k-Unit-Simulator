using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class ChiefLibrarianTigurius : Unit
    {
        public ChiefLibrarianTigurius() : base(UnitConstants.SPACE_MARINES_ARMY, "ChiefLibrarianTigurius")
        {
            this.name = "Chief Librarian Tigurius";

            this.chapterRestrictions = new string[] { SpaceMarines.ULTRAMARINES };

            this.previewPicture = SpaceMarinesPictures.Ultramarine_Chief_Librarian_Tigurius_2;
        }
    }
}
