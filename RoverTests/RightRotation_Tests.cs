using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class RightRotation_Tests
    {
        PlayGround playGround = new PlayGround(0, 0, 3, 3);

        /*5*/
        [TestMethod]
        public void FacingNorth()
        {
            Rover rover = new Rover(new Position(0, 2), RoverFacing.North, playGround);
            rover.TurnRight();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.East, roverfacing);
        }

        /*6*/
        [TestMethod]
        public void FacingEast()
        {
            Rover rover = new Rover(new Position(1, 0), RoverFacing.East, playGround);
            rover.TurnRight();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.South, roverfacing);
        }

        /*7*/
        [TestMethod]
        public void FacingSouth()
        {
            Rover rover = new Rover(new Position(0, 1), RoverFacing.South, playGround);
            rover.TurnRight();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.West, roverfacing);
        }

        /*8*/
        [TestMethod]
        public void FacingWest()
        {
            Rover rover = new Rover(new Position(0, 0), RoverFacing.West, playGround);
            rover.TurnRight();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.North, roverfacing);
        }
    }
}
