using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class MasterOfTheForge : Unit
    {
        public MasterOfTheForge() : base(UnitConstants.SPACE_MARINES_ARMY, "MasterOfTheForge")
        {
            this.name = "Master of the Forge";

            this.previewPicture = SpaceMarinesPictures.masteroftheforge;
        }
    }
}
