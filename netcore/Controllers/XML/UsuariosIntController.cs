using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Data;
using MulltiplaJML.Models;
using MulltiplaJML.Models.AccountViewModels;
using MulltiplaJML.Services;

namespace MulltiplaJML.Controllers.XML
{
    public class UsuariosIntController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        public UsuariosIntController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _context = context;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        // GET: UsuariosInt
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuariosERP.ToListAsync());
        }

        // GET: UsuariosInt/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuariosERP = await _context.UsuariosERP
                .SingleOrDefaultAsync(m => m.Id == id);
            if (usuariosERP == null)
            {
                return NotFound();
            }

            return View(usuariosERP);
        }

        // GET: UsuariosInt/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuariosInt/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,Email,Senha,CodMatriz,CodFilial,Ativo")] UsuariosERP usuariosERP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuariosERP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuariosERP);
        }

        // GET: UsuariosInt/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuariosERP = await _context.UsuariosERP.SingleOrDefaultAsync(m => m.Id == id);
            if (usuariosERP == null)
            {
                return NotFound();
            }
            return View(usuariosERP);
        }

        // POST: UsuariosInt/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Email,Senha,CodMatriz,CodFilial,Ativo")] UsuariosERP usuariosERP)
        {
            if (id != usuariosERP.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuariosERP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuariosERPExists(usuariosERP.Id))
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
            return View(usuariosERP);
        }

        // GET: UsuariosInt/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuariosERP = await _context.UsuariosERP
                .SingleOrDefaultAsync(m => m.Id == id);
            if (usuariosERP == null)
            {
                return NotFound();
            }

            return View(usuariosERP);
        }

        // POST: UsuariosInt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuariosERP = await _context.UsuariosERP.SingleOrDefaultAsync(m => m.Id == id);
            _context.UsuariosERP.Remove(usuariosERP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuariosERPExists(int id)
        {
            return _context.UsuariosERP.Any(e => e.Id == id);
        }
    }
}
