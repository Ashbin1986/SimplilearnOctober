using MVCMultipleActions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMultipleActions.Controllers
{
   
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View(new UserLogin());
        }
      
        public ActionResult ValidateUser(UserLogin userLogin)
        {
            if(userLogin.UserName =="admin" && userLogin.Password=="12345")
            {
                Session["UserID"] = Guid.NewGuid();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid");
                return RedirectToAction("Index");
            }
        }
    }
}