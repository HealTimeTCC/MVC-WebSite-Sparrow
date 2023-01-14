using Microsoft.AspNetCore.Mvc;

namespace Sparrow_MVC.Controllers;

public class ProdutosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
