using System.Diagnostics;
using System.IO.Compression;
using Microsoft.AspNetCore.Mvc;
using SurveyParty.Models;

namespace SurveyParty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("survey/create")]
    public IActionResult CreateSurvey(Survey p)
    {
        // if (ModelState.IsValid)
        // {   
            
        //     return RedirectToAction("Show");
        // }
        ViewBag.SurveyResults=p;
        return View("Show");
    }

    [HttpGet("surveys")]
    public ViewResult Show()
    {
        return View("Show");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}