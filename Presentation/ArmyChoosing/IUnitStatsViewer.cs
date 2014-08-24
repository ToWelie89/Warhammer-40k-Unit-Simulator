using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer40KSimulator.Presentation.ArmyChoosing
{
    public interface IUnitStatsViewer
    {
        string WeaponSkill { set; }
        string BallisticSkill { set; }
        string Strength { set; }
        string Tougness { set; }
        string Wounds { set; }
        string Initiative { set; }
        string Attacks { set; }
        string Leadership { set; }
        string ArmorSave { set; }
        string Name { set; }

        void ClearData();
    }
}
