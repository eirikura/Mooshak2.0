using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class ReviewCreateViewModel
    {
        /// <summary>
        /// An unique ID used to connect a review with an user.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// An ID number used to identify which submission a review belongs to.
        /// </summary>
        public int submissionID { get; set; }

        /// <summary>
        /// The review grade given by teacher. Can be null.
        /// </summary>
        public int? grade { get; set; }

        /// <summary>
        /// The actual review given by teacher. Can be null.
        /// </summary>
        public string reviewText { get; set; }

        /// <summary>
        /// The creation time of the review.
        /// </summary>
        public DateTime creationDate { get; set; }
    }
}