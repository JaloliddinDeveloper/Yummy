﻿//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;

namespace Yummy.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
