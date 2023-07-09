using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Controllers
{
    public class ProgramaresController : Controller
    {
        private readonly IProgramareService _programareService;
        private readonly IMedicService _medicService;
        private readonly IProgramLucruService _programLucruService;

        public ProgramaresController(IProgramareService programareService, IMedicService medicService, IProgramLucruService programLucruService)
        {
            _programareService = programareService;
            _medicService = medicService;
            _programLucruService = programLucruService;
        }

        // GET: Programares1
        [Authorize]
        public IActionResult Index()
        {
            var spitalContext = _programareService.GetAll();
            return View(spitalContext);
        }

        // GET: Programares1/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _programareService.GetById((int)id) == null)
            {
                return NotFound();
            }

            var programare = _programareService.GetById((int)id);
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "Nume");
            ViewData["ProgramLucruId"] = new SelectList(_programLucruService.GetAll(), "ProgramLucruId", "DataLibera");

            if (programare == null)
            {
                return NotFound();
            }

            return View(programare);
        }

        // GET: Programares1/Create
        public IActionResult Create()
        {
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "Nume");
            ViewData["ProgramLucruId"] = new SelectList(_programLucruService.GetAllNeutilizate(), "ProgramLucruId", "DataLibera");
 
           return View();
        }


        // POST: Programares1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProgramareId,ProgramLucruId,nume,Varsta,sex,MedicId,DataProgramari")] Programare programare)
        {
            if (ModelState.IsValid)
            {
                _programareService.Add(programare);

                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "MedicId", programare.MedicId);
            ViewData["ProgramLucruId"] = new SelectList(_programLucruService.GetAll(), "ProgramLucruId", "ProgramLucruId", programare.ProgramLucruId);
            return View(programare);
        }

        // GET: Programares1/Edit/5
        public IActionResult Edit(int id)
        {
            if (_programareService.GetById(id) == null)
            {
                return NotFound();
            }

            var programare = _programareService.GetById(id);
            if (programare == null)
            {
                return NotFound();
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "Nume", programare.MedicId);
            ViewData["ProgramLucruId"] = new SelectList(_programLucruService.GetAll(), "ProgramLucruId", "DataLibera", programare.ProgramLucruId);
            return View(programare);
        }

        // POST: Programares1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ProgramareId,ProgramLucruId,nume,Varsta,sex,MedicId,DataProgramari")] Programare programare)
        {
            if (id != programare.ProgramareId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _programareService.Update(programare);
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "MedicId", programare.MedicId);
            ViewData["ProgramLucruId"] = new SelectList(_programLucruService.GetAll(), "ProgramLucruId", "ProgramLucruId", programare.ProgramLucruId);
            return View(programare);
        }

        // GET: Programares1/Delete/5
        public IActionResult Delete(int id)
        {
            var programare = _programareService.GetById(id);

            if (programare == null)
            {
                return NotFound();
            }
            ViewData["MedicId"] = new SelectList(_medicService.GetAll(), "MedicId", "Nume", programare.MedicId);
            ViewData["ProgramLucruId"] = new SelectList(_programLucruService.GetAll(), "ProgramLucruId", "DataLibera", programare.ProgramLucruId);

            return View(programare);
        }

        // POST: Programares1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            var programare = _programareService.GetById(id);
            if (programare == null)
            {
                return NotFound();
            }

            _programareService.Delete(programare);



            return RedirectToAction(nameof(Index));
        }


    }
}
