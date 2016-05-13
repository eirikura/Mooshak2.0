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
        /// Returns a list of all the assignments assigned to the given course ID.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ICollection<AssignmentViewModel> getAssignmentsInCourse(int courseID)
        {
            return null;
        }

        /// <summary>
        /// A function that fetches a list of all assignments related to a user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ICollection<AssignmentViewModel> getAssignmentsByUser(int userID)
        {
            return null;
        }

        /// <summary>
        /// A function that uses assignment ID number to get a list of all assignment
        /// parts belonging to an assignment.
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public ICollection<AssignmentPartViewModel> getAssignmentPartsByAssignment(int assignmentID)
        {
            return null;
        }


        /// <summary>
        /// Returns an assignment assigned to the given assignment ID.
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public AssignmentViewModel getAssignmentByAssignmentID(int assignmentID)
        {
            var assignmentQuery = (from assignment in _db.Assignments
                                   where assignment.assignmentID == assignmentID
                                   select assignment).SingleOrDefault();

            var assignmentModel = new AssignmentViewModel()
            {
                assignmentID = assignmentQuery.assignmentID,
                courseID = assignmentQuery.courseID,
                name = assignmentQuery.name,
                dueDate = assignmentQuery.dueDate
            };

            return assignmentModel;
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
                //grade = grade.grade
            };
            return viewModel;
        }

        /// <summary>
        /// Returns an assignment that matches the given parts ID.
        /// </summary>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssignmentPartViewModel getAssignmentByPartsID(int partsID)
        {
            var assignmentPartQuery = (from part in _db.AssignmentParts
                                       where part.partsID == partsID
                                       select part).SingleOrDefault();

            var assignmentPartModel = new AssignmentPartViewModel()
            {
                partsID = assignmentPartQuery.partsID,
                assignmentID = assignmentPartQuery.assignmentID,
                name = assignmentPartQuery.name,
                description = assignmentPartQuery.description,
                languageID = assignmentPartQuery.languageID,
                percentage = assignmentPartQuery.percentage,
                studyMaterial = assignmentPartQuery.studyMaterial
            };

            return assignmentPartModel;
        }
        
        /// <summary>
        /// A function that fetches a list of all possible programming languages.
        /// </summary>
        /// <returns>A list with all programming languages.</returns>
        public ICollection<AssignmentLanguageViewModel> getAssignmentLanguages()
        {
            var languageQuery = (from language in _db.AssignmentLanguage
                                 select language).ToList();

            var languageModel = new List<AssignmentLanguageViewModel>();

            foreach (var language in languageQuery)
            {
                languageModel.Add(new AssignmentLanguageViewModel
                {
                    languageID = language.languageID,
                    name = language.name
                });
            }

            return languageModel;
        }
        
    }
}