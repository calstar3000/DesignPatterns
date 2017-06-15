
namespace DesignPatterns.Patterns.Creational.Prototype
{
    public class OrcPrototype : Prototype
    {
        public OrcPrototype(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
