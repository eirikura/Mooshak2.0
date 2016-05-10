using System;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// The idea of reviews is to have a teacher give a direct review on an assignment
    /// for a specified student. The student would be then able to see a review from a
    /// teacher under an assignment he had submitted.
    /// </summary>
    public class Reviews
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
        public int grade { get; set; }

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