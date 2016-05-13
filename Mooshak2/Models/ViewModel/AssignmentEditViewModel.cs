using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AssignmentEditViewModel
    {
        /// <summary>
        /// The ID of the assignment being edited.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// The name of the assignment being edited.
        /// </summary>
        [Display(Name = "Change name of assignment")]
        [Required(ErrorMessage = "Assignment requires name")]
        public string name { get; set; }

        /// <summary>
        /// The due date of the assignment being edited.
        /// </summary>
        [Display(Name = "Change due date")]
        public DateTime dueDate { get; set; }

        /// <summary>
        /// The parts of an assignment.
        /// </summary>
        public ICollection<AssignmentPartViewModel> partsList { get; set; }
    }
}