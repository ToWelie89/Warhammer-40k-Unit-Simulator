using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class HighMarshalHelbrecht : Unit
    {
        public HighMarshalHelbrecht() : base(UnitConstants.SPACE_MARINES_ARMY, "HighMarshalHelbrecht")
        {
            this.name = "High Marshal Helbrecht";

            this.previewPicture = SpaceMarinesPictures.black_templars_high_marshal_helbrecht_by_cene801_d4wavsp;
        }
    }
}
