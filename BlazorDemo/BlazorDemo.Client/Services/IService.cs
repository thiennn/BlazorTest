using BlazorDemo.Shared;
using System.Threading.Tasks;

namespace BlazorDemo.Client.Services
{
    public interface IService
    {
        Task<WeatherForecast[]> GetWeatherForecasts();
    }
}
