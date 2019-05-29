﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Domain.Abstract;

namespace OnlineShop.WebUI.Controllers
{
    public class ProductController : Controller  //Product kontroler koji je nasledjen iz klase Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}