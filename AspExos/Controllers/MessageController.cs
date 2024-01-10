using AspExos.Models;
using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class MessageController(ILogger<MessageController> logger) : Controller
{
    private static int _currentId = 1;
    private static int NextId => _currentId++;

    private static readonly List<Message> _messages = Enumerable.Range(0, 20)
        .Select(i => GetRandomMessage())
        .ToList();

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
    public IActionResult Create(string emetteur, string contenu, DateOnly date)
    {
        var message = new Message(NextId, emetteur, contenu, date);
        _messages.Add(message);
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
        message.Id = NextId;
        _messages.Add(message);

        _logger.LogInformation("Message ajouté : {message}", message);
        TempData["message"] = "Message bien ajouté";

        return RedirectToAction(nameof(CreateMessage));
    }

    [HttpGet]
    public IActionResult GetAllMessages()
    {
        return View(_messages);
    }

    [HttpGet]
    public IActionResult GetMessage(int id)
    {
        return View(_messages.FirstOrDefault(m => m.Id == id));
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

    public static Message GetRandomMessage()
    {
        return new Faker<Message>()
            .RuleFor(m => m.Id, NextId)
            .RuleFor(m => m.Emetteur, f => f.Person.FullName)
            .RuleFor(m => m.Contenu, f => f.Lorem.Paragraph(1))
            .RuleFor(m => m.Date, f => f.Date.PastDateOnly())
            .Generate();
    }

    public ActionResult VerifierEmetteur(string emetteur)
    {
        bool res = false; //traitement de contrôle
        return Json(res);
    }
}
