using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class MessageViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string message)
    {
        return View("Default", message);
    }
}
