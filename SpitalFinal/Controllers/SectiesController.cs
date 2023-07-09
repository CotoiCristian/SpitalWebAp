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
using static System.Collections.Specialized.BitVector32;

namespace SpitalFinal.Controllers
{
    public class SectiesController : Controller
    {
        private readonly ISectieService _productService;

        public SectiesController(ISectieService productService)
        {
            _productService = productService;
        }

        // GET: Products
        [Authorize]
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        // GET: Products/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Details()
        {
            var products = _productService.GetAll();
            return View(products);
            
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public IActionResult Details(Sectie sectie)
        //{
        //    var products = _productService.GetAll();
        //    return View(products);

        //}

        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sectie product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public IActionResult Edit(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public IActionResult Edit(int id, Sectie product)
        {
            if (id != product.SectieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _productService.Update(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.Delete(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
