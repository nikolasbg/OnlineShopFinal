using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Concrete
{
   public class EmailSettings
    {
        public string MailToAddress = "urosivanovic@gmail.com";
        public string MailFromAddress = "urosivanovic@gmail.com";
        public bool UseSsl = true;
        public string Username = "urosivanovic@gmail.com";
        public string Password = "hooligan05"; 
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
