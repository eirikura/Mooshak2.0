using Mooshak2.Models;
using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Services
{
    /// <summary>
    /// Services are mainly used to connect entities to the database and retrieve/submit data
    /// from tables, for example: getAssigmentsInCourse returns a list of all assignments
    /// assigned to the given course ID.
    /// </summary>
    public class AssignmentsService
    {
        private ApplicationDbContext _db;

        public AssignmentsService()
        {
            _db = new ApplicationDbContext();
        }

        /// <summary>
        /// Returns a list of all the courses assigned to the given course ID.
        /// </summary>
        /// <param name="coursID"></param>
        /// <returns></returns>
        public List<AssignmentViewModel> getAssigmentsInCourse(int courseID)
        {
            ///TODO:
            var course = _db.Courses.SingleOrDefault(x => x.courseID == courseID);



            return null;
        }

        /// <summary>
        /// Returns an assignment assigned to the given assignment ID.
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public AssignmentViewModel getAssignmentByAssignmentID(int assignmentID)
        {
            var assignment = _db.Assignments.SingleOrDefault(x => x.assignmentID == assignmentID);

            var assignmentParts = _db.AssignmentParts
                .Where(x => x.assignmentID == assignmentID)
                .Select(x => new AssignmentViewModel
                {
                    assignmentName = x.partsName
                })
                .ToList();

            var viewModel = new AssignmentViewModel
            {
                assignmentName = assignment.assignmentName,
                PartsList = assignmentParts
            };
            return viewModel;
        }

        /// <summary>
        /// Submits an assignment for a specified part ID by an user with the specified user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssignmentViewModel submitAssignment(int userID, int partsID)
        {
            ///TODO:
            return null;
        }

        /// <summary>
        /// Returns grade for an user with the specified user ID for an assignment part with the specified parts ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public GradeViewModel getGradeByUserReviewID(int reviewID)
        {
            var grade = _db.Reviews.SingleOrDefault(x => x.reviewID == reviewID);

            var viewModel = new GradeViewModel
            {
                grade = grade.grade
            };
            return viewModel;
        }

        /// <summary>
        /// Returns an users full name assigned to the specified user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getFullNameByUserID(int userID)
        {
            var fullName = _db.Users.SingleOrDefault(x => x.userID == userID);

            var viewModel = new UserCreateEditViewModel
            {
                fullName = fullName.fullName
            };
            return viewModel;
        }

        /// <summary>
        /// Returns an assignment that matches the given parts ID.
        /// </summary>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssignmentViewModel getAssignmentByPartsID(int partsID)
        {
            var assignmentPart = _db.AssignmentParts.SingleOrDefault(x => x.partsID == partsID);
            var assignmentID = assignmentPart.assignmentID;

            var assignmentName = _db.Assignments.SingleOrDefault(x => x.assignmentID == assignmentID);

            var viewModel = new AssignmentViewModel
            {
                assignmentName = assignmentName.assignmentName
            };

            return viewModel;
        }
        
    }
}