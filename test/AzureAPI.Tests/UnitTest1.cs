using System;
using Xunit;
using AzureAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace AzureAPI.Tests
{
    public class UnitTest1
    {
        private ILogger<WeatherForecastController> _logger;

        [Fact]
        public void Test1()
        {

        }

        // Arrange, Act, Assert

        [Fact]
        public void GetReturnsCorrectWeather()
        {
            // Arrange
            WeatherForecastController controller = new WeatherForecastController(_logger);

            // Act
            var returnValue = controller.Get(1);

            // Assert
            Assert.Equal("Cool", returnValue.Value);
        }
    }
}
