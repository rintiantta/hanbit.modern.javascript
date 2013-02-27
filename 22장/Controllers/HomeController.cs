using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WithDatabase.Models;

namespace WithDatabase.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeopleJSON()
        {
            var peopleDB = new PeopleDB();
            return Json(peopleDB.People, JsonRequestBehavior.AllowGet);
        }
        public ActionResult InsertPerson(string name, string gender, string region, string bloodType)
        {
            // 테이블에 입력할 데이터를 만듭니다.
            var willAdd = new People();
            willAdd.Name = name;
            willAdd.Gender = gender;
            willAdd.Region = region;
            willAdd.BloodType = bloodType;
            try
            {
                // 테이블에 데이터를 집어넣습니다.
                var peopleDB = new PeopleDB();
                peopleDB.People.InsertOnSubmit(willAdd);
                peopleDB.SubmitChanges();
                return Content("INSERT SUCCESS");
            }
            catch (Exception exception)
            {
                // 데이터 입력에 실패할 경우
                return HttpNotFound();
            }
        }
public ActionResult DeletePerson(int id)
{
    try
    {
        // 삭제할 데이터를 선택합니다.
        var peopleDB = new PeopleDB();
        var willDelete = peopleDB.People.Single(x => x.Id == id);

            
        // 삭제합니다.
        peopleDB.People.DeleteOnSubmit(willDelete);
        peopleDB.SubmitChanges();
        return Content("DELETE SUCCESS");
    }
    catch (Exception excception)
    {
        return HttpNotFound();
    }
}
public ActionResult UpdatePerson(int id, string region)
{
    try
    {
        // 수정할 데이터를 선택합니다.
        var peopleDB = new PeopleDB();
        var willUpdate = peopleDB.People.Single(x => x.Id == id);

        // 수정합니다.
        willUpdate.Region = region;
        peopleDB.SubmitChanges();
        return Content("UPDATE SUCCESS");
    }
    catch (Exception exception)
    {
        return HttpNotFound();
    }
}

    }
}
