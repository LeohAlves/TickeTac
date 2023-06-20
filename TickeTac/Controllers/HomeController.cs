using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TickeTac.Models;
using TickeTac.Data;
using TickeTac.ViewModels;
using Microsoft.EntityFrameworkCore;

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
        HomeViewModel hvm = new()
        {
            Categories = _context.Categories.ToList(),
            Events = _context.Events.ToList(),
            Cities = _context.Cities.ToList(),
            Users = _context.AppUsers.ToList(),
            StatusEvents = _context.StatusEvents.ToList()
        };
        return View(hvm);
    }


    [HttpPost]
    public IActionResult Index(HomeViewModel hvm)
    {
        hvm.Categories = _context.Categories.ToList();
        hvm.Cities = _context.Cities.ToList();
        hvm.Users = _context.AppUsers.ToList();
        hvm.StatusEvents = _context.StatusEvents.ToList();
        
        IQueryable<Event> events = null;
        if (!string.IsNullOrEmpty(hvm.SearchWords))
        {
            events = _context.Events.Where(e => e.Name.Contains(hvm.SearchWords) || e.Description.Contains(hvm.SearchWords));
        }
        else
        {
            events = _context.Events;
        }

        if (!string.IsNullOrEmpty(hvm.SearchCity))
        {
            int Id = int.Parse(hvm.SearchCity);
            events = events.Where(e => e.CityId == Id);
        }

        if (!string.IsNullOrEmpty(hvm.SearchCategory))
        {
            int Id = int.Parse(hvm.SearchCategory);
            events = events.Where(e => e.CategoryId == Id);
        }
        
        hvm.Events = events.ToList();
        return View(hvm);
    }

    public IActionResult FiltrarPorCategoria(UInt16 category, int city)
    {   
        var filters = 
        _context.Categories.Where(c => c.Id == category).ToList();
        _context.Cities.Where(c => c.Id == city).ToList();

        if (filters != null)
            return View("Index", filters);
        
        return View("Index");
    }
        
    public IActionResult Eventos()
    {
        EventsViewModel evm = new()
        {
            Categories = _context.Categories.ToList(),
            Events = _context.Events.ToList(),
            Cities = _context.Cities.ToList(),
            StatusEvents = _context.StatusEvents.ToList(),
            AppUsers = _context.AppUsers.ToList()
        };
        return View(evm);
    }

    public IActionResult Details(UInt16 Id)
    {
        var @event = _context.Events.Where(e => e.Id == Id)
        .Include(e => e.Category)
        .Include(e => e.StatusEvent)
        .Include(e => e.City)
        .ThenInclude(e => e.State)
        .Include(e => e.User).FirstOrDefault();

        if (@event == null)
            return NotFound();

        return View(@event);
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
