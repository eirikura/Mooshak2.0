using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mooshak2.Models;
using Mooshak2.Models.ViewModel;

namespace Mooshak2.Services
{
    /// <summary>
    /// Services are used to connect entities to database so that retrieving and
    /// adding data to tables can be done.
    /// </summary>
    public class SubmissionsService
    {
        private ApplicationDbContext _db;

        public SubmissionsService()
        {
            _db = new ApplicationDbContext();
        }

        /// <summary>
        /// This function returns a submission based on a submission ID number.
        /// </summary>
        /// <param name="submissionID"></param>
        /// <returns>A SubmissionViewModel is returned.</returns>
        public SubmissionViewModel getSubmissionByID(int submissionID)
        {
            var submissionQuery = (from submission in _db.Submissions
                                   where submission.submissionID == submissionID
                                   select submission).SingleOrDefault();

            var submissionModel = new SubmissionViewModel()
            {
                submissionID = submissionQuery.submissionID,
                userID = submissionQuery.userID,
                partsID = submissionQuery.partsID,
                languageID = submissionQuery.languageID,
                reviewID = submissionQuery.reviewID,
                accepted = submissionQuery.accepted,
                file = submissionQuery.file,
                resultData = submissionQuery.resultData,
                submissionDateTime = submissionQuery.submissionDateTime
            };

            return submissionModel;
        }

        /// <summary>
        /// This function returns a list of all submissions.
        /// </summary>
        /// <returns>All submissions in the submissions table.</returns>
        public ICollection<SubmissionViewModel> getAllSubmissions()
        {
            var submissionsQuery = (from submissions in _db.Submissions
                                    select submissions).ToList();

            var submissionsModel = new List<SubmissionViewModel>();

            foreach (var submission in submissionsQuery)
            {
                submissionsModel.Add(new SubmissionViewModel
                {
                    submissionID = submission.submissionID,
                    userID = submission.userID,
                    partsID = submission.partsID,
                    languageID = submission.languageID,
                    reviewID = submission.reviewID,
                    accepted = submission.accepted,
                    file = submission.file,
                    resultData = submission.resultData,
                    submissionDateTime = submission.submissionDateTime
                });
            }

            return submissionsModel;
        }

        /// <summary>
        /// This function returns all submissions made by a user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>A list of submissions by user.</returns>
        public ICollection<SubmissionViewModel> getAllSubmissionsByUser(int userID)
        {
            var userSubmissionQuery = (from submission in _db.Submissions
                                       where submission.userID == userID
                                       select submission).ToList();

            var userSubmissionsModel = new List<SubmissionViewModel>();

            foreach (var submission in userSubmissionQuery)
            {
                userSubmissionsModel.Add(new SubmissionViewModel
                {
                    submissionID = submission.submissionID,
                    userID = submission.userID,
                    partsID = submission.partsID,
                    languageID = submission.languageID,
                    reviewID = submission.reviewID,
                    accepted = submission.accepted,
                    file = submission.file,
                    resultData = submission.resultData,
                    submissionDateTime = submission.submissionDateTime
                });
            }

            return userSubmissionsModel;
        }

        /// <summary>
        /// This function returns all submissions in a course.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns>A list of submissions in a course.</returns>
        public ICollection<SubmissionViewModel> getAllSubmissionsByCourse(int courseID)
        {
            ///TODO:
            return null;
        }

        /// <summary>
        /// This function returns all submissions in an assignment.
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns>A list of submissions within an assignment.</returns>
        public ICollection<SubmissionViewModel> getAllSubmissionsByAssignment(int assignmentID)
        {
            ///TODO:
            return null;
        }

        /// <summary>
        /// This function fetches all submissions in an assignment part.
        /// </summary>
        /// <param name="assignmentPartID"></param>
        /// <returns>A list of all submission within an assignment part.</returns>
        public ICollection<SubmissionViewModel> getAllSubmissionsByAssignmentPart(int assignmentPartID)
        {
            var partSubmissionsQuery = (from submission in _db.Submissions
                                        where submission.partsID == assignmentPartID
                                        select submission).ToList();

            var partSubmissionsModel = new List<SubmissionViewModel>();

            foreach (var submission in partSubmissionsQuery)
            {
                partSubmissionsModel.Add(new SubmissionViewModel
                {
                    submissionID = submission.submissionID,
                    userID = submission.userID,
                    partsID = submission.partsID,
                    languageID = submission.languageID,
                    reviewID = submission.reviewID,
                    accepted = submission.accepted,
                    file = submission.file,
                    resultData = submission.resultData,
                    submissionDateTime = submission.submissionDateTime
                });
            }

            return partSubmissionsModel;
        }

        /// <summary>
        /// This function uses a user ID number to find and return the last accepted submission by a user.
        /// </summary>
        /// <returns>A ViewModel for the last accepted submission.</returns>
        public SubmissionViewModel getLastAcceptedUserSubmission(int userID)
        {
            //TODO:
            return null;
        }

        /// <summary>
        /// This function finds the last accepted submission of a user in an assignment part.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns>A SubmissionViewModel for last accepted submission in assignment part.</returns>
        public SubmissionViewModel getLastAcceptedUserSubmissionInPart(int userID, int partsID)
        {
            var lastAcceptedQuery = (from submission in _db.Submissions
                                     where submission.userID == userID 
                                     && submission.partsID == partsID
                                     && submission.accepted == true
                                     select submission).LastOrDefault();

            var lastAcceptedModel = new SubmissionViewModel()
            {
                submissionID = lastAcceptedQuery.submissionID,
                userID = lastAcceptedQuery.userID,
                partsID = lastAcceptedQuery.partsID,
                languageID = lastAcceptedQuery.languageID,
                reviewID = lastAcceptedQuery.reviewID,
                accepted = lastAcceptedQuery.accepted,
                file = lastAcceptedQuery.file,
                resultData = lastAcceptedQuery.resultData,
                submissionDateTime = lastAcceptedQuery.submissionDateTime
            };

            return lastAcceptedModel;
        }

        /// <summary>
        /// This function uses a user ID number to find and return the last submission by a user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>A ViewModel for the last submission by a user.</returns>
        public SubmissionViewModel getLastUserSubmission(int userID)
        {
            //TODO:
            return null;
        }

        /// <summary>
        /// This function finds the last submission of a user in an assignment part. 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public SubmissionViewModel getLastUserSubmissionInPart(int userID, int partsID)
        {
            var lastSubmissionQuery = (from submission in _db.Submissions
                                       where submission.userID == userID
                                       && submission.partsID == partsID
                                       select submission).LastOrDefault();

            var lastSubmissionModel = new SubmissionViewModel()
            {
                submissionID = lastSubmissionQuery.submissionID,
                userID = lastSubmissionQuery.userID,
                partsID = lastSubmissionQuery.partsID,
                languageID = lastSubmissionQuery.languageID,
                reviewID = lastSubmissionQuery.reviewID,
                accepted = lastSubmissionQuery.accepted,
                file = lastSubmissionQuery.file,
                resultData = lastSubmissionQuery.resultData,
                submissionDateTime = lastSubmissionQuery.submissionDateTime
            };

            return lastSubmissionModel;
        }

        /// <summary>
        /// This function fetches all submissions by a certain user in a certain course.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="courseID"></param>
        /// <returns>A list of submissions by user in course.</returns>
        public ICollection<SubmissionViewModel> getUserSubmissionsByCourse(int userID, int courseID)
        {
            //TODO:
            return null;
        }

        /// <summary>
        /// This function fetches all submissions by a user in a certain assignment.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="assignmentID"></param>
        /// <returns>A list of submissions by a user in an assignment.</returns>
        public ICollection<SubmissionViewModel> getUserSubmissionsByAssignment(int userID, int assignmentID)
        {
            //TODO:
            return null;
        }

        /// <summary>
        /// This function fetches all submissions by a user in a certain assignment part.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="assignmentPartID"></param>
        /// <returns>A list of submissions by a user in an assignment part.</returns>
        public ICollection<SubmissionViewModel> getUserSubmissionsByAssignmentPart(int userID, int assignmentPartID)
        {
            var userSubmissionQuery = (from submission in _db.Submissions
                                       where submission.userID == userID && submission.partsID == assignmentPartID
                                       select submission).ToList();

            var userSubmissionModel = new List<SubmissionViewModel>();

            foreach (var submission in userSubmissionQuery)
            {
                userSubmissionModel.Add(new SubmissionViewModel
                {
                    submissionID = submission.submissionID,
                    userID = submission.userID,
                    partsID = submission.partsID,
                    languageID = submission.languageID,
                    reviewID = submission.reviewID,
                    accepted = submission.accepted,
                    file = submission.file,
                    resultData = submission.resultData,
                    submissionDateTime = submission.submissionDateTime
                });
            }

            return userSubmissionModel;
        }

        /// <summary>
        /// This function adds a new submission to the submission table.
        /// </summary>
        /// <param name="newSubmission"></param>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewSubmission(SubmissionSendViewModel newSubmission)
        {
            bool successfullyAdded = false;

            Models.Entities.Submissions addSubmission = new Models.Entities.Submissions()
            {
                userID = newSubmission.userID,
                partsID = newSubmission.partsID,
                languageID = newSubmission.languageID,
                file = newSubmission.file,
                submissionDateTime = newSubmission.submissionDateTime
            };

            _db.Submissions.Add(addSubmission);

            try
            {
                _db.SaveChanges();
                successfullyAdded = true;
            }
            catch
            {
                successfullyAdded = false;
            }

            //TODO:
            //send data to compiler depending on languageID selected
            //only sends to compiler if languageID != null
            //if languageID is null it means submitted file is a file
            //that does not need to be compiled

            return successfullyAdded;
        }

        /// <summary>
        /// This function adds a link to a review for the submission.
        /// </summary>
        /// <param name="submissionID">The submission to be updated.</param>
        /// <param name="reviewID">The review to be added to submission.</param>
        /// <returns>True if able to update, else false.</returns>
        public bool addSubmissionReview(int submissionID, int reviewID)
        {
            bool successfullyAdded = false;

            try
            {
                var submissionQuery = (from submission in _db.Submissions
                                       where submission.submissionID == submissionID
                                       select submission).SingleOrDefault();

                if (submissionQuery != null)
                {
                    submissionQuery.reviewID = reviewID;

                    _db.SaveChanges();
                    successfullyAdded = true;
                }

            }
            catch
            {
                successfullyAdded = false;
            }

            return successfullyAdded;
        }

        /// <summary>
        /// This function updates accepted and resultData fields after recieving data from compiler.
        /// </summary>
        /// <param name="submissionID"></param>
        /// <returns></returns>
        public bool updateSubmissionStatus(int submissionID)
        {
            //TODO:
            return true;
        }

    }
}