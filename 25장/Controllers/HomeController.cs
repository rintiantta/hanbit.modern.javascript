using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxChat.Models;
using System.Threading;
using System.Diagnostics;

namespace AjaxChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddResult(string name, string message)
        {
            // 추가할 데이터를 생성합니다.
            var willInsert = new ChatMessage();
            willInsert.Name = name;
            willInsert.Message = message;

            // 데이터베이스에 데이터를 추가합니다.
            var db = new DataClassesDB();
            db.ChatMessages.InsertOnSubmit(willInsert);
            db.SubmitChanges();

            // 리턴합니다.
            return Content("SUCCESS");
        }

        public ActionResult GetList()
        {
            var db = new DataClassesDB();
            Debug.WriteLine("Connect");
            return Json(db.ChatMessages, JsonRequestBehavior.AllowGet);
        }
    }
}
