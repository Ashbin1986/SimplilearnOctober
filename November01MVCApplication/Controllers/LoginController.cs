using November01MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace November01MVCApplication.Controllers
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
            return View();
        }
    }
}