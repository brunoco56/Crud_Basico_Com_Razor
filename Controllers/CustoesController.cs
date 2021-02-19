using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContSelf.Entidade;
using ContSelf.Models;

namespace ContSelf.Controllers
{
    public class CustoesController : Controller
    {
        private readonly Contexto _context;

        public CustoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Custoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Custo.ToListAsync());
        }

        // GET: Custoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custo = await _context.Custo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custo == null)
            {
                return NotFound();
            }

            return View(custo);
        }

        // GET: Custoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Custoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Descricao,valor")] Custo custo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custo);
        }

        // GET: Custoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custo = await _context.Custo.FindAsync(id);
            if (custo == null)
            {
                return NotFound();
            }
            return View(custo);
        }

        // POST: Custoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Descricao,valor")] Custo custo)
        {
            if (id != custo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(custo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustoExists(custo.Id))
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
            return View(custo);
        }

        // GET: Custoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custo = await _context.Custo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custo == null)
            {
                return NotFound();
            }

            return View(custo);
        }

        // POST: Custoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custo = await _context.Custo.FindAsync(id);
            _context.Custo.Remove(custo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustoExists(int id)
        {
            return _context.Custo.Any(e => e.Id == id);
        }
    }
}
