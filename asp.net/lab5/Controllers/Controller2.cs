using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab5.Models;

namespace lab5.Controllers;

public class Controller2 : Controller
{
    private readonly ILogger<Controller2> _logger;

    public Controller2(ILogger<Controller2> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Show(int num=1,string value="default")
    {
        @ViewData["num"]=(int)num;
        @ViewData["value"]=(string)value;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
