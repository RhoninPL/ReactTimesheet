using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Web.Controllers
{
    public class TimeSheetEntriesController : Controller
    {
        private readonly TimeSheetContext _context;

        public TimeSheetEntriesController(TimeSheetContext context)
        {
            _context = context;    
        }

        // GET: TimeSheetEntries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entries.ToListAsync());
        }

        // GET: TimeSheetEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeSheetEntry = await _context.Entries
                .SingleOrDefaultAsync(m => m.TimeSheetEntryId == id);
            if (timeSheetEntry == null)
            {
                return NotFound();
            }

            return View(timeSheetEntry);
        }

        // GET: TimeSheetEntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TimeSheetEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeSheetEntryId,Company,User,WorkTime")] TimeSheetEntry timeSheetEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeSheetEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(timeSheetEntry);
        }

        // GET: TimeSheetEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeSheetEntry = await _context.Entries.SingleOrDefaultAsync(m => m.TimeSheetEntryId == id);
            if (timeSheetEntry == null)
            {
                return NotFound();
            }
            return View(timeSheetEntry);
        }

        // POST: TimeSheetEntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimeSheetEntryId,Company,User,WorkTime")] TimeSheetEntry timeSheetEntry)
        {
            if (id != timeSheetEntry.TimeSheetEntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeSheetEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeSheetEntryExists(timeSheetEntry.TimeSheetEntryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(timeSheetEntry);
        }

        // GET: TimeSheetEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeSheetEntry = await _context.Entries
                .SingleOrDefaultAsync(m => m.TimeSheetEntryId == id);
            if (timeSheetEntry == null)
            {
                return NotFound();
            }

            return View(timeSheetEntry);
        }

        // POST: TimeSheetEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeSheetEntry = await _context.Entries.SingleOrDefaultAsync(m => m.TimeSheetEntryId == id);
            _context.Entries.Remove(timeSheetEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TimeSheetEntryExists(int id)
        {
            return _context.Entries.Any(e => e.TimeSheetEntryId == id);
        }
    }
}
