using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Domain.Abstract;
using OnlineShop.Domain.Entities;

namespace OnlineShop.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            return View(repository.Products);
        }

        public ViewResult Create()
        {
            return View(new Product());
        }
        [HttpPost]
        public ActionResult Create(Product product)  //dodavanje novog proizvoda
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Nesto nije u redu sa proizvodom
                return View(product);
            }
        }
        public ViewResult Edit(int productId) //Editovanje proizvoda
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == productId);

            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product) //Editovanje proizvoda
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Nesto nije u redu sa unetim vrednostima
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }

    }
}