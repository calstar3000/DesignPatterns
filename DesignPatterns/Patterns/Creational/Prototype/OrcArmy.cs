using System;

namespace DesignPatterns.Patterns.Creational.Prototype
{
    public class OrcArmy
    {
        public void Spawn()
        {
            var halfOrcPrototype = new HalfOrcPrototype(1);

            var halfOrc1 = halfOrcPrototype.Clone();
            // ...
            var halfOrc1000 = halfOrcPrototype.Clone();

            Console.WriteLine(string.Format("HalfOrc1 has id {0}", halfOrc1.Id));
            Console.WriteLine(string.Format("HalfOrc1000 has id {0}", halfOrc1000.Id));

            var orcPrototype = new OrcPrototype(2);

            var orc1 = orcPrototype.Clone();
            // ...
            var orc1000 = orcPrototype.Clone();

            Console.WriteLine(string.Format("Orc1 has id {0}", orc1.Id));
            Console.WriteLine(string.Format("Orc1000 has id {0}", orc1000.Id));
        }
    }
}
