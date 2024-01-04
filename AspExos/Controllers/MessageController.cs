using AspExos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class MessageController(ILogger<MessageController> logger) : Controller
{
    private static int _nextId = 1;
    private static int nextId => _nextId++;

    private static readonly List<Message> messages = [];

    private readonly ILogger<MessageController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(string emetteur, string contenu, DateOnly date)
    {
        var message = new Message(nextId, emetteur, contenu, date);
        messages.Add(message);
        _logger.LogInformation("Message ajouté : {message}", message);
        TempData["message"] = "Message bien ajouté";

        return RedirectToAction(nameof(Create));
    }

    [HttpGet]
    public IActionResult CreateMessage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateMessage(Message message)
    {
        message.Id = nextId;
        messages.Add(message);

        _logger.LogInformation("Message ajouté : {message}", message);
        TempData["message"] = "Message bien ajouté";

        return RedirectToAction(nameof(CreateMessage));
    }

    [HttpGet]
    public IActionResult GetAllMessages()
    {
        return View(messages);
    }

    [HttpGet]
    public IActionResult GetMessage(int id)
    {
        return View(messages.FirstOrDefault(m => m.Id == id));
    }

    [HttpGet]
    public IActionResult ListStringForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ListStringForm(List<string> stringList)
    {
        _logger.LogInformation("Liste de chaîne de caractères : {listString}", string.Join('\n', stringList));
        return View();
    }
}
