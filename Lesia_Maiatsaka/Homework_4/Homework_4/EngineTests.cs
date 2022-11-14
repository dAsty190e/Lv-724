using HM_4_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    [TestClass]
    internal class EngineTests
    {
        [TestMethod]
        public void Engine_PopulatePersons()
        {
            // assemble
            // act
            var people = Engine.PopulatePersons(20);
            // assert
            Assert.AreEqual(20, people.Count);
        }

        [TestMethod]
        public void Person_CreateUniqueNameCountDictionary()
        {
            // TODO : need  refactoring
        }
    }
}
