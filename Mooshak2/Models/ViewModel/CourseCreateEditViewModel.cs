using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class CourseCreateEditViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string courseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string courseDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int userID { get; set; }
    }
}