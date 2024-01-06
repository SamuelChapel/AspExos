using AspExos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Views.MessageDb.Components.EditMessage;

public class EditMessageViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(Message message)
    {
        return View(message);
    }
}
