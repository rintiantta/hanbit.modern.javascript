using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
namespace RSSParser.Controllers
{
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult GetRSS(int start, int count)
    {
        // XML을 가져옵니다.
        var xElement = XElement.Load("http://www.hanb.co.kr/sync/rss_newbook.xml");

        // 원하는 데이터를 선별합니다.
        var data = from item in xElement.Descendants("item")
                   select new
                   {
                       title = item.Element("title").Value,
                       link = item.Element("link").Value,
                       description = item.Element("description").Value,
                       author = item.Element("author").Value,
                       pubDate = item.Element("pubDate").Value
                   };

        // 데이터를 JSON으로 만듭니다.
        return Json(data.Skip(start * count + 1).Take(count), JsonRequestBehavior.AllowGet);
    }

public ActionResult GetRSSCount()
{
    // XML을 가져옵니다.
    var xElement = XElement.Load("http://www.hanb.co.kr/sync/rss_newbook.xml");
    var data = from item in xElement.Descendants("item") select item;

    // 데이터를 JSON으로 만듭니다.
    return Json(data.Count(), JsonRequestBehavior.AllowGet);
}
}
}
