using Homework_6;

namespace Lesson_6.Test
{
    [TestClass]
    public class Hw_MathTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // assemble
            var sut = new Hw_Math();
            // act 
            var result = sut.Div(10, 2);
            // assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ZeroDividedByAnyIsZero()
        {
            // assemble
            var sut = new Hw_Math();
            // act 
            var result = sut.Div(0, 10);
            // assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DivideByZero()
        {
            // assemble
            var sut = new Hw_Math();
            // act 
             
            // assert
            Assert.ThrowsException<DivideByZeroException>(() => sut.Div(10, 0));
        }
    }
}