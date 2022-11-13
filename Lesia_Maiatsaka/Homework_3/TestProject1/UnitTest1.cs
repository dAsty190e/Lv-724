using Task_3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task6_Run()
        {
            var numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "-8" };
            Assert.AreEqual(Task_6.Run(numbers), -6720);
        }

        [TestMethod]
        public void Validation_IsValid()
        {
            var numbers = new string[] { "1", "2", "3", "4", "5", "6", };
            Assert.IsTrue(Task_6.IsValid(numbers));
        }

        [TestMethod]
        public void Validation_IsValid_ExactlyFive()
        {
            var numbers = new string[] { "1", "2", "3", "4", "5" };
            Assert.IsTrue(Task_6.IsValid(numbers));
        }

        [TestMethod]
        public void Validation_IsInvalid()
        {
            var numbers = new string[] { "1", "2", "3" };
            Assert.IsFalse(Task_6.IsValid(numbers));
        }


        [TestMethod]
        public void ParseNumbers_IsSuccess()
        {
            var numbers = new string[] { "1", "2", "3" };
            var expected = new List<int> { 1, 2, 3 };
            var numbersAsInts = Task_6.ParseNumbers(numbers);
            Assert.AreEqual(expected.Count(), numbersAsInts.Count());
            for (int i = 0; i < numbersAsInts.Count(); i++)
            {
                Assert.AreEqual(expected[i], numbersAsInts.ElementAt(i));
            }
        }

        [TestMethod]
        public void ParseNumbers_IsFailed()
        {
            var numbers = new string[] { "1", "4" };
            var expected = new List<int> { 4 };
            var numbersAsInts = Task_6.ParseNumbers(numbers);
            Assert.AreNotEqual(expected.Count(), numbersAsInts.Count());
        }

        [TestMethod]
        public void AnyNegative_IsSuccess()
        {
            var numbers = new int[] { 1, 2, -3, 5, 6 };
            var hasNegativeNumber = Task_6.AnyNegative(numbers);
            Assert.IsTrue(hasNegativeNumber);
            var numbers2 = new int[] { 1, 2, 3, 5, 6 };
            var hasNoNegativeNumber = Task_6.AnyNegative(numbers2);
            Assert.IsFalse(hasNoNegativeNumber);
        }

        [TestMethod]
        public void GetProduct_IsSuccess()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var expected = 120;
            var product = Task_6.GetProduct(numbers);

            // assert
            Assert.AreEqual(expected, product);
        }

        [TestMethod]
        public void GetSun_IsSuccess()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var expected = 15;
            var product = Task_6.GetSum(numbers);
            Assert.AreEqual(expected, product);
        }
    }
}