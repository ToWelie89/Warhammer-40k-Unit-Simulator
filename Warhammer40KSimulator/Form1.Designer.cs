namespace Warhammer40KSimulator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstArmyGroupBox = new System.Windows.Forms.GroupBox();
            this.factionChooser1 = new Warhammer40KSimulator.Controls.FactionChooser();
            this.unitStatsViewer1 = new Warhammer40KSimulator.Controls.UnitStatsViewer();
            this.armyChooser1 = new Warhammer40KSimulator.Controls.ArmyChooser();
            this.previewPicturePanel1 = new Warhammer40KSimulator.Controls.PreviewPicturePanel();
            this.firstArmyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstArmyGroupBox
            // 
            this.firstArmyGroupBox.Controls.Add(this.previewPicturePanel1);
            this.firstArmyGroupBox.Controls.Add(this.factionChooser1);
            this.firstArmyGroupBox.Controls.Add(this.unitStatsViewer1);
            this.firstArmyGroupBox.Controls.Add(this.armyChooser1);
            this.firstArmyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.firstArmyGroupBox.Name = "firstArmyGroupBox";
            this.firstArmyGroupBox.Size = new System.Drawing.Size(486, 439);
            this.firstArmyGroupBox.TabIndex = 0;
            this.firstArmyGroupBox.TabStop = false;
            this.firstArmyGroupBox.Text = "Army 1";
            // 
            // factionChooser1
            // 
            this.factionChooser1.Location = new System.Drawing.Point(7, 20);
            this.factionChooser1.Name = "factionChooser1";
            this.factionChooser1.Size = new System.Drawing.Size(175, 30);
            this.factionChooser1.TabIndex = 2;
            // 
            // unitStatsViewer1
            // 
            this.unitStatsViewer1.Location = new System.Drawing.Point(238, 55);
            this.unitStatsViewer1.Name = "unitStatsViewer1";
            this.unitStatsViewer1.Size = new System.Drawing.Size(233, 138);
            this.unitStatsViewer1.TabIndex = 1;
            // 
            // armyChooser1
            // 
            this.armyChooser1.Location = new System.Drawing.Point(6, 55);
            this.armyChooser1.Name = "armyChooser1";
            this.armyChooser1.Size = new System.Drawing.Size(226, 378);
            this.armyChooser1.TabIndex = 0;
            // 
            // previewPicturePanel1
            // 
            this.previewPicturePanel1.Location = new System.Drawing.Point(239, 200);
            this.previewPicturePanel1.Name = "previewPicturePanel1";
            this.previewPicturePanel1.Size = new System.Drawing.Size(232, 233);
            this.previewPicturePanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 463);
            this.Controls.Add(this.firstArmyGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(472, 268);
            this.Name = "Form1";
            this.Text = "Warhammer 40\'000 Simulator";
            this.firstArmyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox firstArmyGroupBox;
        private Controls.ArmyChooser armyChooser1;
        private Controls.FactionChooser factionChooser1;
        private Controls.UnitStatsViewer unitStatsViewer1;
        private Controls.PreviewPicturePanel previewPicturePanel1;
    }
}

