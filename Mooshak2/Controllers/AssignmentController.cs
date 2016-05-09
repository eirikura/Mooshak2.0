using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AssignmentDetails(int assignmentID)
        {
            int ID = assignmentID;
            return View(ID);
        }

        public ActionResult CreateAssignment()
        {
            return View();
        }

        public ActionResult EditAssignment(int partsID)
        {
            int ID = partsID;
            return View(ID);
        }

        public ActionResult ShowCourseGrades(int courseID)
        {
            int ID = courseID;
            return View(ID);
        }

        public ActionResult ShowStudentGrades(int userID)
        {
            int ID = userID;
            return View(ID);
        }

        public ActionResult ShowAssignmentGrades(int assignmentID)
        {
            int ID = assignmentID;
            return View(ID);
        }
    }
}