﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwebApp.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            Exception e = new Exception("Invalid Controller or/and Action Name");
            HandleErrorInfo handleErrorInfo = new HandleErrorInfo(e,"Unknown","Unknown");
            return View("Error",handleErrorInfo);
        }
    }
}