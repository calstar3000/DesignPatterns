
namespace DesignPatterns.Patterns.Creational.Prototype
{
    public abstract class Prototype
    {
        private int _id;

        public Prototype(int id)
        {
            _id = id;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public abstract Prototype Clone();
    }
}
