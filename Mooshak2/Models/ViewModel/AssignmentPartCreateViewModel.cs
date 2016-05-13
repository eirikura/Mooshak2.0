using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AssignmentPartCreateViewModel
    {
          /// <summary>
        /// The ID number of associated assignment.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// The ID of a programming language.
        /// Can be null.
        /// </summary>
        [Display(Name = "Select programming language")]
        public int? languageID { get; set; }

        /// <summary>
        /// The name of an assignment part.
        /// </summary>
        [Display(Name = "Name of assignment part")]
        [Required(ErrorMessage = "Assignment part requires name")]
        public string name { get; set; }

        /// <summary>
        /// The description of an assignment part.
        /// Can be null.
        /// </summary>
        [Display(Name = "Description of assignment part")]
        public string description { get; set; }

        /// <summary>
        /// The weight of an assignment part.
        /// Can be null.
        /// </summary>
        [Display(Name = "Weight of assignment part")]
        public int? percentage { get; set; }

        /// <summary>
        /// Additional study material for assignment part.
        /// Can be null.
        /// </summary>
        [Display(Name = "Additional material")]
        public string studyMaterial { get; set; }
    }
}