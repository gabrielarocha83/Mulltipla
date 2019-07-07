using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models.RM;

namespace MulltiplaJML.Controllers.Workflow
{
    public class CapexImportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CapexImportController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CapexImport
        public async Task<IActionResult> Index()
        {
            return View(await _context.CapexImport.ToListAsync());
        }

        // GET: CapexImport/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capexImport = await _context.CapexImport
                .SingleOrDefaultAsync(m => m.Id == id);
            if (capexImport == null)
            {
                return NotFound();
            }

            return View(capexImport);
        }

        // GET: CapexImport/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CapexImport/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContaContabil,Coligada,ContaGerencial,ColigadaGerencial,Filial,CentroCusto,Departamento,Ano,ValorMes1,ValorMes2,ValorMes3,ValorMes4,ValorMes5,ValorMes6,ValorMes7,ValorMes8,ValorMes9,ValorMes10,ValorMes11,ValorMes12,Valor2Mes1,Valor2Mes2,Valor2Mes3,Valor2Mes4,Valor2Mes5,Valor2Mes6,Valor2Mes7,Valor2Mes8,Valor2Mes9,Valor2Mes10,Valor2Mes11,Valor2Mes12")] CapexImport capexImport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(capexImport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(capexImport);
        }

        // GET: CapexImport/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capexImport = await _context.CapexImport.SingleOrDefaultAsync(m => m.Id == id);
            if (capexImport == null)
            {
                return NotFound();
            }
            return View(capexImport);
        }

        // POST: CapexImport/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContaContabil,Coligada,ContaGerencial,ColigadaGerencial,Filial,CentroCusto,Departamento,Ano,ValorMes1,ValorMes2,ValorMes3,ValorMes4,ValorMes5,ValorMes6,ValorMes7,ValorMes8,ValorMes9,ValorMes10,ValorMes11,ValorMes12,Valor2Mes1,Valor2Mes2,Valor2Mes3,Valor2Mes4,Valor2Mes5,Valor2Mes6,Valor2Mes7,Valor2Mes8,Valor2Mes9,Valor2Mes10,Valor2Mes11,Valor2Mes12")] CapexImport capexImport)
        {
            if (id != capexImport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(capexImport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CapexImportExists(capexImport.Id))
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
            return View(capexImport);
        }

        // GET: CapexImport/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capexImport = await _context.CapexImport
                .SingleOrDefaultAsync(m => m.Id == id);
            if (capexImport == null)
            {
                return NotFound();
            }

            return View(capexImport);
        }

        // POST: CapexImport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var capexImport = await _context.CapexImport.SingleOrDefaultAsync(m => m.Id == id);
            _context.CapexImport.Remove(capexImport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CapexImportExists(int id)
        {
            return _context.CapexImport.Any(e => e.Id == id);
        }
    }
}
