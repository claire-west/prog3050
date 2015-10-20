﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veil.DataModels.Models;

namespace Veil.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        //Game List report
        [HttpGet]
        public ActionResult GameList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GameList(DateTime start, DateTime? end)
        {
            end = end ?? DateTime.Now;

            return View();
        }

        //Game Detail report
        [HttpGet]
        public ActionResult GameDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GameDetail(DateTime start, DateTime? end)
        {
            end = end ?? DateTime.Now;

            return View();
        }

        //Member List report
        [HttpGet]
        public ActionResult MemberList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MemberList(DateTime start, DateTime? end)
        {
            end = end ?? DateTime.Now;

            return View();
        }

        //Member Detail report
        [HttpGet]
        public ActionResult MemberDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MemberDetail(DateTime start, DateTime? end)
        {
            end = end ?? DateTime.Now;

            return View();
        }

        //Wishlist report
        [HttpGet]
        public ActionResult Wishlist()
        {
            return View();
        }

        //Sales report
        [HttpGet]
        public ActionResult Sales()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sales(DateTime start, DateTime? end)
        {
            end = end ?? DateTime.Now;

            return View();
        }
    }
}