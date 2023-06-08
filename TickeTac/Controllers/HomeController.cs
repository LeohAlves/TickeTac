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

    public IActionResult Index()
    {
        HomeViewModel hvm = new()
        {
            Categories = _context.Categories.ToList(),
            Events = _context.Events.ToList(),
            Cities = _context.Cities.ToList(),
            Owners = _context.EventOwners.ToList()
        };
        return View(hvm);
    }

    public IActionResult Eventos()
    {
        EventsViewModel evm = new()
        {
            Categories = _context.Categories.ToList(),
            Events = _context.Events.ToList(),
            Cities = _context.Cities.ToList(),
            Owners = _context.EventOwners.ToList()
        };
        return View(evm);
    }

    public IActionResult Details(UInt16 Id)
    {
        var @event = _context.Events.Where(e => e.Id == Id)
        .Include(e => e.Category)
        .Include(e => e.StatusEvent)
        .Include(e => e.City)
        .Include(e => e.EventOwner)
        .ThenInclude(e => e.User).FirstOrDefault();

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
