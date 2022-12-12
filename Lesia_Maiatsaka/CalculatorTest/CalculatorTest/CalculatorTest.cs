using Calculator;
 
namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void MathTest()
        {
            var sum = new ClassCalculator();
            Assert.AreEqual(2, sum.Sum(1, 1));
            
            var multyply = new ClassCalculator();
            Assert.AreEqual(4, multyply.Multyply(2, 2));
            
            var divide = new ClassCalculator();
            Assert.AreEqual(3, divide.Divide(7, 2));
            
            var divideDouble = new ClassCalculator();
            Assert.AreEqual(3.5, divideDouble.Divide(7.0, 2.0));
           
            var subtrac = new ClassCalculator();
            Assert.AreEqual(2, subtrac.Subtraction(4, 2));
        }
    }
}