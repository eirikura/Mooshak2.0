using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class SubmissionSendViewModel
    {
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
        /// The url location of the file the student submitted.
        /// </summary>
        public string file { get; set; }

        /// <summary>
        /// The date at which a part of an assignment was submitted.
        /// </summary>
        public DateTime submissionDateTime { get; set; }
    }
}