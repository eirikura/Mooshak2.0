using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AssignmentPartViewModel
    {
        /// <summary>
        /// The ID number of an assignment part.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// The ID number of associated assignment.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// The ID of a programming language.
        /// Can be null.
        /// </summary>
        public int? languageID { get; set; }

        /// <summary>
        /// The name of an assignment part.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The description of an assignment part.
        /// Can be null.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The weight of an assignment part.
        /// Can be null.
        /// </summary>
        public int? percentage { get; set; }

        /// <summary>
        /// Additional study material for assignment part.
        /// Can be null.
        /// </summary>
        public string studyMaterial { get; set; }
    }
}