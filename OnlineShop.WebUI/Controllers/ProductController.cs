using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Domain.Abstract;
using OnlineShop.WebUI.Models;

namespace OnlineShop.WebUI.Controllers
{
    public class ProductController : Controller  //Product kontroler koji je nasledjen iz klase Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 4; // postavljamo da cemo imati 4 artikla po strani

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category,int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {


                Products = repository.Products //postavljamo da se po difoltu krece od 1 strane i onda ne oduzimamo nista posto bi onda znacilo da smo na nultoj strani bez artikala...
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? //prebrojava broj artikala u kategoriji i uklanja visak stranica ako se uslov ispunjava da ima odgovarajuci broj artikala po stranici 
                        repository.Products.Count() :
                        repository.Products.Where(p => p.Category == category).Count()

                },
                CurrentCategory = category
                
            };

            return View(model);



        }
    }
}