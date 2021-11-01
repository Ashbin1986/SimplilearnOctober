using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace November01MVCApplication.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFileData(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    //string filePathToSave = Server.MapPath("~/Documents/") + fileName;
                    //file.SaveAs(filePathToSave);
                    string filePath = Path.Combine(Server.MapPath("~/Documents"), fileName);
                    file.SaveAs(filePath);
                    return View();

                }
                else
                {
                    // error message
                    return View();
                }
            }
            catch
            {
                return View("Error");

            }
        }
    }
}