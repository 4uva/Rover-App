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
        //Given the Is at position 1.1 and
        //    the rover is facing North, 
        //    when the rover moves forward,
        //    the rover is in position 0,1.
        [TestMethod]
        public void StepNorth()
        {
            Rover rover = new Rover(1, 1, RoverFacing.North);
            rover.MoveForward();
            Assert.AreEqual(0, rover.RoverPositionX);
            Assert.AreEqual(1, rover.RoverPositionY);
        }

        [TestMethod]
        public void StepEast()
        {
            Rover rover = new Rover(1, 1, RoverFacing.East);
            rover.MoveForward();
            Assert.AreEqual(1, rover.RoverPositionX);
            Assert.AreEqual(2, rover.RoverPositionY);
        }
    }
}
