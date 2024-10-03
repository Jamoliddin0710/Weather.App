using Microsoft.AspNetCore.Mvc;

namespace Weather.App.Views.ViewComponents;

public class CityViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View("City");
    }
}