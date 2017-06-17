using System;

namespace DesignPatterns.Patterns.Behavioural.Memento
{
    /// <summary>
    /// Class representing a navigator which explores a map space by setting its coordinates
    /// to new positions. It can save its position, generating a memento which it can
    /// later restore from.
    /// </summary>
    public class Navigator
    {
        private int _x;
        private int _y;

        public void SetState(int x, int y)
        {
            _x = x;
            _y = y;

            Console.WriteLine(string.Format("Position set to [{0},{1}]", x, y));
        }

        public SaveMapPosition SavePosition()
        {
            Console.WriteLine(string.Format("Position saved at [{0},{1}]", _x, _y));

            return new SaveMapPosition(_x, _y);
        }

        public void RestoreSavePosition(SaveMapPosition position)
        {
            _x = position.X;
            _y = position.Y;

            Console.WriteLine(string.Format("Position restored to [{0},{1}]", _x, _y));
        }
    }
}
