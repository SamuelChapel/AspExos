using AspExos.Models;
using AspExos.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Controllers;

public class MessageDbController : Controller
{
    private readonly MessageRepository _messageRepository;

    public MessageDbController(MessageRepository messageRepository) => _messageRepository = messageRepository;

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var messages = await _messageRepository.GetAll();

        return View(messages);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> GetMessagesTable()
    {
        var messages = await _messageRepository.GetAll();

        return ViewComponent("MessagesTable", messages);
    }

    [HttpGet]
    public IActionResult GetMessage(int id)
    {
        return ViewComponent("MessageDetails", id);
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
