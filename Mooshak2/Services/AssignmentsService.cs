using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Services
{
    public class AssignmentsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coursID"></param>
        /// <returns></returns>
        public List<AssignmentViewModel> getAssigmentsInCourse(int coursID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public AssignmentViewModel getAssignmentByID (int assignmentID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssignmentViewModel submitAssignment (int userID, int partsID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public GradeViewModel getGradeByID (int userID, int partsID)
        {
            return null;
        }


        
    }
}