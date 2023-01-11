using Microsoft.AspNetCore.Mvc;

namespace Sparrow_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
