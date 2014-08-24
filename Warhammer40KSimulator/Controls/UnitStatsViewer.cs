using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warhammer40KSimulator.Presentation.ArmyChoosing;

namespace Warhammer40KSimulator.Controls
{
    public partial class UnitStatsViewer : UserControl, IUnitStatsViewer
    {
        public UnitStatsViewer()
        {
            InitializeComponent();
        }

        public string WeaponSkill { set { this.weaponSkillLabel.Text = value; } }
        public string BallisticSkill { set { this.ballisticSkillLabel.Text = value; } }
        public string Strength { set { this.strengthLabel.Text = value; } }
        public string Tougness { set { this.toughnessLabel.Text = value; } }
        public string Wounds { set { this.woundsLabel.Text = value; } }
        public string Initiative { set { this.initiativeLabel.Text = value; } }
        public string Attacks { set { this.attacksLabel.Text = value; } }
        public string Leadership { set { this.leadershipLabel.Text = value; } }
        public string ArmorSave { set { this.armorSaveLabel.Text = value; } }
        public string Name { set { this.nameLabel.Text = value; } }

        public void ClearData()
        {
            this.WeaponSkill = string.Empty;
            this.BallisticSkill = string.Empty;
            this.Strength = string.Empty;
            this.Tougness = string.Empty;
            this.Wounds = string.Empty;
            this.Initiative = string.Empty;
            this.Attacks = string.Empty;
            this.Leadership = string.Empty;
            this.ArmorSave = string.Empty;
            this.Name = string.Empty;
        }
    }
}
