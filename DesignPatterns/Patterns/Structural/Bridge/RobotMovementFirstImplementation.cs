using System;

namespace DesignPatterns.Patterns.Structural.Bridge
{
    /// <summary>
    /// One example of a concrete implementation of the robot's movement abstraction.
    /// </summary>
    public class RobotMovementFirstImplementation : RobotMovementAbstraction
    {
        public override void MoveForwards()
        {
            Console.WriteLine("Robot walks forwards");
        }

        public override void MoveBackwards()
        {
            Console.WriteLine("Robot walks backwards");
        }

        public override void MoveLeft()
        {
            Console.WriteLine("Robot walks left");
        }

        public override void MoveRight()
        {
            Console.WriteLine("Robot walks right");
        }

        public override void Jump()
        {
            Console.WriteLine("Robot jumps");
        }
    }
}
