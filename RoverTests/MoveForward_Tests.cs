using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class MoveForward_Tests
    {
        PlayGround playGround = new PlayGround(0, 0, 3, 3);

        //Given the Is at position 1.1 and
        //    the rover is facing North, 
        //    when the rover moves forward,
        //    the rover is in position 0,1.
        [TestMethod]
        public void StepNorth()
        {
            Position start = new Position(1, 1), expectedTarget = new Position(0, 1);
            Rover rover = new Rover(start, RoverFacing.North, playGround);
            rover.MoveForward();
            Assert.AreEqual(expectedTarget, rover.Position);
        }

        [TestMethod]
        public void StepEast()
        {
            Position start = new Position(1, 1), expectedTarget = new Position(1, 2);
            Rover rover = new Rover(start, RoverFacing.East, playGround);
            rover.MoveForward();
            Assert.AreEqual(expectedTarget, rover.Position);
        }

        [TestMethod]
        public void StepSouth()
        {
            Position start = new Position(1, 1), expectedTarget = new Position(2, 1);
            Rover rover = new Rover(start, RoverFacing.South, playGround);
            rover.MoveForward();
            Assert.AreEqual(expectedTarget, rover.Position);
        }

        [TestMethod]
        public void StepWest()
        {
            Position start = new Position(1, 1), expectedTarget = new Position(1, 0);
            Rover rover = new Rover(start, RoverFacing.West, playGround);
            rover.MoveForward();
            Assert.AreEqual(expectedTarget, rover.Position);
        }

        [TestMethod]
        public void StepWestBeforeGrid()
        {
            Rover rover = new Rover(new Position(0, 0), RoverFacing.West, playGround);
            rover.MoveForward();
            Assert.AreEqual(new Position(0, 0), rover.Position);
        }
    }
}

