using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class RandomNumberController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
