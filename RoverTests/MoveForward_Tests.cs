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
        public void MoveForward()
        {
            Rover rover = new Rover(1, 1, RoverFacing.North);
            rover.MoveForward();
            Assert.AreEqual(2, rover.RoverPositionX);
            Assert.AreEqual(1, rover.RoverPositionY);
        }
    }
}
