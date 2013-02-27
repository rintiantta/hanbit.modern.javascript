using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyFirstStringAction()
        {
            return Content("<h1>Hello ASP.NET MVC</h1>");
        }

        public ActionResult ActionWithData()
        {
            var name = Request["name"];
            var age = Request["age"];

            return Content("<h1>" + name + ":" + age + "</h1>");
        }

        public ActionResult MyFirstJsonAction()
        {
            var willReturn = new { name = "윤인성", gender = "남자", part = "세컨드기타" };
            return Json(willReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MyFirstXMLAction()
        {
            var willReturn = "";
            willReturn += "<people>";
            willReturn += "    <person>";
            willReturn += "        <name>윤인성</name>";
            willReturn += "        <gender>남자</gender>";
            willReturn += "        <part>기타</part>";
            willReturn += "    </person>";
            willReturn += "    <person>";
            willReturn += "        <name>연하진</name>";
            willReturn += "        <gender>여자</gender>";
            willReturn += "        <part>기타</part>";
            willReturn += "    </person>";
            willReturn += "</people>";

            return Content(willReturn, "text/xml");
        }

    }
}
