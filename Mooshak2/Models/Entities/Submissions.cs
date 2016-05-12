using System;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// Students can submit assignments or assignmentParts into the system.
    /// These submissions are then stored withis this entity and are connected
    /// to an user and assignmets using specific ID´s.
    /// </summary>
    public class Submissions
    {
        /// <summary>
        /// An unique auto-generated ID number of a submission.
        /// </summary>
        public int submissionsID { get; set; }

        /// <summary>
        /// An ID number of an user used to connect an user to a submission.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// An ID number of a part used to connect a submission to an assignments part.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// An ID number of a programming language used in the submission.
        /// </summary>
        public int? languageID { get; set; }

        /// <summary>
        /// An ID number of an review used to connect it to a submission.
        /// </summary>
        public int? reviewID { get; set; }

        /// <summary>
        /// Keeps track of whether a submission was correct or not. Can be null.
        /// </summary>
        public bool? accepted { get; set; }

        /// <summary>
        /// The url location of the file the student submitted.
        /// </summary>
        public string file { get; set; }

        /// <summary>
        /// The results for the submission. What tests were made and results for each. Error messages if any.
        /// </summary>
        public string resultData { get; set; }

        /// <summary>
        /// The date at which a part of an assignment was submitted.
        /// </summary>
        public DateTime submissionDateTime { get; set; }
    }
}