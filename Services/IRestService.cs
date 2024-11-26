using OpenWeatherAPI.Models;

namespace OpenWeatherAPI.Services
{
    public interface IRestService
    {
        Task<WeatherData> GetWeatherData(string cityName);
    }
}
