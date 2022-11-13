using Task_4;

namespace Task_4_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChangePrice()
        {
            // assembler
            var car1 = new Car("Forester", "Blue", 120_000);
            var car2 = new Car("Impreza", "White", 90_000);
            var car3 = new Car("Legacy", "Red", 110_000);
            // act
            var car1Price = car1.ChangePrice(1.1);
            var car2Price = car2.ChangePrice(1.25);
            var car3Price = car3.ChangePrice(0.9);
            // assert
            Assert.AreEqual(132_000, car1Price);
            Assert.AreEqual(112_500, car2Price);
            Assert.AreEqual(99_000, car3Price);
        }

        [TestMethod]
        public void ChangeColor()
        {
            // assembler
            var car2 = new Car("Impreza", "White", 90_000);
            // act
            car2.Color = "Blue";
            // assert
            Assert.AreEqual("Blue", car2.Color);
            Assert.AreNotEqual("White", car2?.Color);
        }

        [TestMethod]
        public void EequalityOperator()
        {
            // assembler
            var car1 = new Car("Legacy", "Red", 110_000);
            var car2 = new Car("Legacy", "Red", 110_000);
            // act
            // assert
            Assert.IsTrue(car1 == car2);
            car2.ChangePrice(0.0000001);
            Assert.IsFalse(car1 == car2);
        }

    }

}