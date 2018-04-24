using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketScience.Models;
using System.Linq;
namespace RocketScience.Tests
{
    [TestClass]
    public class RocketTests
    {
        [TestMethod]
        public void SetDestinationMethod_Values()
        {
            //Arrange
            Rocket newRocket = new Rocket();
            newRocket.SetDestination("LosAngles", 1400);

            //Act
            var destinationName = newRocket.DestinationName;
            var finalSpeed = newRocket.FinalSpeed;

            //Assert
            Assert.AreEqual("LosAngles", destinationName);
            Assert.AreEqual(1400, finalSpeed);

        }

        [TestMethod]
        public void GetFuel_Int()
        {
            //Arrange
            Rocket newRocket = new Rocket();
            newRocket.SetDestination("LosAngles", 1400);
            newRocket.Tonnage = 1;


            //Act
            var result = newRocket.GetFuel();
            

            //Assert
            Assert.AreEqual(595, result);

        }


    }
}
