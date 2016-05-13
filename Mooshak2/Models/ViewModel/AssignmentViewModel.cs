using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mooshak2.Models.ViewModel;

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
        /// The ID number of an assignment.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// The ID number of course that the assignment belongs to.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// The name of the assignment.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// When the assignment is due.
        /// </summary>
        public DateTime dueDate { get; set; }

         /// <summary>
        /// Shows a list of the students upcoming assignments.
        /// </summary>
        public List<AssignmentPartViewModel> partsList { get; set; }
    }
}