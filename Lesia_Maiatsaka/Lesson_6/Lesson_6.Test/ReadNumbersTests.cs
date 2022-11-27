using Homework_6;

namespace Lesson_6.Test
{
    [TestClass]
    public class ReadNumbersTests
    {
        [TestMethod]
        public void ReadNumbers_Success()
        {
            // assemble
            var readNumbers = new ReadNumbers(10, 100);
            // act
            readNumbers.ReadNumber(15);
            readNumbers.ReadNumber(20);
            readNumbers.ReadNumber(35);
            readNumbers.ReadNumber(45);
            readNumbers.ReadNumber(55);
            // assert
        }

        [TestMethod]
        public void ReadNumbers_Fail_LessThanStart()
        {
            // assemble
            var readNumbers = new ReadNumbers(10, 100);
            // act
            Assert.ThrowsException<Exception>(() => readNumbers.ReadNumber(9));
            // assert
        }

        [TestMethod]
        public void ReadNumbers_Fail_GreaterThanEnd()
        {
            // assemble
            var readNumbers = new ReadNumbers(10, 100);
            // act
            Assert.ThrowsException<Exception>(() => readNumbers.ReadNumber(115));
            // assert
        }

        [TestMethod]
        public void ReadNumbers_Fail_LessThanCurrent()
        {
            // assemble
            var readNumbers = new ReadNumbers(10, 100);
            // act
            readNumbers.ReadNumber(60);
            Assert.ThrowsException<Exception>(() => readNumbers.ReadNumber(50));
            // assert
        }

        [TestMethod]
        public void ReadNumbers_Success_Complete()
        {
            // assemble
            var readNumbers = new ReadNumbers(10, 100);
            // act
            // assert
            Assert.AreEqual(true, readNumbers.Complete(100));
        }

        [TestMethod]
        public void ReadNumbers_Success_ValidNumbers()
        {
            // assemble
            var numbers = new List<int> { 15, 20, 35, 45, 55 };
            var readNumbers = new ReadNumbers(10, 100);
            // act
            foreach (var item in numbers)
            {
                readNumbers.ReadNumber(item);
            }
            // assert
            foreach (var item in numbers)
            {
                Assert.IsTrue(readNumbers.ValidNumbers.Contains(item));
            }
        }
    }
}
