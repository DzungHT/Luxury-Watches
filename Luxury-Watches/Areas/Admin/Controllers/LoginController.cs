
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Luxury_Watches.Areas.Admin.Models;

namespace Luxury_Watches.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if ("admin".Equals(username) && "123456".Equals(password))
            {
                Session["User"] = "Admin";
                return Redirect("/Admin/Dashboard");
            }
            else
            {
                Error e = new Error() { Type = ErrorType.FailedLogin, Msg = "Sai tên đăng nhập hoặc mật khẩu!" };
                return PartialView(e);
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return Redirect("/Admin/Login");
        }
    }
}