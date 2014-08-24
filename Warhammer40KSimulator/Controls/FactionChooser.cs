using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warhammer40KSimulator.Presentation;
using Warhammer40KSimulator.Presentation.ArmyChoosing;

namespace Warhammer40KSimulator.Controls
{
    public partial class FactionChooser : UserControl, IFactionChooserView
    {
        private const string DEFAULT_VALUE = "---CHOOSE ARMY---";

        private ArmyChoosingPresenter presenter;

        public FactionChooser()
        {
            InitializeComponent();
            this.comboBox1.Items.Add(DEFAULT_VALUE);
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentItemName = this.comboBox1.SelectedItem.ToString();

            if (currentItemName != DEFAULT_VALUE)
            {
                this.presenter.FillArmyViewBasedOnFaction(currentItemName);
            }
        }

        public void SetPresenter(ArmyChoosingPresenter presenter)
        {
            this.presenter = presenter;
        }

        #region IFactionChooserView members

        public void AddFactionToView(string name)
        {
            this.comboBox1.Items.Add(name);
        }
        
        #endregion
    }
}
