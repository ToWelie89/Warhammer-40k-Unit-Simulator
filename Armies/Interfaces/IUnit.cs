using System.Collections.Generic;
using System.Drawing;

namespace Warhammer40KSimulator.Armies.Interfaces
{
    public interface IUnit
    {
        int weaponSkill { get; set; }
        int ballisticSkill { get; set; }
        int strength { get; set; }
        int toughness { get; set; }
        int wounds { get; set; }
        int initiative { get; set; }
        int attacks { get; set; }
        int leadership { get; set; }
        int armourSave { get; set; }
        string name { get; set; }
        string chapter { get; set; }
        string[] chapterRestrictions { get; set; }
        Bitmap previewPicture { get; set; }
    }
}
