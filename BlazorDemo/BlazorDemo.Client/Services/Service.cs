using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Shared;
using Microsoft.AspNetCore.Blazor;

namespace BlazorDemo.Client.Services
{
    public class Service : IService
    {
        private readonly HttpClient _httpClient;

        public Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<WeatherForecast[]> GetWeatherForecasts()
        {
            return _httpClient.GetJsonAsync<WeatherForecast[]>("/api/SampleData/WeatherForecasts");
        }
    }
}
