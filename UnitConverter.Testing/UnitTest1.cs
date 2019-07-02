using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitConverter.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1CelciusConvertsTo33Point8Farentheit()
        {
            // Arrange
            var converter = new TemperatureConverter();
            var inputvalue = 1;

            // Act
            var result = converter.Convert(inputvalue, Temperature.Celcius, Temperature.Fahrenheit);

            // Assert
            Assert.AreEqual(33.8, result, 0.1);

        }

        [TestMethod]
        public void Test100CelciusConvertsTo373Kelvin()
        {
            // Arrange
            var converter = new TemperatureConverter();
            var inputvalue = 100;

            // Act
            var result = converter.Convert(inputvalue, Temperature.Celcius, Temperature.Kelvin);

            // Assert
            Assert.AreEqual(373.15, result, 0.1);

        }

        [TestMethod]
        public void Test100FarenheitConvertsTo310Kelvin()
        {
            // Arrange
            var converter = new TemperatureConverter();
            var inputvalue = 100;

            // Act
            var result = converter.Convert(inputvalue, Temperature.Fahrenheit, Temperature.Kelvin);

            // Assert
            Assert.AreEqual(310.928, result, 0.1);

        }

        [TestMethod]
        public void Test100FarenheitConvertsTo37Celcius()
        {
            // Arrange
            var converter = new TemperatureConverter();
            var inputvalue = 100;

            // Act
            var result = converter.Convert(inputvalue, Temperature.Fahrenheit, Temperature.Celcius);
            
            // Assert
            Assert.AreEqual(37.7778, result, 0.1);

        }

        [TestMethod]
        public void Test800KelvinConvertsTo526Celcius()
        {
            // Arrange
            var converter = new TemperatureConverter();
            var inputvalue = 800;

            // Act
            var result = converter.Convert(inputvalue, Temperature.Kelvin, Temperature.Celcius);

            // Assert
            Assert.AreEqual(526.85, result, 0.1);

        }

        [TestMethod]
        public void Test800KelvinConvertsTo980Farenheit()
        {
            // Arrange
            var converter = new TemperatureConverter();
            var inputvalue = 800;

            // Act
            var result = converter.Convert(inputvalue, Temperature.Kelvin, Temperature.Fahrenheit);

            // Assert
            Assert.AreEqual(980.33, result, 0.1);

        }






        [TestMethod]
        public void Test1000MililiterConvertsTo1Liter()
        {
            // Arrange
            var converter = new VolumeConverter();
            var inputvalue = 1000;

            // Act
            var result = converter.Convert(inputvalue, Volume.Millilitre, Volume.Liter);

            // Assert
            Assert.AreEqual(1, result);

        }


        [TestMethod]
        public void Test10000MililiterConvertsTo2point6Gallon()
        {
            // Arrange
            var converter = new VolumeConverter();
            var inputvalue = 10000;

            // Act
            var result = converter.Convert(inputvalue, Volume.Millilitre, Volume.Gallon);

            // Assert
            Assert.AreEqual(2.641721, result, 0.1);

        }

        [TestMethod]
        public void Test1GallonConvertsTo3Point7Litres()
        {
            // Arrange
            var converter = new VolumeConverter();
            var inputvalue = 1;

            // Act
            var result = converter.Convert(inputvalue, Volume.Gallon, Volume.Liter);

            // Assert
            Assert.AreEqual(3.78541, result, 0.1);

        }


        [TestMethod]
        public void Test20GallonConvertsToMillilitres()
        {
           
            // Arrange
            var converter = new VolumeConverter();
            var inputvalue = 20;

            // Act
            var result = converter.Convert(inputvalue, Volume.Gallon, Volume.Millilitre);

            // Assert
            Assert.AreEqual(75708.2, result, 0.1);

        }



        [TestMethod]
        public void Test5LitreConvertsTo1point3Gallon()
        {

            // Arrange
            var converter = new VolumeConverter();
            var inputvalue = 5;

            // Act
            var result = converter.Convert(inputvalue, Volume.Liter, Volume.Gallon);

            // Assert
            Assert.AreEqual(1.32086, result, 0.1);

        }


        [TestMethod]
        public void Test5LitreConvertsTo5000Millilitre()
        {

            // Arrange
            var converter = new VolumeConverter();
            var inputvalue = 5;

            // Act
            var result = converter.Convert(inputvalue, Volume.Liter, Volume.Millilitre);

            // Assert
            Assert.AreEqual(5000, result);

        }


    }
}
