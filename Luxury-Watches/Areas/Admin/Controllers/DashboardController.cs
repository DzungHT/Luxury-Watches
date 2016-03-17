using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Luxury_Watches.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            if (Session["User"] == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                return View();
            }
        }
    }
}