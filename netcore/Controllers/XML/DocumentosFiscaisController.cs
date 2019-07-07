using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models.XML;

namespace MulltiplaJML.Controllers.XML
{
    public class DocumentosFiscaisController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ErpContext _erpcontext;


        public DocumentosFiscaisController(ApplicationDbContext context, ErpContext erpcontext)
        {
            _context = context;
            _erpcontext = erpcontext;
        }

        public async Task<IActionResult> AlterarNota(string Pedido, string Chave)
        {
            var rec = Pedido;

            GDXMLHEADER header = new GDXMLHEADER();
            if (Pedido != "")
            {
                GDXML xml = new GDXML();
                xml = _context.GDXML.Where(p => p.CHAVE == Chave).FirstOrDefault();

                if (xml != null)
                {
                    xml.NUMPEDIDO = Pedido;
                    _context.Entry(xml).State = EntityState.Modified;
                    _context.SaveChanges();
                }
            }
            return Ok();
        }
        // GET: DocumentosFiscais
        public async Task<IActionResult> Index()
        {

            List<GDXMLHEADER> xml = new List<GDXMLHEADER>();

            xml = await _context.GDXMLHEADER.ToListAsync();

            
            return View(xml);
        }

        // GET: DocumentosFiscais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLHEADER = await _context.GDXMLHEADER
                .SingleOrDefaultAsync(m => m.ID == id);

            ViewData["ItensXML"] = (from c in _context.GDXMLITENS where c.CHNFE == gDXMLHEADER.CHAVE select c).ToList();
                
             if (gDXMLHEADER == null)
            {
                return NotFound();
            }

            return View(gDXMLHEADER);
        }

        // GET: DocumentosFiscais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocumentosFiscais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CHAVE,CUF,CNF,NATOP,INDPAG,MOD,SERIE,NNF,DEMI,DSAIENT,HSAIENT,TPNF,CMUNFG,TPIMP,TPEMIS,CDV,TPAMB,FINNFE,PROCEMI,VERPROC,CNPJEMITENTE,CNPJDESTINATARIO,DVENC,INFCPL,VBC,VICMS,VBCST,VST,VPROD,VFRETE,VSEG,VDESC,VII,VIPI,VPIS,VCOFINS,VOUTRO,VNF,VTOTTRIB")] GDXMLHEADER gDXMLHEADER)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gDXMLHEADER);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gDXMLHEADER);
        }

        // GET: DocumentosFiscais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLHEADER = await _context.GDXMLHEADER.SingleOrDefaultAsync(m => m.ID == id);
            if (gDXMLHEADER == null)
            {
                return NotFound();
            }
            return View(gDXMLHEADER);
        }

        // POST: DocumentosFiscais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CHAVE,CUF,CNF,NATOP,INDPAG,MOD,SERIE,NNF,DEMI,DSAIENT,HSAIENT,TPNF,CMUNFG,TPIMP,TPEMIS,CDV,TPAMB,FINNFE,PROCEMI,VERPROC,CNPJEMITENTE,CNPJDESTINATARIO,DVENC,INFCPL,VBC,VICMS,VBCST,VST,VPROD,VFRETE,VSEG,VDESC,VII,VIPI,VPIS,VCOFINS,VOUTRO,VNF,VTOTTRIB")] GDXMLHEADER gDXMLHEADER)
        {
            if (id != gDXMLHEADER.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gDXMLHEADER);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GDXMLHEADERExists(gDXMLHEADER.ID))
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
            return View(gDXMLHEADER);
        }

        public FileResult Download(string id)
        {
            string xmlString = _context.GDXML.Where(p => p.CHAVE == id).FirstOrDefault().XML;
            string fileName = id + ".xml";


            //string pasta = @"C:\XmlDanfe";
            //string caminhoOut = "DanfesDeXml";

            //if (!Directory.Exists(caminhoOut)) Directory.CreateDirectory(caminhoOut);

            //var arquivos = Directory.EnumerateFiles(pasta, "*.xml");
            //if (arquivos.Count() == 0)
            //    throw new FileNotFoundException($"Nenhum arquivo xml encontrado em {pasta}.");

            //foreach (var pathXml in arquivos)
            //{
            //    var model = DanfeViewModelCreator.CriarDeArquivoXml(pathXml);
            //    using (Danfe danfe = new Danfe(model))
            //    {
            //        danfe.Gerar();
            //        danfe.Salvar($"{caminhoOut}/{model.ChaveAcesso}.pdf");
            //    }
            //}

            return File(Encoding.UTF8.GetBytes(xmlString), "application/xml", fileName);
        }
        // GET: DocumentosFiscais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLHEADER = await _context.GDXMLHEADER
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gDXMLHEADER == null)
            {
                return NotFound();
            }

            return View(gDXMLHEADER);
        }

        // POST: DocumentosFiscais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gDXMLHEADER = await _context.GDXMLHEADER.SingleOrDefaultAsync(m => m.ID == id);
            _context.GDXMLHEADER.Remove(gDXMLHEADER);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GDXMLHEADERExists(int id)
        {
            return _context.GDXMLHEADER.Any(e => e.ID == id);
        }
    }
}
