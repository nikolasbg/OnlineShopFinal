using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities
{
    public class User
    {
        [Key]
        public string UserId { get; set; } // Entiti koristi Id u usreid kao okidac za primarni kljuc
        public string Password { get; set; }
    }
}
