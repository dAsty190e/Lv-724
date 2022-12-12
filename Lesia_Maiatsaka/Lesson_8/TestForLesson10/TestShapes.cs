using Homework_8;

namespace TestForLesson10
{
    [TestClass]
    public class TestShapes
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var newCircle = new Circle("BigOne", 123);
            var circle1 = newCircle.Area();
            Assert.AreEqual(47529.155256159982, circle1);
        }

        [TestMethod]
        public void CirclPerimeterTest()
        {
            var someCircle = new Circle("PerimSquare", 2);
            var circle2 = someCircle.Perimeter();
            Assert.AreEqual((decimal)12.5663706143592, circle2);
        }

        [TestMethod]
        public void SquareAreaTest()
        {
            var newSquare1 = new Square("OneBig", 222);
            var square1 = newSquare1.Area();
            Assert.AreEqual(49284, square1);
        }
        [TestMethod]
        public void SquarePerimeterTest()
        {
            var newSquare = new Square("NotBigSquare", 22);
            var square1 = newSquare.Perimeter();
            Assert.AreEqual(88, square1);
        }
    }
}