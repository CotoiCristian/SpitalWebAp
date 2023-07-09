
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using NuGet.ProjectModel;
using SpitalFinal.Models;
using SpitalFinal.Services.Interfaces;


namespace SpitalFinal.Controllers
{
    public class MedicsController : Controller
    {
        private readonly IMedicService _medicService;

        private readonly ISectieService _sectieService;
        // readonly SpitalContext _context;

        public MedicsController(IMedicService productService, ISectieService sectieService  )
        {
            _sectieService = sectieService;
            _medicService = productService;
           // _context = context;
        }

        // GET: Products
        [Authorize]
        public IActionResult Index()
        {
                var products = _medicService.GetAll();
                return View(products);
        }
        public IActionResult Details(int id)
        {
            var medic = _medicService.GetByIdDetils(id);  

            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "NumeSectie");

            return View(medic);
        }
        //GET: Products/Create
        public IActionResult Create()
        {
          
            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "NumeSectie");
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MedicId,Nume,Specializare,DataNastere,Telefon,Varsta,SectieId")] Medic medic)
        {
            if (ModelState.IsValid)
            {
                _medicService.Add(medic);
              
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "SectieId", medic.SectieId);
            return View(medic);
        }
        // GET: Products/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null || _sectieService == null)
            {
                return NotFound();
            }

            var medic =  _medicService.GetById(id);
            if (medic == null)
            {
                return NotFound();
            }
            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "NumeSectie", medic.SectieId);
            return View(medic);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("MedicId,Nume,Specializare,DataNastere,Telefon,Varsta,SectieId")] Medic medic)
        {
            if (id != medic.MedicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                    _medicService.Update(medic);

                return RedirectToAction(nameof(Index));
            }
            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "SectieId", medic.SectieId);
            return View(medic);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int id)
        {
            var product = _medicService.GetByIdDetils(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "SectieId", product.SectieId);
            return View(product);

        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
        
            var product = _medicService.GetByIdDetils(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["SectieId"] = new SelectList(_sectieService.GetAll(), "SectieId", "SectieId", product.SectieId);
            _medicService.Delete(product);

            return RedirectToAction(nameof(Index));
        }
    }
}