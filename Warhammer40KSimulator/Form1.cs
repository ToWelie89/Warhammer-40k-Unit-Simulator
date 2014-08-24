using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warhammer40KSimulator.Presentation;
using Warhammer40KSimulator.Presentation.ArmyChoosing;

namespace Warhammer40KSimulator
{
    public partial class Form1 : Form
    {
        private ArmyChoosingPresenter armyChoosingPresenter;

        public Form1()
        {
            InitializeComponent();

            armyChoosingPresenter = new ArmyChoosingPresenter(this.armyChooser1, this.factionChooser1, this.unitStatsViewer1, this.previewPicturePanel1);
            this.factionChooser1.SetPresenter(this.armyChoosingPresenter);
            this.armyChooser1.SetPresenter(this.armyChoosingPresenter);
        }
    }
}
