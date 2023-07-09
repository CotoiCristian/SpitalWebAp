using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Services;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Controllers
{
    public class Investigaties1Controller : Controller
    {
        private readonly IInvestigatieService _investigatieService;
        private readonly IFisaMedicService _fisaMedicService;
        public Investigaties1Controller(IInvestigatieService investigatieService, IFisaMedicService fisaMedicService)
        {
            _investigatieService = investigatieService;
            _fisaMedicService = fisaMedicService;
        }

        // GET: Investigaties1

        [Authorize(Roles = "Angajat")]
        public IActionResult Index()
        {
            var spitalContext = _investigatieService.GetAll();
            return View(spitalContext);
        }

        // GET: Investigaties1/Details/5
        
        public IActionResult Details(int id)
        {


            // var investigatie = await _context.Investigaties
            //     .Include(i => i.FisaMedic)
            //     .FirstOrDefaultAsync(m => m.InvestigatieId == id);
            
            var medic = _investigatieService.GetById(id);
            ViewData["FisaMedicId"] = new SelectList(_fisaMedicService.GetAll(), "FisaMedicId", "Name");
            return View(medic);

        }

            // GET: Investigaties1/Create
        public IActionResult Create()
        {
            ViewData["FisaMedicId"] = new SelectList(_fisaMedicService.GetAll(), "FisaMedicId", "Name");
            return View();
        }

        // POST: Investigaties1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("InvestigatieId,Rezultat,datazilei,FisaMedicId")] Investigatie investigatie)
        {
            if (ModelState.IsValid)
            {
                _investigatieService.Add(investigatie);
             
                return RedirectToAction(nameof(Index));
            }
            ViewData["FisaMedicId"] = new SelectList(_fisaMedicService.GetAll(), "FisaMedicId", "FisaMedicId", investigatie.FisaMedicId);
            return View(investigatie);
        }

        // GET: Investigaties1/Edit/5
        public IActionResult Edit(int id)
        {
       

            var medic = _investigatieService.GetById(id);
            if (medic == null)
            {
                return NotFound();
            }
            ViewData["FisaMedicId"] = new SelectList(_fisaMedicService.GetAll(), "FisaMedicId", "Name", medic.FisaMedicId);
            return View(medic);
        }

        // POST: Investigaties1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("InvestigatieId,Rezultat,datazilei,FisaMedicId")] Investigatie investigatie)
        {
            if (id != investigatie.InvestigatieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
             
                    _investigatieService.Update(investigatie);
        
                return RedirectToAction(nameof(Index));
            }
            ViewData["FisaMedicId"] = new SelectList(_fisaMedicService.GetAll(), "FisaMedicId", "FisaMedicId", investigatie.FisaMedicId);
            return View(investigatie);
        }

        // GET: Investigaties1/Delete/5
        public IActionResult Delete(int id)
        {


            var fisa = _investigatieService.GetById(id);
            if (fisa == null)
            {
                return NotFound();
            }
            ViewData["FisaMedicId"] = new SelectList(_fisaMedicService.GetAll(), "FisaMedicId", "Name", fisa.FisaMedicId);
            
            return View(fisa);
        }

        // POST: Investigaties1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            var investigatie = _investigatieService.GetById(id);
            if (investigatie == null)
            {
                return NotFound();
            }
            ViewData["SectieId"] = new SelectList(_fisaMedicService.GetAll(), "SectieId", "SectieId", investigatie.FisaMedicId);
            _investigatieService.Delete(investigatie);


            return RedirectToAction(nameof(Index));
        }

        
    }
}
