using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rover_ConsoleApp;


namespace RoverTests
{ [TestClass]
    class Playground_Tests
    {
        [TestMethod]
        public bool IsPointInside()
            {
            PlayGround playground = new PlayGround(0, 0, 3, 3 );
            playground.IsPointInside();
                Assert.AreEqual(1, 1, true);

           
        }
            //        пример теста
            //1) мы создаём Playground с границами xmin = 0, ymin = 0, xmax = 3, ymax = 3, спрашиваем, внутри ли точка(1, 1), ожидаемый ответ — да
            //2) мы создаём Playground с границами xmin = 0, ymin = 0, xmax = 3, ymax = 3, спрашиваем, внутри ли точка(0, 3), ожидаемый ответ — да
            //3) мы создаём Playground с границами xmin = 0, ymin = 0, xmax = 3, ymax = 3, спрашиваем, внутри ли точка(-1, 2), ожидаемый ответ — нет
            //4) мы создаём Playground с границами xmin = 0, ymin = 0, xmax = 3, ymax = 3, спрашиваем, внутри ли точка(2, 4), ожидаемый ответ — нет
            //5) мы создаём Playground с границами xmin = 0, ymin = 0, xmax = 3, ymax = 3, спрашиваем, внутри ли точка(5, -1), ожидаемый ответ — нет
    }
}
