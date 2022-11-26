using Homework_6;

namespace Lesson_6.Test
{
    [TestClass]
    public class UnitTest1
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
    }
}