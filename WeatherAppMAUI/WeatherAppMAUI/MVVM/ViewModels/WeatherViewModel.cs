using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherAppMAUI.MVVM.Models;

namespace WeatherAppMAUI.MVVM.ViewModels
{
    public class WeatherViewModel
    {
        public WeatherData WeatherData { get; set; }
        private HttpClient client;

        public WeatherViewModel()
        {
            client = new HttpClient();
        }

        public ICommand SearchCommand =>
            new Command(async (searchText) =>
            {
                //Debug.WriteLine("**********");
                //Debug.WriteLine(searchText);
                var location = await GetCoordinatesAsync(searchText.ToString());
                await GetWeather(location);
                //await GetWeather();
            });

        private async Task<Location> GetCoordinatesAsync(string address)
        {
            Debug.WriteLine("**********");
            Debug.WriteLine("Before Geocoding");

            IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

            Debug.WriteLine("**********");
            Debug.WriteLine("After Geocoding");

            Location location = locations?.FirstOrDefault();

            if (location != null)
            {
                Console.WriteLine($"{location.Longitude}");
            }

            return location;
        }

        private async Task GetWeather(Location location)
        {
            var longitude = 30.266666m;
            var latitude = -97.733330m;
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,weathercode,windspeed_10m&daily=weathercode,temperature_2m_max,temperature_2m_min&temperature_unit=fahrenheit&windspeed_unit=mph&precipitation_unit=inch&timezone=America%2FChicago";
            var testUrl = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m,weathercode,windspeed_10m&daily=weathercode,temperature_2m_max,temperature_2m_min&temperature_unit=fahrenheit&windspeed_unit=mph&precipitation_unit=inch&timezone=America%2FChicago";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
                    WeatherData = data;
                }
            }
        }

        private async Task GetWeather()
        {
            Debug.WriteLine("**********");

            var latitude = 30.266666m;
            var longitude = -97.733330m;
            //var url = $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,weathercode,windspeed_10m&daily=weathercode,temperature_2m_max,temperature_2m_min&temperature_unit=fahrenheit&windspeed_unit=mph&precipitation_unit=inch&timezone=America%2FChicago";
            var testUrl = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m,weathercode,windspeed_10m&daily=weathercode,temperature_2m_max,temperature_2m_min&temperature_unit=fahrenheit&windspeed_unit=mph&precipitation_unit=inch&timezone=America%2FChicago";

            Debug.WriteLine("**********");

            var response = await client.GetAsync(testUrl);

            Debug.WriteLine("**********");

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
                    WeatherData = data;
                }
            }
        }
    }
}
