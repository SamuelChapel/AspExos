using AspExos.Models;
using AspExos.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class MessageDbController(MessageRepository messageRepository) : Controller
{
    private readonly MessageRepository _messageRepository = messageRepository;

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var messages = await _messageRepository.GetAll();

        return View(messages);
    }

    [HttpGet]
    public IActionResult CreateMessage()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateMessage(Message message)
    {
        int createdMessageId = await _messageRepository.Create(message);

        return RedirectToAction("GetMessage", new { id = createdMessageId });
    }

    [HttpPost]
    public async Task<IActionResult> GetMessagesTable(string search)
    {
        List<Message> messages;
        if (search is null)
        {
            messages = await _messageRepository.GetAll();
        }
        else
        {
            messages = await _messageRepository.FindMessages(search);
        }

        return ViewComponent("MessagesTable", messages);
    }

    [HttpGet]
    public async Task<IActionResult> GetMessage(int id)
    {
        var message = await _messageRepository.GetById(id);

        if (message is null)
            return View("Error404");

        return View(message);
    }

    [HttpGet]
    public async Task<IActionResult> EditMessage(int id)
    {
        var message = await _messageRepository.GetById(id);

        if (message is null)
            return View("Error404");

        return View("EditMessage", message);
    }

    [HttpPost]
    public async Task<IActionResult> EditMessage(Message message)
    {
        await _messageRepository.Update(message);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> DeleteMessage(int id)
    {
        var message = await _messageRepository.GetById(id);

        if (message is not null)
        {
            await _messageRepository.Delete(message);
        }

        return RedirectToAction("Index");
    }
}
