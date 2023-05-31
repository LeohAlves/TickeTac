using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

using TickeTac.Data;
using TickeTac.Models;

namespace TickeTac.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class StatusEventController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StatusEventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StatusEvent
        public async Task<IActionResult> Index()
        {
            return View(await _context.StatusEvents.ToListAsync());
        }

        // GET: StatusEvent/Details/5
        public async Task<IActionResult> Details(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusEvent = await _context.StatusEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusEvent == null)
            {
                return NotFound();
            }

            return View(statusEvent);
        }

        // GET: StatusEvent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusEvent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] StatusEvent statusEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusEvent);
        }

        // GET: StatusEvent/Edit/5
        public async Task<IActionResult> Edit(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusEvent = await _context.StatusEvents.FindAsync(id);
            if (statusEvent == null)
            {
                return NotFound();
            }
            return View(statusEvent);
        }

        // POST: StatusEvent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ushort id, [Bind("Id,Name")] StatusEvent statusEvent)
        {
            if (id != statusEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusEventExists(statusEvent.Id))
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
            return View(statusEvent);
        }

        // GET: StatusEvent/Delete/5
        public async Task<IActionResult> Delete(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusEvent = await _context.StatusEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusEvent == null)
            {
                return NotFound();
            }

            return View(statusEvent);
        }

        // POST: StatusEvent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ushort id)
        {
            var statusEvent = await _context.StatusEvents.FindAsync(id);
            _context.StatusEvents.Remove(statusEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusEventExists(ushort id)
        {
            return _context.StatusEvents.Any(e => e.Id == id);
        }
    }
}
