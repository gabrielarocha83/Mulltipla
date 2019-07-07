using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models;
using MulltiplaJML.Models.RM;

namespace MulltiplaJML.Controllers.Workflow
{
    public class ComprasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ErpContext _contextERP;
        public ComprasController(ApplicationDbContext context, ErpContext contextERP)
        {
            _context = context;
            _contextERP = contextERP;
        }

        // GET: Compras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Compras.ToListAsync());
        }

        // GET: Compras/Details/5
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

        // GET: Compras/Create
        public IActionResult Create()
        {
            PreencherCampos();
            return View();
        }
        public void PreencherCampos()
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


        //     public int Id { get; set; }
        //public string CODCFO { get; set; }
        //public string C { get; set; }
        List<SelectListItem> fornecedor = new List<SelectListItem>();
            fornecedor = (from c in _contextERP.FCFO.FromSql("SELECT DISTINCT 0 AS Id,CODCFO, NOMEFANTASIA AS  DESCRICAO FROM FCFO ").Take(100) select new SelectListItem { Text = c.DESCRICAO, Value = c.CODCFO }).ToList();
            ViewData["Fornecedor"] = fornecedor;


            ViewData["Movimento"] = new List<SelectListItem>
            {
                new SelectListItem {Text = "1.1.01 - Solicitação de Compras", Value = "1.1.01"},
             };


            ViewData["ItensCadastrados"] = new List<ItensCompra>();
            ViewData["Produto"] = lista;

            ViewData["Coligada"] = (from c in _context.MatrizFilial select new SelectListItem { Value = c.Id.ToString(), Text = c.CodMatriz + " - " + c.Matriz + " |" + c.CodFilial + " - " + c.Filial }).ToList();

        }

        // POST: Compras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cargo,Area,CentroCusto,Empresa,TipoProduto,TipoServico,Departamento,Processo,DataSolicitacao,Motivo,Fornecedor,Tributos,TotalGeral,Movimento,DataEntrega,DataVencimento,CondicaoPagamento")] Compras compras)
        {
            if (ModelState.IsValid)
            {
                compras.Status = "Pendente";
                _context.Add(compras);
                await _context.SaveChangesAsync();
                //RedirectToAction("Edit/" + compras.Id);
                return RedirectToAction(nameof(Edit) +"/"+ compras.Id);
            }
            //PreencherCampos();
            return View(compras);
        }

        [HttpPost]
        public IActionResult SalvarItens(string produto, string Quantidade , int Id)
        {
            Produto pr = new Produto();
            pr = _context.Produto.Where(p => p.CodigoProdutoRM == produto).FirstOrDefault();
            ItensCompra itens = new ItensCompra();
            itens.CodProduto = pr.CodigoProdutoRM;
            itens.Produto = pr.Descricao;
            itens.Quantidade = Quantidade;
            itens.ValorUnitario = pr.Valor;
            itens.ValorTotal = Convert.ToString(Convert.ToDecimal(pr.Valor) * Convert.ToDecimal( Quantidade));
            itens.UnidadeMedida = pr.Unidade;
            //itens.Id = Id;
            itens.IdCompras = Id;

            _context.Add(itens);
            _context.SaveChanges();

            ViewData["ItensCadastrados"] = _context.ItensCompra.Where(p => p.IdCompras == Id).ToList();
            return Json(produto);
        }

        // GET: Compras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PreencherCampos();
            ViewData["ItensCadastrados"] = _context.ItensCompra.Where(p => p.IdCompras == id).ToList();
            var compras = await _context.Compras.SingleOrDefaultAsync(m => m.Id == id);
            if (compras == null)
            {
                return NotFound();
            }
            return View(compras);
        }

        // POST: Compras/Edit/5
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
                //return RedirectToAction(nameof(Index));
            }
            PreencherCampos();
            return View(compras);
        }

        // GET: Compras/Delete/5
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

        // POST: Compras/Delete/5
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
