using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class Librarian : Unit
    {
        public Librarian() : base(UnitConstants.SPACE_MARINES_ARMY, "Librarian")
        {
            this.name = "Librarian";

            this.previewPicture = SpaceMarinesPictures.librarian;
        }
    }
}
