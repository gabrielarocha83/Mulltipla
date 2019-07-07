using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models;

namespace MulltiplaJML.Controllers.Workflow
{
    public class ItensComprasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItensComprasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItensCompras
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItensCompra.ToListAsync());
        }

        // GET: ItensCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensCompra = await _context.ItensCompra
                .SingleOrDefaultAsync(m => m.Id == id);
            if (itensCompra == null)
            {
                return NotFound();
            }

            return View(itensCompra);
        }

        // GET: ItensCompras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItensCompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCompras,Quantidade,UnidadeMedida,CodProduto,Produto,ValorUnitario,ValorTotal,EspecificaçãoTecnica")] ItensCompra itensCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itensCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itensCompra);
        }

        // GET: ItensCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensCompra = await _context.ItensCompra.SingleOrDefaultAsync(m => m.Id == id);
            if (itensCompra == null)
            {
                return NotFound();
            }
            return View(itensCompra);
        }

        // POST: ItensCompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCompras,Quantidade,UnidadeMedida,CodProduto,Produto,ValorUnitario,ValorTotal,EspecificaçãoTecnica")] ItensCompra itensCompra)
        {
            if (id != itensCompra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itensCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItensCompraExists(itensCompra.Id))
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
            return View(itensCompra);
        }

        // GET: ItensCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensCompra = await _context.ItensCompra
                .SingleOrDefaultAsync(m => m.Id == id);
            if (itensCompra == null)
            {
                return NotFound();
            }

            return View(itensCompra);
        }

        // POST: ItensCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itensCompra = await _context.ItensCompra.SingleOrDefaultAsync(m => m.Id == id);
            _context.ItensCompra.Remove(itensCompra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItensCompraExists(int id)
        {
            return _context.ItensCompra.Any(e => e.Id == id);
        }
    }
}
