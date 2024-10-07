using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using content_hub_one_web_app.Models;
using content_hub_one_web_app.Services;

namespace content_hub_one_web_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly HomepageService _homepageService;

    public HomeController(ILogger<HomeController> logger, HomepageService homepageService)
    {
        _logger = logger;
        _homepageService = homepageService;
    }

    public IActionResult Index()
    {
        _homepageService.
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
