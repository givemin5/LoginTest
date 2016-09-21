using LoginTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginTest.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Account == "givemin5" && model.Password.Equals("123"))
                    ViewBag.Message = "登錄成功";
                else
                    ViewBag.Message = "登陸失敗";
            }
            return View();

        }
    }
}