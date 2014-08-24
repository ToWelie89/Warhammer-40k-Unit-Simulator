namespace Warhammer40KSimulator.Presentation.ArmyChoosing
{
    public interface IArmyChooserView
    {
        void ClearList();

        void AddToList(string item, string role, object unitData);
    }
}
