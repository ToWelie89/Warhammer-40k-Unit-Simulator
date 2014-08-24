using System.Windows.Forms;

namespace Warhammer40KSimulator.Controls
{
    partial class ArmyChooser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.hqNode = new TreeNode("HQ");
            this.elitesNode = new TreeNode("Elites");
            this.troopsNode = new TreeNode("Troops");
            this.dedicatedTransportsNode = new TreeNode("Dedicated Transports");
            this.fastAttackNode = new TreeNode("Fast Attack");
            this.heavySupportNode = new TreeNode("Heavy Support");
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(192, 145);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += treeView1_AfterSelect;
            //
            // hqNode
            //
            this.hqNode.Name = "HQ";
            //
            // hqNode
            //
            this.elitesNode.Name = "Elites";
            //
            // hqNode
            //
            this.troopsNode.Name = "Troops";
            //
            // hqNode
            //
            this.dedicatedTransportsNode.Name = "Dedicated Transports";
            //
            // hqNode
            //
            this.fastAttackNode.Name = "Fast Attack";
            //
            // hqNode
            //
            this.heavySupportNode.Name = "Heavy Support";

            // 
            // ArmyChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "ArmyChooser";
            this.Size = new System.Drawing.Size(192, 145);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView1;
        private TreeNode hqNode;
        private TreeNode elitesNode;
        private TreeNode troopsNode;
        private TreeNode dedicatedTransportsNode;
        private TreeNode fastAttackNode;
        private TreeNode heavySupportNode;
    }
}
