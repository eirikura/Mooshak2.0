using Mooshak2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mooshak2.Models.ViewModel;
using Mooshak2.Models.Entities;

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
            var viewModel = _service.getAllCourses();

            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CourseDetails(int? courseID)
        {
            if (courseID != null)
            {
                int ID = courseID.Value;

                var viewModel = _service.getEditCourseByCourseID(ID);
                return View(viewModel);
            }
            return View();
        }

        /// <summary>
        /// Changes course details.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CourseDetails(int courseID)
        {
            var course = _service.getEditCourseByCourseID(courseID);

            if (course != null)
            {
                UpdateModel(course);
                _service.updateCourseInfo(course);
                return RedirectToAction("Index");
            }
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateCourse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCourse(CourseCreateViewModel newCourse)
        {
            if (ModelState.IsValid)
            {
                _service.addNewCourse(newCourse);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newCourse);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ActionResult AssignUsers()
        {

            List<SelectListItem> listCourses = new List<SelectListItem>();

            List<SelectListItem> listUsers = new List<SelectListItem>();

            listCourses = _service.getAllCoursesForAssigning();
            listUsers = _service.getAllUsersForAssigning();

            UsersAndCoursesViewModel viewModel = new UsersAndCoursesViewModel()
            {
                Courses = listCourses,
                Users = listUsers
            };

            return View(viewModel);
        }
    }
}