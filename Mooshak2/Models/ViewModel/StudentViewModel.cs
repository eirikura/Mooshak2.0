using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        [Display(Name = "Fullname")]
        public string fullName { get; set; }

        /// <summary>
        /// Used to get ID´s of courses the student is assigned to.
        /// </summary>
        [Display(Name = "Course ID")]
        public int courseID { get; set; }

        /// <summary>
        /// Used to get ID´s of assignments the student is assigned to.
        /// </summary>
        [Display(Name = "Assignment ID")]
        public int assignmentID { get; set; }

        /// <summary>
        /// Shows a list of the students upcoming assignments.
        /// </summary>
        [Display(Name = "Upcoming Assignments")]
        public List<AssignmentViewModel> upcomingAssignments { get; set; }
    }
}