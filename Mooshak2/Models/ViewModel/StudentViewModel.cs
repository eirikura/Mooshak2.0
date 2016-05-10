using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// Students frontpage. Shows a list of upcoming assignments.
    /// Home, Assignments, Grades and Settings buttons should be displayed on the frontpage.
    /// </summary>
    public class StudentViewModel
    {
        /// <summary>
        /// Full name of the student that is currently logged in.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// Used to get ID´s of courses the student is assigned to.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// Used to get ID´s of assignments the student is assigned to.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// Shows a list of the students upcoming assignments.
        /// </summary>
        public List<AssignmentViewModel> upcomingAssignments { get; set; }
    }
}