
namespace DesignPatterns.Patterns.Creational.Prototype
{
    public class PrototypeHalfOrc : Prototype
    {
        public PrototypeHalfOrc(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
