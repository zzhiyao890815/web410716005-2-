﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410716005.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string name,string account,string password)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (account.IsNullOrWhiteSpace())
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (password.IsNullOrWhiteSpace())
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            if (!name.IsNullOrWhiteSpace() && !account.IsNullOrWhiteSpace() && !password.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功";
            }
            return View();
        }
    }
}