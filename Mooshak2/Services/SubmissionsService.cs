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
        /// This function returns a list of all submissions.
        /// </summary>
        /// <returns>All submissions in the submissions table.</returns>
        public ICollection<SubmissionViewModel> getAllSubmissions()
        {
            return null;
        }

        /// <summary>
        /// This function returns a submission based on a submission ID number.
        /// </summary>
        /// <param name="submissionID"></param>
        /// <returns>A SubmissionViewModel is returned.</returns>
        public SubmissionViewModel getSubmissionByID(int submissionID)
        {
            return null;
        }

        /// <summary>
        /// This function returns all submissions made by a user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>A list of submissions by user.</returns>
        public ICollection<SubmissionViewModel> getSubmissionsByUser(int userID)
        {
            return null;
        }

        /// <summary>
        /// This function returns all submissions in a course.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns>A list of submissions in a course.</returns>
        public ICollection<SubmissionViewModel> getSubmissionsByCourse(int courseID)
        {
            return null;
        }

        /// <summary>
        /// This function returns all submissions in an assignment.
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns>A list of submissions within an assignment.</returns>
        public ICollection<SubmissionViewModel> getSubmissionsByAssignment(int assignmentID)
        {
            return null;
        }

        /// <summary>
        /// This function uses a user ID number to find and return the last accepted submission by a user.
        /// </summary>
        /// <returns>A ViewModel for the last accepted submission.</returns>
        public SubmissionViewModel getLastAcceptedSubmission(int userID)
        {
            return null;
        }

        /// <summary>
        /// This function uses a user ID number to find and return the last submission by a user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>A ViewModel for the last submission by a user.</returns>
        public SubmissionViewModel getLastSubmission(int userID)
        {
            return null;
        }

        /// <summary>
        /// This function adds a new submission to the submission table.
        /// </summary>
        /// <param name="newSubmission"></param>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewSubmission(SubmissionSendViewModel newSubmission)
        {
            return true;
        }

    }
}