using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult TestData()
    {
        ViewBag.TestKey = "Test Viewbag";
        TempData["TestKey"] = "Test TempData";

        return View();
    }

    public IActionResult TestData2()
    {
        return View();
    }

    public IActionResult TestData3()
    {
        ViewBag.TestKey = "Test Viewbag from TestData3";
        TempData["TestKey"] = "Test TempData from TestData3";
        return RedirectToAction(nameof(TestData2));
    }

    public IActionResult TestData4()
    {
        ViewBag.TestKey = "Test Viewbag from TestData4";
        TempData["TestKey"] = "Test TempData from TestData4";
        return View("TestData");
    }
}
