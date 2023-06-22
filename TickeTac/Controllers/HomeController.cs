﻿using System.Diagnostics;
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

    [HttpGet]
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
    
    [HttpGet]
    public IActionResult Eventos()
    {
        EventsViewModel evm = new()
        {
            Categories = _context.Categories.ToList(),
            Events = _context.Events.ToList(),
            Cities = _context.Cities.ToList(),
            StatusEvents = _context.StatusEvents.ToList(),
            Users = _context.AppUsers.ToList()
        };
        return View(evm);
    }

    

    [HttpPost]
    public IActionResult Eventos(EventsViewModel evm)
    {
        evm.Events = _context.Events.ToList();
        evm.Categories = _context.Categories.ToList();
        evm.Cities = _context.Cities.ToList();
        evm.Users = _context.AppUsers.ToList();
        evm.StatusEvents = _context.StatusEvents.ToList();
        
        IQueryable<Event> events = null;
        if (!string.IsNullOrEmpty(evm.SearchWords))
        {
            events = _context.Events.Where(e => e.Name.Contains(evm.SearchWords) || e.Description.Contains(evm.SearchWords));
        }
        else
        {
            events = _context.Events;
        }

        if (!string.IsNullOrEmpty(evm.SearchCategory))
        {
            int Id = int.Parse(evm.SearchCategory);
            events = events.Where(e => e.CategoryId == Id);
        }
        
        evm.SearchCategory = null;
        evm.Events = events.ToList();
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



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
