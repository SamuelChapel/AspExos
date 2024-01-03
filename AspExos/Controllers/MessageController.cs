using AspExos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;
public class MessageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SendForm(string emetteur, string contenu, DateOnly date)
    {
        return View();
    }

    [HttpPost]
    public IActionResult SendMessageForm(Message message)
    {
        return View();
    }
}
