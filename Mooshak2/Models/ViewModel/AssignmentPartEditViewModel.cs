using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AssignmentPartEditViewModel
    {
        /// <summary>
        /// The ID number of an assignment part.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// The ID of a programming language.
        /// Can be null.
        /// </summary>
        [Display(Name = "Change programming language")]
        public int? languageID { get; set; }

        /// <summary>
        /// The name of an assignment part.
        /// </summary>
        [Display(Name = "Change name of assignment part")]
        [Required(ErrorMessage = "Assignment part needs a name")]
        public string name { get; set; }

        /// <summary>
        /// The description of an assignment part.
        /// Can be null.
        /// </summary>
        [Display(Name = "Change description of assignment part")]
        public string description { get; set; }

        /// <summary>
        /// The weight of an assignment part.
        /// Can be null.
        /// </summary>
        [Display(Name = "Change weight of percentage")]
        public int? percentage { get; set; }

        /// <summary>
        /// Additional study material for assignment part.
        /// Can be null.
        /// </summary>
        [Display(Name = "Change additional study material")]
        public string studyMaterial { get; set; }
    }
}