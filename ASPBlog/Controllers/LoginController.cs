﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPBlog.Controllers
{
    public class LoginController : Controller
    {
       public ActionResult Login()
        {
            return Content("Login!");
        }

    }
}