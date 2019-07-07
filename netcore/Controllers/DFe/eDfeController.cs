using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models.DFe;

namespace MulltiplaJML.Controllers.DFe
{
    public class eDfeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public eDfeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: eDfe
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Resnfe.Take(10).ToListAsync());
        }

        // GET: eDfe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resNFe = await _context.Resnfe
                .SingleOrDefaultAsync(m => m.Id == id);
            if (resNFe == null)
            {
                return NotFound();
            }

            return View(resNFe);
        }

        // GET: eDfe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: eDfe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ChNFe,CNPJ,CPF,XNome,IE,DhEmi,TpNF,VNF,DigVal,DhRecbTo,NProt,CSitNFe,CnpjTomador,Manifesta,DataManifestacao,NSU,createdAt")] ResNFe resNFe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resNFe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resNFe);
        }

        // GET: eDfe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resNFe = await _context.Resnfe.SingleOrDefaultAsync(m => m.Id == id);
            if (resNFe == null)
            {
                return NotFound();
            }
            return View(resNFe);
        }

        // POST: eDfe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChNFe,CNPJ,CPF,XNome,IE,DhEmi,TpNF,VNF,DigVal,DhRecbTo,NProt,CSitNFe,CnpjTomador,Manifesta,DataManifestacao,NSU,TipoEvento, Observacao, createdAt")] ResNFe resNFe)
        {
            if (id != resNFe.Id)
            {
                return NotFound();
            }

            ResNFe nfe = new ResNFe();
            nfe = _context.Resnfe.Where(p => p.Id == id).FirstOrDefault();

            nfe.TipoEvento = resNFe.TipoEvento;
            nfe.Observacao = resNFe.Observacao;

                try
                {
                    _context.Update(nfe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResNFeExists(resNFe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            ViewBag.Mensagem = "Manifestação realizada com Sucesso";
            // return RedirectToAction(nameof(Index));

            return View(nfe);
        }

        // GET: eDfe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resNFe = await _context.Resnfe
                .SingleOrDefaultAsync(m => m.Id == id);
            if (resNFe == null)
            {
                return NotFound();
            }

            return View(resNFe);
        }

        // POST: eDfe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resNFe = await _context.Resnfe.SingleOrDefaultAsync(m => m.Id == id);
            _context.Resnfe.Remove(resNFe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResNFeExists(int id)
        {
            return _context.Resnfe.Any(e => e.Id == id);
        }
    }
}
