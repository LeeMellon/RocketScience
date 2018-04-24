using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketScience.Models;
using System;
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

        [TestMethod]
        public void GetCrew_Double()
        {
            //Arrange
            Rocket newRocket = new Rocket();
            var days = 2;
            var tasks = 300;

            //Act
            var result = newRocket.GetCrew(days, tasks);


            //Assert
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void GetDistance_Double()
        {
            //Arrange
            Rocket newRocket = new Rocket();
            var StartLat = 28.533333;
            var StartLong = -80.566667;
            var EndLat = 45.483333;
            var EndLong = -120.483333;

            //Act
            var result = (newRocket.GetDistance(StartLat, StartLong, EndLat, EndLong));


            //Assert
            Assert.AreEqual(2140, result);

        }

    }
}
