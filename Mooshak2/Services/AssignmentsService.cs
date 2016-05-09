using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Services
{
    /// <summary>
    /// Services are mainly used to connect entities to the database and retrive data
    /// from tables, for example: getAssigmentsInCourse returns a list of all assignments
    /// assigned to the given course ID.
    /// </summary>
    public class AssignmentsService
    {
        /// <summary>
        /// Returns a list of all the courses assigned to the given course ID.
        /// </summary>
        /// <param name="coursID"></param>
        /// <returns></returns>
        public List<AssignmentViewModel> getAssigmentsInCourse(int courseID)
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
            return null;
        }

        /// <summary>
        /// Submits an assignment for a specified part ID by an user with the specified user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssignmentViewModel submitAssignment(int userID, int partsID)
        {
            return null;
        }

        /// <summary>
        /// Returns grade for an user with the specified user ID for an assignment part with the specified parts ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public GradeViewModel getGradeByID(int userID, int partsID)
        {
            return null;
        }

        /// <summary>
        /// Returns an users full name assigned to the specified user ID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getFullNameByUserID(int userID)
        {
            return null;
        }

        /// <summary>
        /// Returns an assignment that matches the given parts ID.
        /// </summary>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssignmentViewModel getAssignmentByPartsID(int partsID)
        {
            return null;
        }
        
    }
}