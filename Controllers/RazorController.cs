using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers;
public class Razor : Controller
{
    [HttpGet("")]
    public ViewResult RazorHome()
    {
        return View("RazorHome");
    }
}

