using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class RandomNumberController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetRandomComponent()
    {
        return ViewComponent("RandomNumber", new { min = 1, max = 100 });
    }
}
