using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using TickeTac.Models;
using TickeTac.Data;
using TickeTac.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace TickeTac.Controllers
{

    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationDbContext _context;

        public UserController(ILogger<UserController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult MeusEventos(string ownerId)
        {
            IQueryable<Event> events = null;
            events = _context.Events;

            if (!string.IsNullOrEmpty(ownerId))
            {
                events = events.Where(e => e.UserId == ownerId);
            }

            EventOwnerViewModel eovm = new()
            {
                Events = events
                .Include(e => e.Category)
                .Include(e => e.StatusEvent).ToList()

                .ToList(),
                Owner = _context.Users.Where(u => u.Id == ownerId).FirstOrDefault()
            };

            return View(eovm);
        }
        // Edit GET
        public async Task<IActionResult> Editar(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", @event.CategoryId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name", @event.CityId);
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Name", @event.StateId);
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name", @event.StatusEventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name", @event.UserId);
            return View(@event);
        }
        // Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(ushort id, [Bind("Id,Name,ContactPhone,Price,EventDateBegin,EventDateEnd,Description,Image,ContactEmail,MoreInfo,CityId,District,PublicSpace,Cep,CategoryId,StatusEventId,StateId,UserId")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Home", new {id = @event.Id});
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", @event.CategoryId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", @event.CityId);
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Id", @event.StateId);
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name", @event.StatusEventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name", @event.UserId);
            return View(@event);
        }

        // Publicar Get
        public IActionResult Publicar()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Name");
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name");
            return View();
        }

        //  Publicar Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Publicar([Bind("Id,Name,ContactPhone,Price,EventDateBegin,EventDateEnd,Description,Image,ContactEmail,MoreInfo,CityId,District,PublicSpace,Cep,CategoryId,StatusEventId,StateId,UserId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home", null);
            }

            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", @event.CategoryId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id", @event.CityId);
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Id", @event.StateId);
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name", @event.StatusEventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name", @event.UserId);
            return View(@event);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
         private bool EventExists(ushort id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}