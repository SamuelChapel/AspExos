using AspExos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Views.MessageDb.Components.MessagesTable;

public class MessagesTableViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(List<Message> messages)
    {
        return View(messages);
    }
}
