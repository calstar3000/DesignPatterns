
namespace DesignPatterns.Patterns.Creational.Prototype
{
    public class PrototypeOrc : Prototype
    {
        public PrototypeOrc(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
