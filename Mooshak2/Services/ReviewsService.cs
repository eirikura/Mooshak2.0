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
        /// This function fetches a review from database based on the review ID number.
        /// </summary>
        /// <param name="reviewID"></param>
        /// <returns>Returns a viewmodel of a review in database.</returns>
        public ReviewViewModel getReviewByID(int reviewID)
        {
            var reviewQuery = (from review in _db.Reviews
                               where review.reviewID == reviewID
                               select review).SingleOrDefault();

            var reviewModel = new ReviewViewModel()
            {
                reviewID = reviewQuery.reviewID,
                userID = reviewQuery.userID,
                grade = reviewQuery.grade,
                reviewText = reviewQuery.reviewText,
                creationDate = reviewQuery.creationDate,
                lastUpdated = reviewQuery.lastUpdated
            };

            return reviewModel;
        }

        /// <summary>
        /// This function fetches a review from database based on review ID number.
        /// Is used to fetch data for editing a review.
        /// </summary>
        /// <param name="reviewID"></param>
        /// <returns>A ReviewEditViewModel used for editing.</returns>
        public ReviewEditViewModel getEditReviewByID(int reviewID)
        {
            var reviewEditQuery = getReviewByID(reviewID);

            var reviewEditModel = new ReviewEditViewModel()
            {
                reviewID = reviewEditQuery.reviewID,
                userID = reviewEditQuery.userID,
                grade = reviewEditQuery.grade,
                reviewText = reviewEditQuery.reviewText,
                lastUpdated = reviewEditQuery.lastUpdated
            };

            return reviewEditModel;
        }

        /// <summary>
        /// This function fetches a list of all reviews from database.
        /// </summary>
        /// <returns>Returns a list of ReviewViewModels.</returns>
        public ICollection<ReviewViewModel> getAllReviews()
        {
            var reviewsQuery = (from reviews in _db.Reviews
                                select reviews).ToList();

            var reviewsModel = new List<ReviewViewModel>();

            foreach (var review in reviewsQuery)
            {
                reviewsModel.Add(new ReviewViewModel
                {
                    reviewID = review.reviewID,
                    userID = review.userID,
                    grade = review.grade,
                    reviewText = review.reviewText,
                    creationDate = review.creationDate,
                    lastUpdated = review.lastUpdated
                });
            }

            return reviewsModel;
        }

        /// <summary>
        /// This function fetches a list of all reviews based on user ID number
        /// of the user that made the review.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>A list of ReviewViewModels.</returns>
        public ICollection<ReviewViewModel> getReviewsByUser(int userID)
        {
            var userReviewsQuery = (from reviews in _db.Reviews
                                    where reviews.userID == userID
                                    select reviews).ToList();

            var userReviewsModel = new List<ReviewViewModel>();

            foreach (var review in userReviewsQuery)
            {
                userReviewsModel.Add(new ReviewViewModel
                {
                    reviewID = review.reviewID,
                    userID = review.userID,
                    grade = review.grade,
                    reviewText = review.reviewText,
                    creationDate = review.creationDate,
                    lastUpdated = review.lastUpdated
                });
            }
            return userReviewsModel;
        }

        /// <summary>
        /// This functions uses a submission ID to fetch a review.
        /// Fetches from two tables - the Submissions table and Reviews table.
        /// </summary>
        /// <param name="submissionID"></param>
        /// <returns>Returns a ViewModel.</returns>
      /*  public ReviewViewModel getReviewBySubmission(int submissionID)
        {
            var submissionReviewQuery = (from submission in _db.Submissions
                                         where submission.submissionsID == submissionID
                                         join review in _db.Reviews
                                         on submission.reviewID equals review.reviewID
                                         select review).SingleOrDefault();

            var submissionReviewModel = new ReviewViewModel()
            {
                reviewID = submissionReviewQuery.reviewID,
                userID = submissionReviewQuery.userID,
                grade = submissionReviewQuery.grade,
                reviewText = submissionReviewQuery.reviewText,
                creationDate = submissionReviewQuery.creationDate,
                lastUpdated = submissionReviewQuery.lastUpdated
            };

            return submissionReviewModel;
        }*/

        /// <summary>
        /// This function adds a new review to the review database and links it to a submission.
        /// Controller sends in a creationDate.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns>True if successfully added, false otherwise.</returns>
        public bool addNewReview(ReviewCreateViewModel newReview)
        {
            bool successfullyAdded = false;

            Models.Entities.Reviews addReview = new Models.Entities.Reviews()
            {
                userID = newReview.userID,
                grade = newReview.grade,
                reviewText = newReview.reviewText,
                creationDate = newReview.creationDate,
                lastUpdated = newReview.creationDate
            };

            _db.Reviews.Add(addReview);

            try
            {
                //TODO:
                //link to a submission
                _db.SaveChanges();
                successfullyAdded = true;
            }
            catch
            {
                successfullyAdded = false;
            }

            return successfullyAdded;
        }

        /// <summary>
        /// This function updates an existing review in the database.
        /// Controller sends in a new lastUpdated date.
        /// </summary>
        /// <param name="changeReview"></param>
        /// <returns>True if succesfully changed, false otherwise.</returns>
        public bool updateReview(ReviewEditViewModel changeReview)
        {
            bool succesfullyChanged = false;

            try
            {
                var query = (from review in _db.Reviews
                             where review.reviewID == changeReview.reviewID
                             select review).SingleOrDefault();

                if (query != null)
                {
                    query.grade = changeReview.grade;
                    query.reviewText = changeReview.reviewText;
                    query.lastUpdated = changeReview.lastUpdated;

                    _db.SaveChanges();
                    succesfullyChanged = true;
                }
            }
            catch
            {
                succesfullyChanged = false;
            }

            return succesfullyChanged;
        }
    }
}