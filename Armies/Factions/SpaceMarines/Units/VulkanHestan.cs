using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Armies.Factions.SpaceMarines.Units
{
    class VulkanHestan : Unit
    {
        public VulkanHestan() : base(UnitConstants.SPACE_MARINES_ARMY, "VulkanHestan")
        {
            this.name = "Vulkan Hestan";

            this.previewPicture = SpaceMarinesPictures.vulkan_hestan;
        }
    }
}
