using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models.XML;

namespace MulltiplaJML.Controllers.XML
{
    public class ItensDocumentosFiscaisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItensDocumentosFiscaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItensDocumentosFiscais
        public async Task<IActionResult> Index()
        {
            return View(await _context.GDXMLITENS.ToListAsync());
        }

        // GET: ItensDocumentosFiscais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLITENS = await _context.GDXMLITENS
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gDXMLITENS == null)
            {
                return NotFound();
            }

            return View(gDXMLITENS);
        }

        // GET: ItensDocumentosFiscais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItensDocumentosFiscais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CHNFE,VERAPLIC,CPROD,XPROD,NCM,CFOP,UCOM,QCOM,VUNCOM,VPROD,CEANTRIB,UTRIB,QTRIB,VUNTRIB,INDTOT,CEAN,ICMS_ORI,ICMS_CST,ICMS_VBCSTRET,ICMS_VICMSSTRETI,IPI_CENQ,IPI_CST,PIS_CST,PIS_VBC,PIS_PPIS,PIS_VPIS,COFINS_CST,COFINS_VBC,COFINS_PCOFINS,COFINS_VCOFINS")] GDXMLITENS gDXMLITENS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gDXMLITENS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gDXMLITENS);
        }

        // GET: ItensDocumentosFiscais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLITENS = await _context.GDXMLITENS.SingleOrDefaultAsync(m => m.ID == id);
            if (gDXMLITENS == null)
            {
                return NotFound();
            }
            return View(gDXMLITENS);
        }

        // POST: ItensDocumentosFiscais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CHNFE,VERAPLIC,CPROD,XPROD,NCM,CFOP,UCOM,QCOM,VUNCOM,VPROD,CEANTRIB,UTRIB,QTRIB,VUNTRIB,INDTOT,CEAN,ICMS_ORI,ICMS_CST,ICMS_VBCSTRET,ICMS_VICMSSTRETI,IPI_CENQ,IPI_CST,PIS_CST,PIS_VBC,PIS_PPIS,PIS_VPIS,COFINS_CST,COFINS_VBC,COFINS_PCOFINS,COFINS_VCOFINS")] GDXMLITENS gDXMLITENS)
        {
            if (id != gDXMLITENS.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gDXMLITENS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GDXMLITENSExists(gDXMLITENS.ID))
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
            return View(gDXMLITENS);
        }

        // GET: ItensDocumentosFiscais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gDXMLITENS = await _context.GDXMLITENS
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gDXMLITENS == null)
            {
                return NotFound();
            }

            return View(gDXMLITENS);
        }

        // POST: ItensDocumentosFiscais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gDXMLITENS = await _context.GDXMLITENS.SingleOrDefaultAsync(m => m.ID == id);
            _context.GDXMLITENS.Remove(gDXMLITENS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GDXMLITENSExists(int id)
        {
            return _context.GDXMLITENS.Any(e => e.ID == id);
        }
    }
}
