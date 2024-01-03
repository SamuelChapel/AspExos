using AspExos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class MessageController(ILogger<MessageController> logger) : Controller
{
    private static readonly List<Message> messages = [];

    private readonly ILogger<MessageController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(string emetteur, string contenu, DateOnly date)
    {
        var message = new Message(emetteur, contenu, date);
        messages.Add(new Message(emetteur, contenu, date));
        _logger.LogInformation($"Message ajouté : {message}");

        return RedirectToAction("Form");
    }

    [HttpGet]
    public IActionResult FormMessage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MessageForm(Message message)
    {
        messages.Add(message);

        _logger.LogInformation($"Message ajouté : {message}");

        return RedirectToAction("MessageForm");
    }

    [HttpGet]
    public IActionResult GetAllMessages()
    {
        return View(messages);
    }

    [HttpPost]
    public IActionResult ListStringForm(List<string> stringList)
    {
        return View();
    }
}
