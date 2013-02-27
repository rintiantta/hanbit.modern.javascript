using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAXProductManage.Models;

namespace AJAXProductManage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProductList()
        {
            var adventureWorksDB = new AdventureWorksDB();
            return Json(adventureWorksDB.Product, JsonRequestBehavior.AllowGet);
        }

        public FileContentResult GetProductImage(int id)
        {
            var adventureWorksDB = new AdventureWorksDB();
            var willReturn = adventureWorksDB.Product.Single(x => x.ProductID == id);
            return File(willReturn.ThumbNailPhoto.ToArray(), "image/gif");
        }

        public ActionResult GetTotalProductCount()
        {
            var adventureWorksDB = new AdventureWorksDB();
            return Content(adventureWorksDB.Product.Count().ToString());
        }

        public ActionResult GetPagingProductList(int nowPage, int perPage)
        {
            var adventureWorksDB = new AdventureWorksDB();
            var data = adventureWorksDB.Product.Skip(nowPage * perPage).Take(perPage);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
