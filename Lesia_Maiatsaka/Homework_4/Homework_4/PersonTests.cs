using HM_4_Person;

namespace Homework_4
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Person_Default_Constructor()
        {
            // assemble
            // act
            var person = new Person();
            // assert
            Assert.IsNull(person.Name);
            Assert.IsNull(person.BirthDay);
        }

        [TestMethod]
        public void Person_Constructor()
        {
            // assemble
            // act
            var person = new Person("Piper", DateOnly.FromDateTime(DateTime.Now));
            // assert
            Assert.IsNotNull(person.Name);
            Assert.IsNotNull(person.BirthDay);
        }

        [TestMethod]
        public void Person_Age_NotNull()
        {
            // assemble
            // act
            var person = new Person("Piper", DateOnly.FromDateTime(DateTime.Now.AddYears(-20)));
            // assert
            Assert.AreEqual("Piper", person.Name);
            Assert.AreEqual(20, person.Age());
        }

        [TestMethod]
        public void Person_ChangeName()
        {
            // assemble
            var person = new Person("Piper", DateOnly.FromDateTime(DateTime.Now.AddYears(-20)));
            // act
            person.ChangeName("Lama");
            // assert
            Assert.AreEqual("Lama", person.Name);
        }

        [TestMethod]
        public void Person_ToString()
        {
            // assemble
            var person = new Person("Piper", DateOnly.FromDateTime(DateTime.Now.AddYears(-20)));
            // act
            var str = person.ToString();
            // assert
            Assert.AreEqual($"Piper is 20 years old", str);
        }

        [TestMethod]
        public void Person_Age_OneYear_ToString()
        {
            // assemble
            // act
            var person = new Person("Piper", DateOnly.FromDateTime(DateTime.Now.AddYears(-1)));
            var str = person.ToString();
            // assert
            Assert.AreEqual(1, person.Age());
            Assert.AreEqual($"Piper is 1 year old", str);
        }
    }
}