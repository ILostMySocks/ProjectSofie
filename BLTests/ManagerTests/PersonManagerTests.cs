using BLMyHealthApp.Managers;
using Moq;
using MyHealthApp.Entities;
using MyHealthApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLTests.ManagerTests
{
    [TestClass]
    public class PersonManagerTests
    {
        private Mock<IPersonRepository> _personRepositoryMock;
        private PersonManager _personManager;


        [TestInitialize]
        public void TestInit()
        {
            _personRepositoryMock = new Mock<IPersonRepository>();
            _personManager = new PersonManager(_personRepositoryMock.Object);
        }
        //HelperMethods
        private List<Person> GenerateTestPersons()
        {
            //var personsB = new List<Person>();
            //var person = new Person();
            //person.LastName = "LN";
            //person.FirstName = "LN";
            //personsB.Add(person);

            var persons = new List<Person>()
            {
                 new Person() {Id = 1, LastName = "LN1", FirstName = "FN1", BirthDate = DateTime.Now},
                 new Person() {Id = 2, LastName = "LN2", FirstName = "FN2"},
                 new Person() {Id = 3, LastName = "LN3", FirstName = "FN3"},
            };

            return persons;
        }






        [TestMethod]
        public void GetAllCorrectResult()
        {
            //Arrange
            var expectedResult = GenerateTestPersons();

            _personRepositoryMock
                .Setup(r => r.GetAll())
                .Returns(GenerateTestPersons);

            //Act
            var result = _personManager.GetAll(); 

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult.Count, result.Count());
            Assert.AreEqual(expectedResult.First().Id, result.First().Id);
            Assert.AreEqual(expectedResult.First().LastName, result.First().LastName);

            //verifyen ofdat een bepaalde methode (hier GetAll) aangeroepen geweest is en hoeveel keer
            _personRepositoryMock.Verify(r => r.GetAll(), Times.Once);
        }

        [TestMethod]
        public void AddCorrectInputCallAdd()
        {
            //Arrange
            var person = GenerateTestPersons().First();
            person.Id = 0;

            _personRepositoryMock
                .Setup(r => r.Add(It.IsAny<Person>()))
                .Returns(2);
            _personRepositoryMock
                .Setup(r => r.Add(person))
                .Returns(3);


            //Act
            var result = _personManager.Add(person);

            //Assert
            Assert.IsTrue(result > 0);
            _personRepositoryMock.Verify(r => r.Add(It.IsAny<Person>()));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "BirthDate")]
        public void AddBadDateDontCallAdd()
        {
            //Arrange
            var person = GenerateTestPersons().First();
            person.Id = 0;
            person.BirthDate = DateTime.MinValue;

            _personRepositoryMock
                .Setup(r => r.Add(It.IsAny<Person>()))
                .Returns(2);

            //Act
            var result = _personManager.Add(person);

            //Assert
            Assert.IsTrue(result > 0);
        }

    }
}
