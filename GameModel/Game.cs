using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using VehicleModel;

namespace GameModel
{
    public class Game
    {
        IRover rover;
        TextReader inputSource;
        TextWriter outputTarget;

        public Game(IRover rover, TextReader inputSource, TextWriter outputTarget)
        {
            this.rover = rover;
            this.inputSource = inputSource;
            this.outputTarget = outputTarget;
        }

        public void RunStep()
        {
            var command = inputSource.ReadLine();
            switch (command)
            {
                case "L":
                    rover.TurnLeft();
                    break;
                case "R":
                    rover.TurnRight();
                    break;
                case "F":
                    rover.MoveForward();
                    break;
                default:
                    throw new Exception("invalid command");
            }
            outputTarget.WriteLine($"Rover is now at ({rover.Position.X},{rover.Position.Y}) - facing {rover.Facing}");
        }
    }
}
