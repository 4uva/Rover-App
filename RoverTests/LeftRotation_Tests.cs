using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class LeftRotation_Tests
    {
        PlayGround playGround = new PlayGround(0, 0, 3, 3);

        /*1*/
        [TestMethod]
        public void FacingNorth()
        {
            // arrange
            Rover rover = new Rover(new Position(1, 1), RoverFacing.North, playGround);
            // act
            rover.TurnLeft();
            // assert
            RoverFacing roverfacing = rover.Facing;
            // (first expected than actual)
            Assert.AreEqual(RoverFacing.West, roverfacing);
        }

        /*2*/
        [TestMethod]
        public void FacingWest()
        {
            Rover rover = new Rover(new Position(1, 1), RoverFacing.West, playGround);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.South, roverfacing);
        }

        /*3*/
        [TestMethod]
        public void FacingSouth()
        {
            Rover rover = new Rover(new Position(0, 2), RoverFacing.South, playGround);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.East, roverfacing);
        }

        /*4*/
        [TestMethod]
        public void FacingEast()
        {
            Rover rover = new Rover(new Position(2, 0), RoverFacing.East, playGround);
            rover.TurnLeft();
            RoverFacing roverfacing = rover.Facing;
            Assert.AreEqual(RoverFacing.North, roverfacing);
        }
    }
}
