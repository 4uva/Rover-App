using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleModel;

namespace RoverTests
{
    [TestClass]
    public class Playground_Tests
    {
        [TestMethod]
        public void Inside()
        {
            PlayGround playground = new PlayGround(0, 0, 3, 3);
            var result = playground.IsPointInside(new Position(1, 1));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void OnBorder()
        {
            PlayGround playground = new PlayGround(0, 0, 3, 3);
            var result = playground.IsPointInside(new Position(0, 3));
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TooSmallX()
        {
            PlayGround playground = new PlayGround(0, 0, 3, 3);
            var result = playground.IsPointInside(new Position(-1, 2));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TooBigY()
        {
            PlayGround playground = new PlayGround(0, 0, 3, 3);
            var result = playground.IsPointInside(new Position(2, 4));
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void BothCoordinatesOut()
        {
            PlayGround playground = new PlayGround(0, 0, 3, 3);
            var result = playground.IsPointInside(new Position(5, -1));
            Assert.AreEqual(result, false);
        }
    }
}
