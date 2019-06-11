using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class RotationTests
    {
        /*1*/
        [TestMethod]
        public void FacingNorthTurnLeft()
        {
            // arrange
            Rover rover = new Rover(0, -2, RoverFacing.North);
            // act
            rover.TurnLeft();
            // assert
            RoverFacing roverfacing = rover.RoverFacing;
            // (first expected than actual)
            Assert.AreEqual(RoverFacing.West, roverfacing);
        }
        /*2*/
        [TestMethod]
        public void FacingWestTurnLeft()
        {
            Rover rover = new Rover(-2, 0, RoverFacing.West);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.South, roverfacing);
        }
        /*3*/
        [TestMethod]
        public void FacingSouthTurnLeft()
        {
            Rover rover = new Rover(0, 2, RoverFacing.South);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.East, roverfacing);
        }
        /*4*/
        [TestMethod]
        public void FacingEastTurnLeft()
        {
            Rover rover = new Rover(2, 0, RoverFacing.East);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.North, roverfacing);
        }
        /*5*/
        [TestMethod]
        public void FacingNorthTurnRight()
        {
            Rover rover = new Rover(0, 2, RoverFacing.North);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.East, roverfacing);
        }
        /*6*/
        [TestMethod]
        public void FacingEastTurnRight()
        {
            Rover rover = new Rover(-2, 0, RoverFacing.East);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.South, roverfacing);
        }
        /*7*/
        [TestMethod]
        public void FacingSouthTurnRight()
        {
            Rover rover = new Rover(0, -2, RoverFacing.South);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.West, roverfacing);
        }
        /*8*/
        [TestMethod]
        public void FacingWestTurnRight()
        {
            Rover rover = new Rover(0, 0, RoverFacing.West);
            rover.TurnRight();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.North, roverfacing);
        }
    }
}
