using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GameModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class Game_Tests
    {
        [TestMethod]
        public void RoverOutputTest()
        {
            // - When the user moves the rover to (1,1), the rover’s position is displayed in the format(1,1)
            Position position = new Position(1, 1);
            IRover rover = new FakeRover(position);
            TextReader inputSource = new StringReader("F\n");
            TextWriter outputTarget = new StringWriter();

            Game game = new Game(rover, inputSource, outputTarget);
            game.RunStep();
            string output = outputTarget.ToString();
            StringAssert.Contains(output, "(1,1)");
        }

        class FakeRover : IRover
        {
            public FakeRover(Position position)
            {
                Position = position;
            }

            public Position Position { get; }
            public RoverFacing Facing => RoverFacing.North;

            public void MoveForward() { /* do nothing */ }
            public void TurnLeft() { /* do nothing */ }
            public void TurnRight() { /* do nothing */ }
        }
    }
}
