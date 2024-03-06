using FigureLib.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FiguresLibTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var myTriangle = new Triangle(6, 8, 10);
            Assert.AreEqual(24, myTriangle.Area);
        }

        [TestMethod]
        public void IsRightAngledTriangleTest()
        {
            var myTriangle = new Triangle(29, 20, 21);
            Assert.IsTrue(myTriangle.IsRight());
            myTriangle.A = 31;
            Assert.IsFalse(myTriangle.IsRight());
        }

        [TestMethod]
        public void GetAreaBySidesTest()
        {
            Assert.AreEqual(6, Triangle.GetAreaBySides(3, 4, 5));
        }
    }
}
