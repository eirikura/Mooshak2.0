﻿using System.ComponentModel.DataAnnotations;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// It is possible to divide an assignment into many parts with different weight for each,
    /// every assignment has at least one part or more.
    /// Example: An assignment named Project 3 is divided into two parts each weighing 50%.
    /// </summary>
    public class AssignmentParts
    {
        [Key]
        /// <summary>
        /// An unique auto-generated ID number of a part.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// An unique ID used to connect a part with an assignment.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// An ID used to set which programming language should be used for the assignment.
        /// Is nullable.
        /// </summary>
        public int? languageID { get; set; }

        /// <summary>
        /// A name(title) of a part.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// A description of a part.
        /// Is nullable.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The weight of a part in percentages.
        /// Example: An assignment is divided into two parts, each having 50% weight(percentage).
        /// Is nullable.
        /// </summary>
        public int? percentage { get; set; }

        /// <summary>
        /// Any additional study material needed for the specific part. This be a file.
        /// Is nullable.
        /// </summary>
        public string studyMaterial { get; set; }
    }
}