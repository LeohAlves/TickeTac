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
    public class EventReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EventReview
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EventReviews.Include(e => e.Client).Include(e => e.Event);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EventReview/Details/5
        public async Task<IActionResult> Details(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventReview = await _context.EventReviews
                .Include(e => e.Client)
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (eventReview == null)
            {
                return NotFound();
            }

            return View(eventReview);
        }

        // GET: EventReview/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email");
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep");
            return View();
        }

        // POST: EventReview/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rating,ReviewText,ReviewDate,ClientId,EventId")] EventReview eventReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email", eventReview.ClientId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep", eventReview.EventId);
            return View(eventReview);
        }

        // GET: EventReview/Edit/5
        public async Task<IActionResult> Edit(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventReview = await _context.EventReviews.FindAsync(id);
            if (eventReview == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email", eventReview.ClientId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep", eventReview.EventId);
            return View(eventReview);
        }

        // POST: EventReview/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ushort id, [Bind("Id,Rating,ReviewText,ReviewDate,ClientId,EventId")] EventReview eventReview)
        {
            if (id != eventReview.EventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventReviewExists(eventReview.EventId))
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
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email", eventReview.ClientId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Cep", eventReview.EventId);
            return View(eventReview);
        }

        // GET: EventReview/Delete/5
        public async Task<IActionResult> Delete(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventReview = await _context.EventReviews
                .Include(e => e.Client)
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (eventReview == null)
            {
                return NotFound();
            }

            return View(eventReview);
        }

        // POST: EventReview/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ushort id)
        {
            var eventReview = await _context.EventReviews.FindAsync(id);
            _context.EventReviews.Remove(eventReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventReviewExists(ushort id)
        {
            return _context.EventReviews.Any(e => e.EventId == id);
        }
    }
}
