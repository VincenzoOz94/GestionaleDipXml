using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionaleDipXml.Data;
using GestionaleDipXml.Models;
using System.Xml.Linq;

namespace GestionaleDipXml.Controllers
{
    public class DipendentesController : Controller
    {
        private readonly DipendentiDbConext _context;

        public DipendentesController(DipendentiDbConext context)
        {
            _context = context;
        }

        // GET: Dipendentes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dipendenti.ToListAsync());
        }

        // GET: Dipendentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dipendente = await _context.Dipendenti
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dipendente == null)
            {
                return NotFound();
            }

            return View(dipendente);
        }

        // GET: Dipendentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dipendentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Dipendente model)
        {
            // vado a creare il documento XML utilizzando le informazioni del dipendente
            XElement xmlElement = new XElement("Dipendente",
                new XElement("Nome", model.Nome),
                new XElement("Cognome", model.Cognome),
                new XElement("Stipendio", model.Stipendio)
           
            );

            string xmlString = xmlElement.ToString();

            
            Dipendente dipendente = new Dipendente
            {
                Nome = model.Nome,
                Cognome = model.Cognome,
                Stipendio = model.Stipendio,
                DatiXml = xmlString
            };

            
            _context.Dipendenti.Add(dipendente);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
            //return View(dipendente);
        }

        // GET: Dipendentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dipendente = await _context.Dipendenti.FindAsync(id);
            if (dipendente == null)
            {
                return NotFound();
            }
            return View(dipendente);
        }

        // POST: Dipendentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cognome,Stipendio,DatiXml")] Dipendente dipendente)
        {
            if (id != dipendente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dipendente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DipendenteExists(dipendente.Id))
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
            return View(dipendente);
        }

        // GET: Dipendentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dipendente = await _context.Dipendenti
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dipendente == null)
            {
                return NotFound();
            }

            return View(dipendente);
        }

        // POST: Dipendentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dipendente = await _context.Dipendenti.FindAsync(id);
            if (dipendente != null)
            {
                _context.Dipendenti.Remove(dipendente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DipendenteExists(int id)
        {
            return _context.Dipendenti.Any(e => e.Id == id);
        }
    }
}
