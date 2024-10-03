using Microsoft.AspNetCore.Mvc;
using Weather.App.Models;

namespace Weather.App.Controllers;

public class WeatherController : Controller
{
    private List<City> _cities;

    public WeatherController()
    {
        _cities = new List<City>()
        {
            new City()
            {
                CityName = "Tashkent",
                UniqueCode = "knbdksndknskld",
                DateAndTime = DateTime.Today,
                TemperatureFahrenheit = 34,
            },
            new City()
            {
                CityName = "Samarkand",
                UniqueCode = "@samarkand",
                DateAndTime = DateTime.Today,
                TemperatureFahrenheit = 49,
            },
            new City()
            {
                CityName = "Urgench",
                UniqueCode = "@ranch",
                DateAndTime = DateTime.Today,
                TemperatureFahrenheit = 80,
            }
        };
    }

    [Route("/")]
    public IActionResult Index()
    {
        return View(_cities);
    }

    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("weather/{uniquecode}")]
    public IActionResult GetCity(string uniquecode)
    {
        var city = _cities.FirstOrDefault(t => t.UniqueCode == uniquecode);
        return View("Components/City/City", city);
    }
}