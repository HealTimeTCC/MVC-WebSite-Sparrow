using Microsoft.AspNetCore.Mvc;
using Sparrow_MVC.Models;
using System.Diagnostics;

namespace Sparrow_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public async Task<IActionResult> IndexAsync()
    {
        return View();
    }
    
}