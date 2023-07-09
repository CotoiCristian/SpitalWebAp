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
    public class FisaMedicsController : Controller
    {
        private readonly IFisaMedicService _fisaMedicService;
        private readonly IRetetaMedicalaService _retetaMedicalaService;
        private readonly IPacientService _pacientService;
        private readonly IMedicService _medicService;

        public FisaMedicsController(IFisaMedicService fisaMedicService, IMedicService medicService, IRetetaMedicalaService retetaMedicalaService, IPacientService pacientService)
        {
            _fisaMedicService = fisaMedicService;
            _medicService = medicService;
            _pacientService = pacientService;
            _retetaMedicalaService = retetaMedicalaService;

        }

        // GET: Products
        // GET: FisaMedics1
        [Authorize]
        public IActionResult Index()
        {
            var fisa = _fisaMedicService.GetAll();
            return View(fisa);
        }
 
      
        // GET: FisaMedics/Details/5

        public IActionResult Details(int id)
        {
            var medic = _fisaMedicService.GetById(id);
            return View(medic);
            
        }


        // GET: FisaMedics/Create
        public IActionResult Create()
        {
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "Nume");
            ViewData["PacientId"] = new SelectList(_pacientService.GetAll(), "PacientId", "NumePacient");
            ViewData["RetetaMedicalaId"] = new SelectList(_retetaMedicalaService.GetAll(), "RetetaMedicalaId", "Denumire");
            return View();
        }


        // POST: FisaMedics1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FisaMedicId,Name,DataInternare,DataExternare,MedicId,PacientId,RetetaMedicalaId")] FisaMedic fisaMedic)
        {
            if (ModelState.IsValid)
            {
                _fisaMedicService.Add(fisaMedic);
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "MedicId", fisaMedic.MedicId);
            ViewData["PacientId"] = new SelectList(_pacientService.GetAll(), "PacientId", "PacientId", fisaMedic.PacientId);
            ViewData["RetetaMedicalaId"] = new SelectList(_retetaMedicalaService.GetAll(), "RetetaMedicalaId", "RetetaMedicalaId", fisaMedic.RetetaMedicalaId);
            return View(fisaMedic);
        }

        // GET: FisaMedics1/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || _fisaMedicService == null)
            {
                return NotFound();
            }

            var fisaMedic = _fisaMedicService.GetById((int)id);
            if (fisaMedic == null)
            {
                return NotFound();
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "Nume", fisaMedic.MedicId);
            ViewData["PacientId"] = new SelectList(_pacientService.GetAll(), "PacientId", "NumePacient", fisaMedic.PacientId);
            ViewData["RetetaMedicalaId"] = new SelectList(_retetaMedicalaService.GetAll(), "RetetaMedicalaId", "Denumire", fisaMedic.RetetaMedicalaId);
            return View(fisaMedic);
        }

        // POST: FisaMedics1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("FisaMedicId,Name,DataInternare,DataExternare,MedicId,PacientId,RetetaMedicalaId")] FisaMedic fisaMedic)
        {
          
            if (id != fisaMedic.FisaMedicId)
            {
             return NotFound();
            }

            if (ModelState.IsValid)
            {
             _fisaMedicService.Update(fisaMedic);
              return RedirectToAction(nameof(Index));
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "MedicId", fisaMedic.MedicId);
            ViewData["PacientId"] = new SelectList(_pacientService.GetAll(), "PacientId", "PacientId", fisaMedic.PacientId);
            ViewData["RetetaMedicalaId"] = new SelectList(_retetaMedicalaService.GetAll(), "RetetaMedicalaId", "RetetaMedicalaId", fisaMedic.RetetaMedicalaId);
            return View(fisaMedic);
        }

        // GET: FisaMedics1/Delete/5
        public IActionResult Delete(int id)
        {
          
            var fisaMedic = _fisaMedicService.GetById(id);
            if (fisaMedic == null)
            {
                return NotFound();
            }

            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "MedicId", fisaMedic.MedicId);
            ViewData["PacientId"] = new SelectList(_pacientService.GetAll(), "PacientId", "PacientId", fisaMedic.PacientId);
            ViewData["RetetaMedicalaId"] = new SelectList(_retetaMedicalaService.GetAll(), "RetetaMedicalaId", "RetetaMedicalaId", fisaMedic.RetetaMedicalaId);
            return View(fisaMedic);
        }

        // POST: FisaMedics1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
           
            var fisaMedic =  _fisaMedicService.GetById(id);
            if (fisaMedic != null)
            {
                _fisaMedicService.Delete(fisaMedic);
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "MedicId", fisaMedic?.MedicId);
            ViewData["PacientId"] = new SelectList(_pacientService.GetAll(), "PacientId", "PacientId", fisaMedic?.PacientId);
            ViewData["RetetaMedicalaId"] = new SelectList(_retetaMedicalaService.GetAll(), "RetetaMedicalaId", "RetetaMedicalaId", fisaMedic?.RetetaMedicalaId);
            
            return RedirectToAction(nameof(Index));
        }

       
    }
}
        