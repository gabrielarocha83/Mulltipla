using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models.XML;

namespace MulltiplaJML.Controllers.XML
{
    public class CteController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _hostingEnvironment;
        public CteController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _hostingEnvironment = environment;
        }

        [HttpPost]
        public IActionResult Index(IEnumerable<GDXMLCTE> gDXMLCTEs)
        {
            return null;
        }
            // GET: Cte
            public IActionResult Index()
        {

            List<GDXMLCTE> xml = new List<GDXMLCTE>();

            xml = _context.GDXMLCTE.ToList();

            List<INTEGRAPEDIDO> l = new List<INTEGRAPEDIDO>();
            INTEGRAPEDIDO p = new INTEGRAPEDIDO();
            p.Id = 1;
            p.VALOR = "Sem Pedidos";

            l.Add(p);


            foreach (GDXMLCTE x in xml)
            {
                x.Pedidos = new List<INTEGRAPEDIDO>();
                x.Pedidos = l;
            }

            return View(xml);
        }


        public FileResult Download(string id)
        {
            string xmlString =_context.GDXMLCTE.Where(p=>p.chCte == id).FirstOrDefault().xml;
            string fileName = id + ".xml";


          

            return File(Encoding.UTF8.GetBytes(xmlString), "application/xml", fileName);
        }

        // GET: Cte/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLCTE = await _context.GDXMLCTE.Where(m => m.id == id).FirstOrDefaultAsync();

            gDXMLCTE.Nfe = new List<GDXMLHEADER>();

            List<GDXMLHEADER> xml = new List<GDXMLHEADER>();

            xml = (from n in _context.GDXMLHEADER
                   join c in _context.GDCTENFE on n.CHAVE equals c.chNfe
                   where c.chCte == gDXMLCTE.chCte
                   select n).ToList();

            foreach (GDXMLHEADER g in xml)
            {
                g.GDXML = new GDXML();
                g.GDXML = await _context.GDXML.Where(p => p.CHAVE == g.CHAVE).FirstOrDefaultAsync();
              }


            gDXMLCTE.Nfe = xml;


            if (gDXMLCTE == null)
            {
                return NotFound();
            }

            return View(gDXMLCTE);
        }

        // GET: Cte/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cte/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,chCte,cUF,cCT,natOp,forPag,mod,serie,nCT,dhEmi,tpImp,tpEmis,cDV,tpAmb,tpCTe,procEmi,verProc,cMunEnv,xMunEnv,UFEnv,modal,tpServ,cMunIni,xml,CST,vBC,pICMS,vICMS,Integrado,Emitente,Remetente,Destinatario,vTPrest")] GDXMLCTE gDXMLCTE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gDXMLCTE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gDXMLCTE);
        }

        // GET: Cte/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLCTE = await _context.GDXMLCTE.Where(m => m.id == id).FirstOrDefaultAsync();

            gDXMLCTE.Nfe = new List<GDXMLHEADER>();

            List<GDXMLHEADER> xml = new List<GDXMLHEADER>();

            xml = (from n in _context.GDXMLHEADER
                   join c in _context.GDCTENFE on n.CHAVE equals c.chNfe
                   where c.chCte == gDXMLCTE.chCte
                   select n).ToList();

            gDXMLCTE.Nfe = xml;

            if (gDXMLCTE == null)
            {
                return NotFound();
            }
            return View(gDXMLCTE);
        }

        // POST: Cte/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,chCte,cUF,cCT,natOp,forPag,mod,serie,nCT,dhEmi,tpImp,tpEmis,cDV,tpAmb,tpCTe,procEmi,verProc,cMunEnv,xMunEnv,UFEnv,modal,tpServ,cMunIni,xml,CST,vBC,pICMS,vICMS,Integrado,Emitente,Remetente,Destinatario,vTPrest")] GDXMLCTE gDXMLCTE)
        {
            if (id != gDXMLCTE.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gDXMLCTE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GDXMLCTEExists(gDXMLCTE.id))
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
            return View(gDXMLCTE);
        }

        // GET: Cte/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLCTE = await _context.GDXMLCTE
                .SingleOrDefaultAsync(m => m.id == id);
            if (gDXMLCTE == null)
            {
                return NotFound();
            }

            return View(gDXMLCTE);
        }

        // POST: Cte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gDXMLCTE = await _context.GDXMLCTE.SingleOrDefaultAsync(m => m.id == id);
            _context.GDXMLCTE.Remove(gDXMLCTE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GDXMLCTEExists(int id)
        {
            return _context.GDXMLCTE.Any(e => e.id == id);
        }
    }
}
