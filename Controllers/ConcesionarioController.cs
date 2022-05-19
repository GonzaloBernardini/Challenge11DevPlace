using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConcesionarioChallenge11.Data;
using ConcesionarioChallenge11.Models;
using Microsoft.AspNetCore.Authorization;

namespace ConcesionarioChallenge11.Controllers
{
    
    public class ConcesionarioController : Controller
    {
        private readonly ConcesionarioChallenge11Context _context;

        public ConcesionarioController(ConcesionarioChallenge11Context context)
        {
            _context = context;
        }
        
        
        // GET: Concesionario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Concesionario.ToListAsync());
        }
        

        // GET: Concesionario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concesionario = await _context.Concesionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concesionario == null)
            {
                return NotFound();
            }

            return View(concesionario);
        }

        // GET: Concesionario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Concesionario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Nombre,Logo,Descripcion,Email,Telefono,Direccion")] Concesionario concesionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concesionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concesionario);
        }

        // GET: Concesionario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concesionario = await _context.Concesionario.FindAsync(id);
            if (concesionario == null)
            {
                return NotFound();
            }
            return View(concesionario);
        }

        // POST: Concesionario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Logo,Descripcion,Email,Telefono,Direccion")] Concesionario concesionario)
        {
            if (id != concesionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concesionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcesionarioExists(concesionario.Id))
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
            return View(concesionario);
        }

        // GET: Concesionario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concesionario = await _context.Concesionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concesionario == null)
            {
                return NotFound();
            }

            return View(concesionario);
        }

        // POST: Concesionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var concesionario = await _context.Concesionario.FindAsync(id);
            _context.Concesionario.Remove(concesionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcesionarioExists(int id)
        {
            return _context.Concesionario.Any(e => e.Id == id);
        }
    }
}
