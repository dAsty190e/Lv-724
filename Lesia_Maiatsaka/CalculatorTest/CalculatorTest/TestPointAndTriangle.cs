using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndTriangle;

namespace Test
{
    [TestClass]
    public class TestPointAndTriangle
    {
        [TestMethod]
        public void Point()
        {
            // assemble
            var newPoint = new Point(1, 2);
            // act
            var distance = newPoint.Distance(new Point(3, 4));
            // assert
            Assert.AreEqual(10, distance);
        }

        [TestMethod]
        public void Triangle() 
        {
            // assemble
            var newTriangle = new Triangle(new Point(12,3), new Point(3,4), new Point(4,15));
            // act
            var newPerimeter = newTriangle.Perimeter();
            // assert
            Assert.AreEqual(82, newPerimeter);
        }

    }
}
