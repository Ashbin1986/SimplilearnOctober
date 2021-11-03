using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMultipleActions.Controllers
{
    public class PrintController : Controller
    {
        // GET: Print
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowMultipleButton(Name = "action", Argument = "ExportToExcel")]
        public ActionResult ExportExcel()
        {
            ViewBag.Message = "You have clicked on Export to excel";

            return View();
        }

        [HttpPost]
        [AllowMultipleButton(Name = "action", Argument = "ExportToCsv")]
        public ActionResult ExportCSV()
        {
            ViewBag.Message = "You have clicked on Export to csv";

            return View();
        }

        [HttpPost]
        [AllowMultipleButton(Name = "action", Argument = "ExportToPdf")]
        public ActionResult ExportPDF()
        {
            ViewBag.Message = "You have clicked on Export to pdf";

            return View();
        }
    }
}