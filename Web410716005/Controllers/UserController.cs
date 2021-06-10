using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410716005.ViewModels;

namespace Web410716005.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }
        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        {
            if (ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}