using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;
using HellojQGrid.Models;

namespace HellojQGrid.Controllers
{
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

public ActionResult GetBooks(int page, int rows, string sidx, string sord)
{
    // 매개 변수를 처리합니다.
    if (sidx == "") { sidx = "1"; }
    else { sidx = sidx.Replace("grid_", ""); }

    // 데이터베이스에서 데이터를 가져옵니다.
    DataClassesDB db = new DataClassesDB();
    var Query = db.Books.OrderBy(sidx + " " + sord);

// 검색인지 확인합니다.
if (Request["_search"]=="true")
{
    // 검색이라면 검색 키워드에 해당하는 내용만 가져옵니다.
    var searchField = Request["searchField"];
    var searchString = Request["searchString"];
    var query = "";
    if (searchField == "Id")
    {
        Query = Query.Where(searchField + "=" + searchString);
    }
    else
    {
        Query = Query.Where(searchField + ".Contains(@0)", searchString);
    }
}

    // XML을 만드는데 사용하는 변수를 선언합니다.
    var totalRecords = Query.Count();
    var totalPages = Math.Ceiling((double)totalRecords / rows);
    var start = rows * page - rows;
    var books = Query.Skip(start).Take(rows);

    // XML을 만듭니다.
    var willReturn = "";
    willReturn += "<rows>";
    willReturn += "    <page>" + page + "</page>";
    willReturn += "    <total>" + totalPages + "</total>";
    willReturn += "    <records>" + totalRecords + "</records>";

    foreach (var item in books)
    {
        willReturn += "<row>";
        willReturn += "    <cell>" + item.Id + "</cell>";
        willReturn += "    <cell>" + item.Name + "</cell>";
        willReturn += "    <cell>" + item.Author + "</cell>";
        willReturn += "    <cell>" + item.Publisher + "</cell>";
        willReturn += "    <cell>" + item.Isbn + "</cell>";
        willReturn += "    <cell>" + item.Page + "</cell>";
        willReturn += "    <cell>" + item.PublishDate + "</cell>";
        willReturn += "</row>";
    }
    willReturn += "</rows>";

    // 리턴합니다.
    return Content(willReturn, "text/xml");
}

public ActionResult EditBooks(string oper)
{
    // 데이터베이스에서 데이터를 가져옵니다.
    DataClassesDB db = new DataClassesDB();

    // 각각에 맞게 처리합니다.
    if (oper == "add")
    {
        // 책을 추가합니다.
        Books books = new Books();
        
        books.Name = Request["Name"];
        books.Author = Request["Author"];
        books.Publisher = Request["Publisher"];
        books.Isbn = Request["Isbn"];
        books.Page = Request["Page"];
        books.PublishDate = DateTime.Now;

        db.Books.InsertOnSubmit(books);
        db.SubmitChanges();
    }
    else if (oper == "edit")
    {
        // 책을 변경합니다.
        var id = int.Parse(Request["Id"]);
        var willUpdate = db.Books.Single(x => x.Id == id);
        willUpdate.Name = Request["Name"];
        willUpdate.Author = Request["Author"];
        willUpdate.Publisher = Request["Publisher"];
        willUpdate.Isbn = Request["Isbn"];
        willUpdate.Page = Request["Page"];
        willUpdate.PublishDate = DateTime.Now;

        db.SubmitChanges();
    }
    else if (oper == "del")
    {
        // 책을 삭제합니다.
        var id = int.Parse(Request["Id"]);
        var willDelete = db.Books.Single(x => x.Id == id);
        db.Books.DeleteOnSubmit(willDelete);
    }
    return Content("SUCCESS");
}
}
}
