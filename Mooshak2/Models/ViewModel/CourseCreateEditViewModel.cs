using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The course creation and editing view model is responsible for creating and editing courses.
    /// It allows for creating and editing courses and also assigning users to courses.
    /// Access only granted to administrators.
    /// </summary>
    public class CourseCreateEditViewModel
    {
        /// <summary>
        /// Shows the courses name.
        /// </summary>
        public string courseName { get; set; }

        /// <summary>
        /// Shows the courses description.
        /// </summary>
        public string courseDescription { get; set; }

        /// <summary>
        /// Shows the courses ID.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// Shows the users ID.
        /// </summary>
        public int userID { get; set; }
    }
}