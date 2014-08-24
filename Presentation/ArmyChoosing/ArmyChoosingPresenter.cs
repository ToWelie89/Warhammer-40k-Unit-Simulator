using System;
using System.IO;
using System.Reflection;
using System.Xml;
using Warhammer40KSimulator.Armies;
using Warhammer40KSimulator.Armies.Factions.SpaceMarines;
using Warhammer40KSimulator.Armies.Interfaces;

namespace Warhammer40KSimulator.Presentation.ArmyChoosing
{
    public class ArmyChoosingPresenter
    {
        private IArmyChooserView armyChooserView;

        private IFactionChooserView factionChooserView;

        private IUnitStatsViewer unitStatsViewer;

        private IPreviewPicturePanel previewPicturePanel;

        public ArmyChoosingPresenter(IArmyChooserView armyChooserView,
                                     IFactionChooserView factionChooserView,
                                     IUnitStatsViewer unitStatsViewer,
                                     IPreviewPicturePanel previewPicturePanel)
        {
            this.armyChooserView = armyChooserView;
            this.factionChooserView = factionChooserView;
            this.unitStatsViewer = unitStatsViewer;
            this.previewPicturePanel = previewPicturePanel;

            foreach (var army in UnitConstants.ARMY_FACTIONS)
            {
                factionChooserView.AddFactionToView(army);
            }
        }

        public void FillArmyViewBasedOnFaction(string factionName)
        {
            this.armyChooserView.ClearList();

            IFaction faction;

            switch (factionName)
            {
                case UnitConstants.SPACE_MARINES_ARMY:
                    faction = new SpaceMarines();
                    break;
                default:
                    return;
            }

            faction.Troops.ForEach(x => this.armyChooserView.AddToList(x.name, UnitConstants.TROOPS_ROLE, x));
            faction.HQ.ForEach(x => this.armyChooserView.AddToList(x.name, UnitConstants.HQ_ROLE, x));
        }

        public void DisplayUnitData(object unitDataObject)
        {
            var unitData = (IUnit) unitDataObject;

            this.unitStatsViewer.ArmorSave = unitData.armourSave.ToString();
            this.unitStatsViewer.Attacks = unitData.attacks.ToString();
            this.unitStatsViewer.BallisticSkill = unitData.ballisticSkill.ToString();
            this.unitStatsViewer.Initiative = unitData.initiative.ToString();
            this.unitStatsViewer.Leadership = unitData.leadership.ToString();
            this.unitStatsViewer.Name = unitData.name;
            this.unitStatsViewer.Strength = unitData.strength.ToString();
            this.unitStatsViewer.Tougness = unitData.toughness.ToString();
            this.unitStatsViewer.WeaponSkill = unitData.weaponSkill.ToString();
            this.unitStatsViewer.Wounds = unitData.wounds.ToString();

            this.previewPicturePanel.UpdatePicture(unitData.previewPicture);
        }

        public void ClearUnitData()
        {
            this.unitStatsViewer.ClearData();
            this.previewPicturePanel.UpdatePicture(null);
        }
    }
}
