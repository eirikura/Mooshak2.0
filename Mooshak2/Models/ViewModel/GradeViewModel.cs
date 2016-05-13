using System;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The grade view model is responsible for showing students grades. It is mainly used
    /// by students but teachers are also welcome to check students grades.
    /// </summary>
    public class GradeViewModel
    {
        /// <summary>
        /// The full name of a student.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// The date of submission.
        /// </summary>
        public DateTime submissionDate { get; set; }

        /// <summary>
        /// The time of submission.
        /// </summary>
        public DateTime assignmentDueDate { get; set; }

        /// <summary>
        /// The grade user got.
        /// Measures from 0-100.
        /// </summary>
        public int grade { get; set; }
    }
}