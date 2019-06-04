using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User name is required")] //obavezno polje koje ne sme da se ostavi prazno
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50,MinimumLength = 6)]  //obavezno polje sa minimum 6 karaktera i maksimalno 50
        public string Password { get; set; }
    }
}