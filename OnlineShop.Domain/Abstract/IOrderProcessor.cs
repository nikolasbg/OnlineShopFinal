using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Domain.Abstract
{
   public interface IOrderProcessor
   {
       void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
   }
}
