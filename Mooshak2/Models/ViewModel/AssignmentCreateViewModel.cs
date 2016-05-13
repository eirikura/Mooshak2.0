using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AssignmentCreateViewModel
    {
        /// <summary>
        /// ID of the course that the assignment will belong to.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// Name of the assignment to be created.
        /// </summary>
        [Display(Name = "Name of assignment")]
        [Required(ErrorMessage = "Assignment requires name")]
        public string name { get; set; }

        /// <summary>
        /// Date of when the assignment shall be due.
        /// </summary>
        [Display(Name = "Due date of assignment")]
        [Required(ErrorMessage = "Assignment requires due date")]
        public DateTime dueDate { get; set; }
    }
}