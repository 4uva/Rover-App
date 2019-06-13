using System;
using System.Collections.Generic;
using System.Text;
using VehicleModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace RoverTests
{
    [TestClass]
    public class RightRotation_Tests
    {
        /*5*/
        [TestMethod]
        public void FacingNorth()
        {
            Rover rover = new Rover(0, 2, RoverFacing.North);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.East, roverfacing);
        }
        /*6*/
        [TestMethod]
        public void FacingEast()
        {
            Rover rover = new Rover(-2, 0, RoverFacing.East);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.South, roverfacing);
        }
        /*7*/
        [TestMethod]
        public void FacingSouth()
        {
            Rover rover = new Rover(0, -2, RoverFacing.South);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.West, roverfacing);
        }
        /*8*/
        [TestMethod]
        public void FacingWest()
        {
            Rover rover = new Rover(0, 0, RoverFacing.West);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.North, roverfacing);
        }
    }
}
