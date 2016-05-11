using Mooshak2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Controllers
{
    public class CoursesController : Controller
    {
        private CoursesService _service = new CoursesService();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ActionResult CourseDetails(int courseID)
        {
            var viewModel = _service.getCourseByCourseID(courseID);

            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateCourse()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ActionResult EditCourse(int courseID)
        {
            var viewModel = _service.getCourseByCourseID(courseID);

            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ActionResult AssignUsers(int courseID)
        {
            int id = courseID;
            return View(id);
        }
           

    }
}