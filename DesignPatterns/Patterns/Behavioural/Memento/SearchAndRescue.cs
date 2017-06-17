
namespace DesignPatterns.Patterns.Behavioural.Memento
{
    /// <summary>
    /// This class represents a search and rescue operation where a navigator
    /// explores a map space by setting its position to new coordinates. It can
    /// save a memento of its progress along the way and then restore its last
    /// saved position via the mission control class (the "caretaker").
    /// </summary>
    public class SearchAndRescue
    {
        public void Launch()
        {
            var missionControl = new MissionControl();
            var navigator = new Navigator();

            navigator.SetState(1, 1);
            navigator.SetState(10, 1);
            var savePosition = navigator.SavePosition();
            missionControl.AddSaveMapPosition(savePosition);
            navigator.SetState(12, 1);
            navigator.RestoreSavePosition(missionControl.GetLastSaveMapPosition());
        }
    }
}
