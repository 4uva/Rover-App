using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class LeftRotation_Tests
    {
        /*1*/
        [TestMethod]
        public void FacingNorth()
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
        public void FacingWest()
        {
            Rover rover = new Rover(-2, 0, RoverFacing.West);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.South, roverfacing);
        }
        /*3*/
        [TestMethod]
        public void FacingSouth()
        {
            Rover rover = new Rover(0, 2, RoverFacing.South);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.East, roverfacing);
        }
        /*4*/
        [TestMethod]
        public void FacingEast()
        {
            Rover rover = new Rover(2, 0, RoverFacing.East);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.RoverFacing;
            Assert.AreEqual(RoverFacing.North, roverfacing);
        }
    }
}
