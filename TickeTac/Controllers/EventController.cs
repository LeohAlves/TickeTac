using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TickeTac.Data;
using TickeTac.Models;
using TickeTac.ViewModels;

namespace TickeTac.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Event
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Events.Include(e => e.Category).Include(e => e.City).Include(e => e.State).Include(e => e.StatusEvent).Include(e => e.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Event/Details/5
        public async Task<IActionResult> Details(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .Include(e => e.Category)
                .Include(e => e.City)
                .Include(e => e.State)
                .Include(e => e.StatusEvent)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Event/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Name");
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name");
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ContactPhone,Price,EventDateBegin,EventDateEnd,Description,Image,ContactEmail,MoreInfo,CityId,District,PublicSpace,Cep,CategoryId,StatusEventId,StateId,UserId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", @event.CategoryId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name", @event.CityId);
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Name", @event.StateId);
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name", @event.StatusEventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name", @event.UserId);
            return View(@event);
        }

        // GET: Event/Edit/5
        public async Task<IActionResult> Edit(ushort? id)
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

        // POST: Event/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ushort id, [Bind("Id,Name,ContactPhone,Price,EventDateBegin,EventDateEnd,Description,Image,ContactEmail,MoreInfo,CityId,District,PublicSpace,Cep,CategoryId,StatusEventId,StateId,UserId")] Event @event)
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", @event.CategoryId);
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name", @event.CityId);
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Name", @event.StateId);
            ViewData["StatusEventId"] = new SelectList(_context.StatusEvents, "Id", "Name", @event.StatusEventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Name", @event.UserId);
            return View(@event);
        }

        // GET: Event/Delete/5
        public async Task<IActionResult> Delete(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .Include(e => e.Category)
                .Include(e => e.City)
                .Include(e => e.State)
                .Include(e => e.StatusEvent)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ushort id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(ushort id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
