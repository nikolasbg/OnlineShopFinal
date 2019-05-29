using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Domain.Entities;

namespace OnlineShop.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}