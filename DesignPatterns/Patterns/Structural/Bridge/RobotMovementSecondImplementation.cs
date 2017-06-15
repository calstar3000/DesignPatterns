using System;

namespace DesignPatterns.Patterns.Structural.Bridge
{
    /// <summary>
    /// Another example of a concrete implementation of the robot's movement abstraction.
    /// </summary>
    public class RobotMovementSecondImplementation : RobotMovementAbstraction
    {
        public override void MoveForwards()
        {
            Console.WriteLine("Robot crawls forwards");
        }

        public override void MoveBackwards()
        {
            Console.WriteLine("Robot crawls backwards");
        }

        public override void MoveLeft()
        {
            Console.WriteLine("Robot crawls left");
        }

        public override void MoveRight()
        {
            Console.WriteLine("Robot crawls right");
        }

        public override void Jump()
        {
            Console.WriteLine("Robot can't jump");
        }
    }
}
