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
            //TODO:
            return null;
        }

        /// <summary>
        /// A function that fetches a list of all assignments related to a user.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ICollection<AssignmentViewModel> getAssignmentsByUser(int userID)
        {
            //TODO:
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
            //TODO:
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
        /// <param name="reviewID"></param>
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

        /// <summary>
        /// A function that adds a new assignment to Assignments table.
        /// </summary>
        /// <param name="newAssignment"></param>
        /// <returns>True if it was added, false otherwise.</returns>
        public bool createNewAssignment(AssignmentCreateViewModel newAssignment)
        {
            bool successfullyAdded = false;

            Models.Entities.Assignments addAssignment = new Models.Entities.Assignments()
            {
                courseID = newAssignment.courseID,
                name = newAssignment.name,
                dueDate = newAssignment.dueDate
            };

            _db.Assignments.Add(addAssignment);

            try
            {
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
        /// A function that adds a new assignment part to an assignment
        /// and adds to AssignmentParts table.
        /// </summary>
        /// <param name="newAssignmentPart"></param>
        /// <returns>True if added succesfully, otherwise false.</returns>
        public bool createNewAssignmentPart(AssignmentPartCreateViewModel newAssignmentPart)
        {
            bool successfullyAdded = false;

            Models.Entities.AssignmentParts addPart = new Models.Entities.AssignmentParts()
            {
                assignmentID = newAssignmentPart.assignmentID,
                name = newAssignmentPart.name,
                description = newAssignmentPart.description,
                languageID = newAssignmentPart.languageID,
                percentage = newAssignmentPart.percentage,
                studyMaterial = newAssignmentPart.studyMaterial
            };

            _db.AssignmentParts.Add(addPart);

            try
            {
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
        /// A function that changes values of an assignment and updates
        /// the data table with changed values.
        /// </summary>
        /// <param name="assignmentToEdit"></param>
        /// <returns></returns>
        public bool editAssignment(AssignmentEditViewModel assignmentToEdit)
        {
            bool successfullyEdited = false;

            try
            {
                var assignmentQuery = (from assignment in _db.Assignments
                                       where assignment.assignmentID == assignmentToEdit.assignmentID
                                       select assignment).SingleOrDefault();

                if (assignmentQuery != null)
                {
                    assignmentQuery.name = assignmentToEdit.name;
                    assignmentQuery.dueDate = assignmentToEdit.dueDate;

                    _db.SaveChanges();
                    successfullyEdited = true;
                }
            }
            catch
            {
                successfullyEdited = false;
            }

            return successfullyEdited;
        }
        
        /// <summary>
        /// A function that changes values of an assignment part and updates
        /// the data table with changed values.
        /// </summary>
        /// <param name="assignmentPartToEdit"></param>
        /// <returns></returns>
        public bool editAssignmentPart(AssignmentPartEditViewModel assignmentPartToEdit)
        {
            bool successfullyEdited = false;

            try
            {
                var partQuery = (from parts in _db.AssignmentParts
                                 where parts.partsID == assignmentPartToEdit.partsID
                                 select parts).SingleOrDefault();

                if (partQuery != null)
                {
                    partQuery.name = assignmentPartToEdit.name;
                    partQuery.languageID = assignmentPartToEdit.languageID;
                    partQuery.description = assignmentPartToEdit.description;
                    partQuery.percentage = assignmentPartToEdit.percentage;
                    partQuery.studyMaterial = assignmentPartToEdit.studyMaterial;

                    _db.SaveChanges();
                    successfullyEdited = true;
                }
            }
            catch
            {
                successfullyEdited = false;
            }

            return successfullyEdited;
        }        
    }
}