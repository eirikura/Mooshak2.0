using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// This view will 
    /// </summary>
    public class AssignmentViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string assigmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string partsDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime assignmentDueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime submissionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime submissionTime { get; set; }
    }
}