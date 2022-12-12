using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace UnitTestsTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSide1mustBe3()
        {
            // Expected
            int side1 = 3;

            // Actual
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));
            double actualSide1 = triangle.DistanceBetween1and2();

            // Assert
            Assert.AreEqual(side1, actualSide1);
        }

        [TestMethod]
        public void TestSide2Mustbe4()
        {
            // Expected
            int side2 = 4;

            // Actual
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));
            double actualSide2 = triangle.DistanceBetween1and3();

            // Assert
            Assert.AreEqual(side2, actualSide2);
        }

        [TestMethod]
        public void TestSide2Mustbe5()
        {
            // Expected
            int side3 = 5;

            // Actual
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));
            double actualSide3 = triangle.DistanceBetween2and3();

            // Assert
            Assert.AreEqual(side3, actualSide3);
        }

        [TestMethod]
        public void TestPerimeterMustbe12()
        {
            // Expected
            double expectedPerimeter = 12;

            // Actual
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));
            double actualPerimeter = triangle.Perimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}

