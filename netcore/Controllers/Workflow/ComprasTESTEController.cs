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
    public class ComprasTESTEController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComprasTESTEController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComprasTESTE
        public async Task<IActionResult> Index()
        {
            return View(await _context.Compras.ToListAsync());
        }

        // GET: ComprasTESTE/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.Compras
                .SingleOrDefaultAsync(m => m.Id == id);
            if (compras == null)
            {
                return NotFound();
            }

            return View(compras);
        }

        // GET: ComprasTESTE/Create
        public IActionResult Create()
        {
            ViewData["CondicaoPagamento"] = new List<SelectListItem>
            {
                new SelectListItem {Text = "7 Dias após a Entrega", Value = "1"},
                new SelectListItem {Text = "À Vista", Value = "L"},

            };

            ViewData["TipoServico"] = new List<SelectListItem>
            {
                new SelectListItem {Text = "Produto", Value = "1"},
                new SelectListItem {Text = "Serviço", Value = "L"},

            };

            ViewData["PrazoEntrega"] = new List<SelectListItem>
            {
                new SelectListItem {Text = "Normal - 7 Dias", Value = "1"},
                new SelectListItem {Text = "Urgente - 3 Dias", Value = "2"},
                 new SelectListItem {Text = "Emergencial - 1 Dia Útil", Value = "3"},

            };

            List<SelectListItem> lista = new List<SelectListItem>();
            lista = (from c in _context.Produto select new SelectListItem { Text = c.Descricao, Value = c.CodigoProdutoRM }).ToList();

            ViewData["Movimento"] = new List<SelectListItem>
            {
                new SelectListItem {Text = "1.1.01 - Solicitação de Compras", Value = "1.1.01"},
             };



            ViewData["Produto"] = lista;

            ViewData["Coligada"] = (from c in _context.MatrizFilial select new SelectListItem { Value = c.Id.ToString(), Text = c.CodMatriz + " - " + c.Matriz + " |" + c.CodFilial + " - " + c.Filial }).ToList();

            return View();
        }

        // POST: ComprasTESTE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cargo,Area,CentroCusto,Empresa,TipoProduto,TipoServico,Departamento,Processo,DataSolicitacao,Motivo,Fornecedor,Tributos,TotalGeral,Movimento,DataEntrega,DataVencimento,CondicaoPagamento")] Compras compras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compras);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(compras);
        }

        // GET: ComprasTESTE/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.Compras.SingleOrDefaultAsync(m => m.Id == id);
            if (compras == null)
            {
                return NotFound();
            }
            return View(compras);
        }

        // POST: ComprasTESTE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cargo,Area,CentroCusto,Empresa,TipoProduto,TipoServico,Departamento,Processo,DataSolicitacao,Motivo,Fornecedor,Tributos,TotalGeral,Movimento,DataEntrega,DataVencimento,CondicaoPagamento")] Compras compras)
        {
            if (id != compras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComprasExists(compras.Id))
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
            return View(compras);
        }

        // GET: ComprasTESTE/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.Compras
                .SingleOrDefaultAsync(m => m.Id == id);
            if (compras == null)
            {
                return NotFound();
            }

            return View(compras);
        }

        // POST: ComprasTESTE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compras = await _context.Compras.SingleOrDefaultAsync(m => m.Id == id);
            _context.Compras.Remove(compras);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComprasExists(int id)
        {
            return _context.Compras.Any(e => e.Id == id);
        }
    }
}
