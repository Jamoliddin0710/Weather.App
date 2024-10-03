using Microsoft.AspNetCore.Mvc;
using Weather.App.Models;

namespace Weather.App.Views.ViewComponents;

public class WeatherViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(City city)
    {
        return View(viewName: "Sample", city);
    }
}