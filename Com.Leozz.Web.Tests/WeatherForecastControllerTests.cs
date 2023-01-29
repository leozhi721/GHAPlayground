using Com.Leozz.Web.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Com.Leozz.Web.Tests
{
    public class WeatherForecastControllerTests
    {
        private readonly WeatherForecastController _sut;

        public WeatherForecastControllerTests() {
            _sut = new WeatherForecastController(new Mock<ILogger<WeatherForecastController>>().Object);        
        }

        [Fact]
        public void WeatherForecastController_GetWeatherForecast_Should_Success()
        {
            var list = _sut.Get();
            Assert.NotEmpty(list);
        }
    }
}