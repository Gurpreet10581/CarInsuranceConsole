using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarInUnitTest
{
    [TestClass]
    public class CarInContentTest
    {
        public string LastName { get; private set; }

        [TestMethod]
        public void SetLastName_ShouldSetCorrectString()
        {
            CarInContentTest content = new CarInContentTest();
            content.LastName = "Singh";
            string expected = "Singh";
            string actual= content.LastName;

            Assert.AreEqual(expected, actual);

        }
    }
}
