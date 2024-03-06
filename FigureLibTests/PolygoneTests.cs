using FigureLib;
using FigureLib.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresLibTests
{
    [TestClass]
    public class PolygonTests
    {
        [TestMethod]
        public void PolygonAreaTest()
        {
            var dotList = new List<Dot>();
            var polygone = new Polygone(dotList);
            dotList.Add(new Dot(-3, -2));
            dotList.Add(new Dot(-6, -2));

            polygone.UpdateArea();
            Assert.AreEqual(0, polygone.Area);

            dotList.Add(new Dot(-6, 2));

            polygone.UpdateArea();
            Assert.AreEqual(6, polygone.Area);

            dotList.Add(new Dot(-3, 2));

            polygone.UpdateArea();
            Assert.AreEqual(12, polygone.Area);
        }
    }
}
