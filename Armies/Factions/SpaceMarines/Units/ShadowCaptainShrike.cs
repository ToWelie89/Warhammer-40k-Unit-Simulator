using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class ShadowCaptainShrike : Unit
    {
        public ShadowCaptainShrike() : base(UnitConstants.SPACE_MARINES_ARMY, "ShadowCaptainShrike")
        {
            this.name = "Shadow Captain Shrike";

            this.chapterRestrictions = new string[] { SpaceMarines.RAVEN_GUARD };

            this.previewPicture = SpaceMarinesPictures.shadow_captain_kayvaan_shrike;
        }
    }
}
