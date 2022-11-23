using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NomeTelefoneCodeFirst.Data;
using NomeTelefoneCodeFirst.Models;

namespace NomeTelefoneCodeFirst.Controllers
{
    public class AgendaController : Controller
    {
        private readonly AgendaContext _context;

        public AgendaController(AgendaContext context)
        {
            _context = context;
        }

        // GET: Agenda
        public async Task<IActionResult> Index()
        {
              return View(await _context.Agendamentos.ToListAsync());
        }

        // GET: Agenda/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Agendamentos == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // GET: Agenda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone")] Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                agenda.Id = Guid.NewGuid();
                _context.Add(agenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        // GET: Agenda/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Agendamentos == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendamentos.FindAsync(id);
            if (agenda == null)
            {
                return NotFound();
            }
            return View(agenda);
        }

        // POST: Agenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,Telefone")] Agenda agenda)
        {
            if (id != agenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendaExists(agenda.Id))
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
            return View(agenda);
        }

        // GET: Agenda/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Agendamentos == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Agendamentos == null)
            {
                return Problem("Entity set 'AgendaContext.Agendamentos'  is null.");
            }
            var agenda = await _context.Agendamentos.FindAsync(id);
            if (agenda != null)
            {
                _context.Agendamentos.Remove(agenda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendaExists(Guid id)
        {
          return _context.Agendamentos.Any(e => e.Id == id);
        }
    }
}
