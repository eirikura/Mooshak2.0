﻿using System;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// Students can submit assignments or assignmentParts into the system.
    /// These submissions are then strored withis this entity and are connected
    /// to an user and assignmets using specific ID´s.
    /// </summary>
    public class Submissions
    {
        /// <summary>
        /// An unique auto-generated ID number of a submission.
        /// </summary>
        public int submissionsID { get; set; }

        /// <summary>
        /// An ID number of an user used to connect and user to a submission.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// An ID number of a part used to connect a submission to an assignments part.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// An ID number of an review used to connect it to a submission.
        /// </summary>
        public int reviewID { get; set; }

        /// <summary>
        /// A final grade each user is given for a submission.
        /// </summary>
        public double grade { get; set; }

        /// <summary>
        /// The url location of the file the student submitted.
        /// </summary>
        public string file { get; set; }

        /// <summary>
        /// The date at which a part of an assignment was submitted.
        /// </summary>
        public DateTime submissionDate { get; set; }

        /// <summary>
        /// The time at which a part of an assignment was submitted.
        /// </summary>
        public DateTime submissionTime { get; set; }
    }
}