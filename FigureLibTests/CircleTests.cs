using FigureLib.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresLibTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var testCircle = new Circle(10);
            Assert.AreEqual(314.159265, testCircle.Area, 0.0001);
        }

        [TestMethod]
        public void AreaTestNegativeRadius()
        {
            var testCircle = new Circle(-3);
            Assert.AreEqual(0, testCircle.Area);
        }

        [TestMethod]
        public void GetAreaMethodTest()
        {
            Assert.AreEqual(12.5664, Circle.GetArea(2), 0.0001);
        }

        [TestMethod]
        public void AreaChangeRadiusTest()
        {
            var testCircle = new Circle(1);
            Assert.AreEqual(3.1416, testCircle.Area, 0.0001);
            testCircle.Radius = 5;
            Assert.AreEqual(78.5398, testCircle.Area, 0.0001);
        }
    }
}
