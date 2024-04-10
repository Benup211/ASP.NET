using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab5.Models;

namespace lab5.Controllers;

public class Controller1 : Controller
{
    private readonly ILogger<Controller1> _logger;

    public Controller1(ILogger<Controller1> logger)
    {
        _logger = logger;
    }

    public string Index()
    {
        return "This is index page";
    }

    public IActionResult Details()
    {
        @ViewData["value"]="This is detail value";
        return View();
    }
    public IActionResult Show(string bag="c#book")
    {
        @ViewData["bag"]=(string)bag;
        @ViewBag.message="This is a message";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
