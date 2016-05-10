using Mooshak2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentsService _service = new AssignmentService();
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
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public ActionResult AssignmentDetails(int assignmentID)
        {
            var viewModel = _service.getAssignmentByAssignmentID(assignmentID);
            
            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateAssignment()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public ActionResult EditAssignment(int partsID)
        {
            var viewModel = _service.getAssignmentByPartsID(partsID);

            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ActionResult ShowCourseGrades(int courseID)
        {
            int id = courseID;
            return View(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ActionResult ShowStudentGrades(int userID)
        {
            int id = userID;
            return View(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public ActionResult ShowAssignmentGrades(int assignmentID)
        {
            int id = assignmentID;
            return View(id);
        }
    }
}