using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class ReviewEditViewModel
    {
        /// <summary>
        /// An unique auto-generated ID number of an review.
        /// </summary>
        public int reviewID { get; set; }

        /// <summary>
        /// An unique ID used to connect a review with an user.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// The review grade given by teacher.
        /// </summary>
        public int? grade { get; set; }

        /// <summary>
        /// The actual review given by teacher.
        /// </summary>
        public string reviewText { get; set; }

        /// <summary>
        /// The creation time of the review.
        /// </summary>
        public DateTime creationDate { get; set; }
    }
}