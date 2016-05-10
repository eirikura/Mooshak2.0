using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class TeacherViewModel
    {
        /// <summary>
        /// Full name of the teacher that is currently logged in.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// Used to get ID´s of courses the teacher is assigned to.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// Used to get ID´s of assignments the teacher is assigned to.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// Shows a list of the courses the current teacher is assigned to.
        /// </summary>
        public List<CourseCreateEditViewModel> activeCourses { get; set; }
    }
}