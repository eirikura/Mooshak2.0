using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class GradeViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime submissionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime assignmentDueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double grade { get; set; }
    }
}