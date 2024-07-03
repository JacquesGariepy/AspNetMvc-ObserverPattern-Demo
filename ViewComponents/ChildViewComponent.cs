using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ChildViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
