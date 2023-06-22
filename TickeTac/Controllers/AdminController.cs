using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TickeTac.Models;
using TickeTac.Data;
using TickeTac.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace TickeTac.Controllers
{  
    [Authorize(Roles = "Administrador")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext context)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}