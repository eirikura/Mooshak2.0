using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The grade view model is responsible for showing students grades. It is mainly used
    /// by students but teachers are also welcome to check students grades.
    /// </summary>
    public class GradeViewModel
    {
        /// <summary>
        /// Shows the full name of a student.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// Shows the date of submitting.
        /// </summary>
        public DateTime submissionDate { get; set; }

        /// <summary>
        /// Shows the time of submitting.
        /// </summary>
        public DateTime assignmentDueDate { get; set; }

        /// <summary>
        /// Shows the users grade.
        /// </summary>
        public double grade { get; set; }
    }
}