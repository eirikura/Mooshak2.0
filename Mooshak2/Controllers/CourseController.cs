﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CourseDetails(int courseID)
        {
            int ID = courseID;
            return View(ID);
        }

        public ActionResult CreateCourse()
        {
            return View();
        }

        public ActionResult EditCourse(int courseID)
        {
            int ID = courseID;
            return View(ID);
        }

        public ActionResult AssignUsers(int courseID)
        {
            int ID = courseID;
            return View(ID);
        }
           

    }
}