using App.API.Controllers;

namespace App.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController();
        [Fact]
        public void WeatherForecastControllerGet()
        {
            var result = weatherForecastController.Get();
            Assert.Equal(5 , result.Count());
        }
    }
}