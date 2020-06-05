using CarIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInUnitTest
{
    public class CarInRepoTest
    {
        public string LastName { get; internal set; }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void AddToDirectory_ShouldGetCorrectBool()
        {
            CarInContent content = new CarInContent();
            CarInRepository repo = new CarInRepository();

            bool addResult = repo.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectList()
        {
            CarInContent testContent = new CarInContent();
            CarInRepository repo = new CarInRepository();
            repo.AddContentToDirectory(testContent);

            List<CarInContent> testList = repo.GetContents();
            bool directoryHasContent = testList.Contains(testContent);

            Assert.IsTrue(directoryHasContent);
        }
        private CarInRepository _repo;
        private CarInContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new CarInRepository();
            _content = new CarInContent();
            _repo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void GetByLastName_ShouldReturnCorrectLastName() 
        {
            CarInContent searchResult = _repo.GetContentByLastName("Singh");
            Assert.AreEqual(_content, searchResult);
        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
