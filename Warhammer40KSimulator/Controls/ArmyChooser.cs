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
using System.Linq;

namespace Warhammer40KSimulator.Controls
{
    public partial class ArmyChooser : UserControl, IArmyChooserView
    {
        private List<TreeNode> topNodeList;

        private ArmyChoosingPresenter presenter;

        public ArmyChooser()
        {
            InitializeComponent();
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            hqNode, elitesNode, troopsNode, dedicatedTransportsNode, fastAttackNode, heavySupportNode});

            this.topNodeList = new List<TreeNode>();
            this.topNodeList.Add(hqNode);
            this.topNodeList.Add(elitesNode);
            this.topNodeList.Add(troopsNode);
            this.topNodeList.Add(dedicatedTransportsNode);
            this.topNodeList.Add(fastAttackNode);
            this.topNodeList.Add(heavySupportNode);
        }

        public void ClearList()
        {
            this.topNodeList.ForEach(x => x.Nodes.Clear());
        }

        public void AddToList(string name, string role, object unitData)
        {
            var roleNode = this.topNodeList.Single(x => x.Name == role);
            if (roleNode != null)
            {
                roleNode.Nodes.Add(new TreeNode(name)
                                       {
                                           Tag = unitData
                                       });
            }
        }

        void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateUnitData();
        }

        private void UpdateUnitData()
        {
            if (this.treeView1.SelectedNode != null &&this.treeView1.SelectedNode.Tag != null)
            {
                this.presenter.DisplayUnitData(this.treeView1.SelectedNode.Tag);
            }
            else
            {
                this.presenter.ClearUnitData();
            }
        }


        public void SetPresenter(ArmyChoosingPresenter presenter)
        {
            this.presenter = presenter;
        }
    }
}
