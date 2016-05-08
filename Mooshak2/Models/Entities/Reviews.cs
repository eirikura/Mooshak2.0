using System;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Reviews
    {
        /// <summary>
        /// 
        /// </summary>
        public int reviewID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int submissionID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string reviewText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime creationDate { get; set; }
    }
}