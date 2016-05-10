using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The assignment view model is responsible for showing current assignments. It is used by students
    /// in order to submit an assignemnt or a part of it and see details of an assignment like
    /// for example, due date of an assignment.
    /// </summary>
    public class AssignmentViewModel
    {
        /// <summary>
        /// The name of the assignment.
        /// </summary>
        public string assignmentName { get; set; }

        /// <summary>
        /// The description of the assignment or a part of it.
        /// </summary>
        public string partsDescription { get; set; }

        /// <summary>
        /// The due date of an assignment.
        /// </summary>
        public DateTime assignmentDueDate { get; set; }

        /// <summary>
        /// The date of submission.
        /// </summary>
        public DateTime submissionDate { get; set; }

        /// <summary>
        /// The time of submission.
        /// </summary>
        public DateTime submissionTime { get; set; }

        /// <summary>
        /// Shows a list of the students upcoming assignments.
        /// </summary>
        public List<AssignmentViewModel> PartsList { get; set; }
    }
}