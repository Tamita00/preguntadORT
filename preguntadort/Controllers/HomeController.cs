using Microsoft.AspNetCore.Mvc;

namespace preguntadORT.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
