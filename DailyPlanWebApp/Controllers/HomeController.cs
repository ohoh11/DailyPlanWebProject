using DailyPlanWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DailyPlanWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult GetPeople(string usercode)
        {
            JsonResult jr = new JsonResult();
            jr.Data = GetPeopleName(usercode);// 泛型集合
            return jr;
        }

        private List<PeopleInfo> GetPeopleName(string usercode)
        {
            List<PeopleInfo> list = new List<PeopleInfo>();

            //   string sql = @" select name from info1 where name like '" + usercode + "%' ";
            //   list = MyDBHelper.My_Test_ODBC_Link(sql);

            PeopleInfo iu = new PeopleInfo();
            if (usercode.Equals("212"))
            {
                iu.PeopleName = "212的名字返回了";
            }
            if (usercode.Equals("213"))
            {
                iu.PeopleName = "213的名字返回了";
            }

            list.Add(iu);

            return list;
        }




    }
}