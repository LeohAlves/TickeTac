using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TickeTac.Data;
using TickeTac.Models;

namespace TickeTac.Controllers
{
    public class EventOwnerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventOwnerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EventOwner
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EventOwners.Include(e => e.Event).Include(e => e.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EventOwner/Details/5
        public async Task<IActionResult> Details(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventOwner = await _context.EventOwners
                .Include(e => e.Event)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventOwner == null)
            {
                return NotFound();
            }

            return View(eventOwner);
        }

        // GET: EventOwner/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep");
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id");
            return View();
        }

        // POST: EventOwner/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CpfCnpj,EventId,UserId")] EventOwner eventOwner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventOwner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep", eventOwner.EventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", eventOwner.UserId);
            return View(eventOwner);
        }

        // GET: EventOwner/Edit/5
        public async Task<IActionResult> Edit(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventOwner = await _context.EventOwners.FindAsync(id);
            if (eventOwner == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep", eventOwner.EventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", eventOwner.UserId);
            return View(eventOwner);
        }

        // POST: EventOwner/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ushort id, [Bind("Id,Name,CpfCnpj,EventId,UserId")] EventOwner eventOwner)
        {
            if (id != eventOwner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventOwner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventOwnerExists(eventOwner.Id))
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
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep", eventOwner.EventId);
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", eventOwner.UserId);
            return View(eventOwner);
        }

        // GET: EventOwner/Delete/5
        public async Task<IActionResult> Delete(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventOwner = await _context.EventOwners
                .Include(e => e.Event)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventOwner == null)
            {
                return NotFound();
            }

            return View(eventOwner);
        }

        // POST: EventOwner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ushort id)
        {
            var eventOwner = await _context.EventOwners.FindAsync(id);
            _context.EventOwners.Remove(eventOwner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventOwnerExists(ushort id)
        {
            return _context.EventOwners.Any(e => e.Id == id);
        }
    }
}
