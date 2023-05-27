using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TickeTac.Models;
using TickeTac.Data;
using TickeTac.ViewModels;
namespace TickeTac.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeViewModel hvm = new(){
            Categories = _context.Categories.ToList(),
            Events = _context.Events.ToList(),
        };
        return View(hvm);
    }

    public IActionResult Eventos()
    {
        ViewData["Category"] = _context.Categories.ToList();
        return View();
    }
    public IActionResult UserPage()
    {
        return View();
    }

    public IActionResult MeusEventos()
    {
        return View();
    }
    public IActionResult Publicar()
    {
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
