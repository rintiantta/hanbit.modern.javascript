using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Uplodify.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        
public ActionResult UploadFile()
{
    foreach (string file in Request.Files)
    {
        var fileBase = Request.Files[file];
        if (fileBase.ContentLength != 0)
        {
            string savedFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileName(fileBase.FileName));
            fileBase.SaveAs(savedFilename);
        }
    }
    return Content("OK");
}
    }
}
