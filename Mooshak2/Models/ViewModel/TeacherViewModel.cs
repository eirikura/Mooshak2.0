using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// Teachers frontpage. Shows a list of courses the teacher is currently attending to.
    /// Home, Courses, Grades and Settings buttons should be displayed on the frontpage.
    /// </summary>
    public class TeacherViewModel
    {
        /// <summary>
        /// Full name of the teacher that is currently logged in.
        /// </summary>
        [Required]
        [Display(Name = "Fullname")]
        public string fullName { get; set; }

        /// <summary>
        /// Used to get ID´s of courses the teacher is assigned to.
        /// </summary>
        [Display(Name = "CourseID")]
        public int courseID { get; set; }

        /// <summary>
        /// Used to get ID´s of assignments the teacher is assigned to.
        /// </summary>
        [Display(Name = "AssignmentID")]
        public int assignmentID { get; set; }

        /// <summary>
        /// Shows a list of the courses the current teacher is assigned to.
        /// </summary>
<<<<<<< HEAD
      //  public List<CourseCreateEditViewModel> activeCourses { get; set; }
=======
        [Display(Name = "ActiveCourses")]
        public List<CourseViewModel> activeCourses { get; set; }
>>>>>>> TeacherView
    }
}