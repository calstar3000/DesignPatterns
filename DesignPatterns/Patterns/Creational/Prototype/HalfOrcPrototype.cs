
namespace DesignPatterns.Patterns.Creational.Prototype
{
    public class HalfOrcPrototype : Prototype
    {
        public HalfOrcPrototype(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
