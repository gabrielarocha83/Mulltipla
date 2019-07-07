using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models.Invent;

namespace MulltiplaJML.Controllers.Invent
{
    public class OrdemServicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdemServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrdemServicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdemServico.ToListAsync());
        }

        // GET: OrdemServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.OrdemServico
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // GET: OrdemServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdemServicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,idUsuario,NumeroOS,NumeroPedido,ChaveNF,DataRecebimento,DataOS,CodFornecedor,NomeFornecedor,Status,Observacao,TipoRecebimento,ValorTotal")] OrdemServico ordemServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordemServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordemServico);
        }

        // GET: OrdemServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Status = new List<SelectListItem>
            {
                new SelectListItem {Text = "Pendente", Value = "P"},
                new SelectListItem {Text = "Em Andamento", Value = "A"},
                  new SelectListItem {Text = "Concluído", Value = "C"},
                new SelectListItem {Text = "Devolvido", Value = "D"}
            };

            var ordemServico = await _context.OrdemServico.SingleOrDefaultAsync(m => m.Id == id);

            ordemServico.itensOrdemServicos = new List<ItensOrdemServico>();

            ordemServico.itensOrdemServicos = _context.ItensOrdemServico.Where(p => p.NumeroPedido == ordemServico.NumeroPedido).ToList();
            if (ordemServico == null)
            {
                return NotFound();
            }
            return View(ordemServico);
        }

        // POST: OrdemServicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdUsuario,NumeroOS,NumeroPedido,ChaveNF,DataRecebimento,DataOS,CodFornecedor,NomeFornecedor,Status,Observacao,TipoRecebimento,ValorTotal")] OrdemServico ordemServico)
        {
            if (id != ordemServico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordemServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdemServicoExists(ordemServico.Id))
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
            return View(ordemServico);
        }

        // GET: OrdemServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.OrdemServico
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // POST: OrdemServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordemServico = await _context.OrdemServico.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrdemServico.Remove(ordemServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdemServicoExists(int id)
        {
            return _context.OrdemServico.Any(e => e.Id == id);
        }
    }
}
