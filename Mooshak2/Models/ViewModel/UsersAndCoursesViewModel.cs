using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Models.ViewModel
{
    public class UsersAndCoursesViewModel
    {
        /// <summary>
        /// The user ID number used to connect to a course ID number.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// The course ID number used to connect to a user ID number.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// The username
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// The courses name
        /// </summary>
        public string courseName { get; set; }

        public ICollection<string> SelectedCourse { get; set; }
        public ICollection<SelectListItem> Courses { get; set; }

        public ICollection<string> SelectedUsers { get; set; }
        public ICollection<SelectListItem> Users { get; set; }
    }
}