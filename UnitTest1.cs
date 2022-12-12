
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorSpace;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition_5and10_return_15()
        {
            // arrange
            int x = 5;
            int y = 10;
            int expected = 15;

            // actual
            Calculator calculator = new Calculator();
            int result = calculator.Addition(x, y);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Subtraction_10and5_return_5()
        {
            // arrange
            int x = 10;
            int y = 5;
            int expected = 5;

            // actual
            Calculator calculator = new Calculator();
            int actual = calculator.Subtraction(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_7and8_expected48()
        {
            // arrange
            int x = 7;
            int y = 8;
            int expected = 56;

            // actual
            Calculator calculator = new Calculator();
            int actual = calculator.Multiplication(x, y);

            // assert
            Assert.AreEqual(expected , actual);
        }

        [TestMethod]
        public void Division_81and9_expected_9()
        {
            // arrange
            int x = 81;
            int y = 9;
            float expected = 9;

            // actual
            Calculator calculator = new Calculator();
            float actual = calculator.Division(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }

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


