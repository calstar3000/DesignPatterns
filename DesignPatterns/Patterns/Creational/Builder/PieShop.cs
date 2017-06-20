using DesignPatterns.Patterns.Creational.Builder.Interfaces;

namespace DesignPatterns.Patterns.Creational.Builder
{
    /// <summary>
    /// The Director, responsible for invoking the different Builders.
    /// It holds the building process, whereas each builder implements its own version of each step.
    /// </summary>
    public class PieShop
    {
        public void BuildPies()
        {
            var minceAndCheesePieBuilder = new BuilderMinceAndCheesePie();
            var potatoTopPieBuilder = new BuilderPotatoTopPie();
            var blueberryPieBuilder = new BuilderBlueberryPie();

            BuildPie(minceAndCheesePieBuilder);
            BuildPie(potatoTopPieBuilder);
            BuildPie(blueberryPieBuilder);

            minceAndCheesePieBuilder.PieInstance.Display();
            potatoTopPieBuilder.PieInstance.Display();
            blueberryPieBuilder.PieInstance.Display();
        }

        public void BuildPie(IPieBuilder builder)
        {
            builder.MakePastry();
            builder.AddFilling();
            builder.AddToppig();
        }
    }
}
