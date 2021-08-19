using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace szw.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BLL.UsersBLL bll = new BLL.UsersBLL();
            Model.Users u = new Model.Users { ID = 1 };

            var m = bll.GetModel(u);

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
    }
}