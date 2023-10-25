using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AndresGuaman_Examen1PROG.Data;
using AndresGuaman_Examen1PROG.Models;

namespace AndresGuaman_Examen1PROG.Controllers
{
    public class AndresGuaman_tablaController : Controller
    {
        private readonly AndresGuaman_Examen1PROGContext _context;

        public AndresGuaman_tablaController(AndresGuaman_Examen1PROGContext context)
        {
            _context = context;
        }

        // GET: AndresGuaman_tabla
        public async Task<IActionResult> Index()
        {
              return _context.AndresGuaman_tabla != null ? 
                          View(await _context.AndresGuaman_tabla.ToListAsync()) :
                          Problem("Entity set 'AndresGuaman_Examen1PROGContext.AndresGuaman_tabla'  is null.");
        }

        // GET: AndresGuaman_tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AndresGuaman_tabla == null)
            {
                return NotFound();
            }

            var andresGuaman_tabla = await _context.AndresGuaman_tabla
                .FirstOrDefaultAsync(m => m.agEmpleadoId == id);
            if (andresGuaman_tabla == null)
            {
                return NotFound();
            }

            return View(andresGuaman_tabla);
        }

        // GET: AndresGuaman_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AndresGuaman_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("agEmpleadoId,agSalario,agNombre,agConNombramiento,agFecha,agCedula")] AndresGuaman_tabla andresGuaman_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(andresGuaman_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(andresGuaman_tabla);
        }

        // GET: AndresGuaman_tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AndresGuaman_tabla == null)
            {
                return NotFound();
            }

            var andresGuaman_tabla = await _context.AndresGuaman_tabla.FindAsync(id);
            if (andresGuaman_tabla == null)
            {
                return NotFound();
            }
            return View(andresGuaman_tabla);
        }

        // POST: AndresGuaman_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("agEmpleadoId,agSalario,agNombre,agConNombramiento,agFecha,agCedula")] AndresGuaman_tabla andresGuaman_tabla)
        {
            if (id != andresGuaman_tabla.agEmpleadoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(andresGuaman_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AndresGuaman_tablaExists(andresGuaman_tabla.agEmpleadoId))
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
            return View(andresGuaman_tabla);
        }

        // GET: AndresGuaman_tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AndresGuaman_tabla == null)
            {
                return NotFound();
            }

            var andresGuaman_tabla = await _context.AndresGuaman_tabla
                .FirstOrDefaultAsync(m => m.agEmpleadoId == id);
            if (andresGuaman_tabla == null)
            {
                return NotFound();
            }

            return View(andresGuaman_tabla);
        }

        // POST: AndresGuaman_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AndresGuaman_tabla == null)
            {
                return Problem("Entity set 'AndresGuaman_Examen1PROGContext.AndresGuaman_tabla'  is null.");
            }
            var andresGuaman_tabla = await _context.AndresGuaman_tabla.FindAsync(id);
            if (andresGuaman_tabla != null)
            {
                _context.AndresGuaman_tabla.Remove(andresGuaman_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AndresGuaman_tablaExists(int id)
        {
          return (_context.AndresGuaman_tabla?.Any(e => e.agEmpleadoId == id)).GetValueOrDefault();
        }
    }
}
