using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Memento
{
    /// <summary>
    /// Class representing the "caretaker" of the mementos (map positions) created
    /// by the navigator as it explores the map space. This class keeps track
    /// of all the mementos created, and allows the navigator to restore its position
    /// from the most recent one.
    /// </summary>
    public class MissionControl
    {
        private List<SaveMapPosition> _savePositions;

        public MissionControl()
        {
            _savePositions = new List<SaveMapPosition>();
        }

        public void AddSaveMapPosition(SaveMapPosition position)
        {
            _savePositions.Add(position);
        }

        public SaveMapPosition GetLastSaveMapPosition()
        {
            return _savePositions[_savePositions.Count - 1];
        }
    }
}
