using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class PedroKantor : Unit
    {
        public PedroKantor() : base(UnitConstants.SPACE_MARINES_ARMY, "PedroKantor")
        {
            this.name = "Pedro Kantor";

            this.previewPicture = SpaceMarinesPictures._180px_ChapterMasterPedroKantor;
        }
    }
}
