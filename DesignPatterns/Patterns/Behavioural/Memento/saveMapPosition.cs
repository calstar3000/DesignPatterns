
namespace DesignPatterns.Patterns.Behavioural.Memento
{
    /// <summary>
    /// The "memento" class, this is an artifact created when the navigator
    /// saves its position. It can then be used to restore from later.
    /// </summary>
    public class SaveMapPosition
    {
        private int _x;
        private int _y;

        public SaveMapPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }
    }
}
