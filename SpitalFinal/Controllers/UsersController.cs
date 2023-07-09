using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpitalFinal.Models;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Controllers
{
    public class UsersController : Controller
    {
        private readonly IIdentityUserService _productService;

        public UsersController(IIdentityUserService productService)
        {
            _productService = productService;
        }

        // GET: Products
       
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
        public IActionResult Create(IdentityUser product)
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

        public IActionResult Edit(string id, IdentityUser product)
        {
            if (id != product.Id)
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

