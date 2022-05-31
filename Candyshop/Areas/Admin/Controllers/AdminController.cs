using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Candyshop.Models;

namespace Candyshop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Candies.Include(c => c.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candy = await _context.Candies
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.CandyId == id);
            if (candy == null)
            {
                return NotFound();
            }

            return View(candy);
        }

        // GET: Admin/Admin/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categores, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Admin/Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CandyId,Name,Description,Price,ImageUrl,ImageThumbnailUrl,IsOnSale,IsInStock,CategoryId")] Candy candy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categores, "CategoryId", "CategoryId", candy.CategoryId);
            return View(candy);
        }

        // GET: Admin/Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candy = await _context.Candies.FindAsync(id);
            if (candy == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categores, "CategoryId", "CategoryId", candy.CategoryId);
            return View(candy);
        }

        // POST: Admin/Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CandyId,Name,Description,Price,ImageUrl,ImageThumbnailUrl,IsOnSale,IsInStock,CategoryId")] Candy candy)
        {
            if (id != candy.CandyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandyExists(candy.CandyId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categores, "CategoryId", "CategoryId", candy.CategoryId);
            return View(candy);
        }

        // GET: Admin/Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candy = await _context.Candies
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.CandyId == id);
            if (candy == null)
            {
                return NotFound();
            }

            return View(candy);
        }

        // POST: Admin/Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candy = await _context.Candies.FindAsync(id);
            _context.Candies.Remove(candy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandyExists(int id)
        {
            return _context.Candies.Any(e => e.CandyId == id);
        }
    }
}
