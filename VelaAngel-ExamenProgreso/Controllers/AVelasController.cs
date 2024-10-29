using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VelaAngel_ExamenProgreso.Data;
using VelaAngel_ExamenProgreso.Models;

namespace VelaAngel_ExamenProgreso.Controllers
{
    public class AVelasController : Controller
    {
        private readonly VelaAngel_ExamenProgresoContext _context;

        public AVelasController(VelaAngel_ExamenProgresoContext context)
        {
            _context = context;
        }

        // GET: AVelas
        public async Task<IActionResult> Index()
        {
            var velaAngel_ExamenProgresoContext = _context.AVela.Include(a => a.Celular);
            return View(await velaAngel_ExamenProgresoContext.ToListAsync());
        }

        // GET: AVelas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aVela = await _context.AVela
                .Include(a => a.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aVela == null)
            {
                return NotFound();
            }

            return View(aVela);
        }

        // GET: AVelas/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Set<Celular>(), "Id", "Id");
            return View();
        }

        // POST: AVelas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Altura,Hincha,Nacimiento,IdCelular")] AVela aVela)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aVela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Set<Celular>(), "Id", "Id", aVela.Id);
            return View(aVela);
        }

        // GET: AVelas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aVela = await _context.AVela.FindAsync(id);
            if (aVela == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Set<Celular>(), "Id", "Id", aVela.Id);
            return View(aVela);
        }

        // POST: AVelas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Altura,Hincha,Nacimiento,IdCelular")] AVela aVela)
        {
            if (id != aVela.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aVela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AVelaExists(aVela.Id))
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
            ViewData["Id"] = new SelectList(_context.Set<Celular>(), "Id", "Id", aVela.Id);
            return View(aVela);
        }

        // GET: AVelas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aVela = await _context.AVela
                .Include(a => a.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aVela == null)
            {
                return NotFound();
            }

            return View(aVela);
        }

        // POST: AVelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aVela = await _context.AVela.FindAsync(id);
            if (aVela != null)
            {
                _context.AVela.Remove(aVela);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AVelaExists(int id)
        {
            return _context.AVela.Any(e => e.Id == id);
        }
    }
}
