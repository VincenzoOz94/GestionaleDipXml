using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionaleDipXml.Model;
using GestionaleDipXml.Data;

namespace GestionaleDipXml.Controllers
{
    public class SevenDataRapportiInformativiController : Controller
    {
        private readonly TestXmlContext _context;

        public SevenDataRapportiInformativiController(TestXmlContext context)
        {
            _context = context;
        }

        // GET: SevenDataRapportiInformativi
        public async Task<IActionResult> Index()
        {
            return View(await _context.SevenDataRapportoInformativos.ToListAsync());
        }

        // GET: SevenDataRapportiInformativi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sevenDataRapportoInformativo = await _context.SevenDataRapportoInformativos
                .FirstOrDefaultAsync(m => m.Oid == id);
            if (sevenDataRapportoInformativo == null)
            {
                return NotFound();
            }

            return View(sevenDataRapportoInformativo);
        }

        // GET: SevenDataRapportiInformativi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SevenDataRapportiInformativi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Oid,OidProdotto,OidCliente,DataRichiesta,DataRisposta,DataRispostaShort,Elaborato,Xml,Rating,StatoAttivita,Fido,ScoreBilancio,Negativita,AnnoBilancio,IdrichiestaJson,IdrichiestaPdf")] SevenDataRapportoInformativo sevenDataRapportoInformativo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sevenDataRapportoInformativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sevenDataRapportoInformativo);
        }

        // GET: SevenDataRapportiInformativi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sevenDataRapportoInformativo = await _context.SevenDataRapportoInformativos.FindAsync(id);
            if (sevenDataRapportoInformativo == null)
            {
                return NotFound();
            }
            return View(sevenDataRapportoInformativo);
        }

        // POST: SevenDataRapportiInformativi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Oid,OidProdotto,OidCliente,DataRichiesta,DataRisposta,DataRispostaShort,Elaborato,Xml,Rating,StatoAttivita,Fido,ScoreBilancio,Negativita,AnnoBilancio,IdrichiestaJson,IdrichiestaPdf")] SevenDataRapportoInformativo sevenDataRapportoInformativo)
        {
            if (id != sevenDataRapportoInformativo.Oid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sevenDataRapportoInformativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SevenDataRapportoInformativoExists(sevenDataRapportoInformativo.Oid))
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
            return View(sevenDataRapportoInformativo);
        }

        // GET: SevenDataRapportiInformativi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sevenDataRapportoInformativo = await _context.SevenDataRapportoInformativos
                .FirstOrDefaultAsync(m => m.Oid == id);
            if (sevenDataRapportoInformativo == null)
            {
                return NotFound();
            }

            return View(sevenDataRapportoInformativo);
        }

        // POST: SevenDataRapportiInformativi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sevenDataRapportoInformativo = await _context.SevenDataRapportoInformativos.FindAsync(id);
            if (sevenDataRapportoInformativo != null)
            {
                _context.SevenDataRapportoInformativos.Remove(sevenDataRapportoInformativo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SevenDataRapportoInformativoExists(int id)
        {
            return _context.SevenDataRapportoInformativos.Any(e => e.Oid == id);
        }
    }
}
