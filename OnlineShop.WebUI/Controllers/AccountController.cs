using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineShop.Domain.Abstract;
using OnlineShop.WebUI.Models;

namespace OnlineShop.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private IAuthentication authentication;

        public AccountController(IAuthentication authentication)
        {
            this.authentication = authentication;

        }


        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl) //provera validnosti unetih podataka
        {
            if (ModelState.IsValid)
            {
                if (authentication.Authenticate(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("","Incorrect username and password");
                    return View();
                }
            }
            else
            {
                return View();

            }

            
        }
        public ActionResult Logout()  //LogOut dugme koje se nalazi na svim admin stranama i koje sluzi za odjavu
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Admin");
        }
    }
}