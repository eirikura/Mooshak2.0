using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}