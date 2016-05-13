using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mooshak2.Models;
using Mooshak2.Models.ViewModel;

namespace Mooshak2.Services
{
    /// <summary>
    /// Service handles a connection between data and database tables.
    /// This Service reads and adds data to the Reviews table as well
    /// as connecting the review to a submission.
    /// </summary>
    public class ReviewsService
    {
        private ApplicationDbContext _db;

        public ReviewsService()
        {
            _db = new ApplicationDbContext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reviewID"></param>
        /// <returns></returns>
        public ReviewViewModel getReviewByID(int reviewID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<ReviewViewModel> getAllReviews()
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ICollection<ReviewViewModel> getReviewsByUser(int userID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="submissionID"></param>
        /// <returns></returns>
        public ReviewViewModel getReviewBySubmission(int submissionID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public bool addNewReview(ReviewCreateViewModel newReview)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="changeReview"></param>
        /// <returns></returns>
        public bool updateReview(ReviewEditViewModel changeReview)
        {
            return true;
        }
    }
}