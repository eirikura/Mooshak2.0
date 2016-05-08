using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Services
{
    public class AssigmnentsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coursID"></param>
        /// <returns></returns>
        public List<AssigmentViewModel> getAssigmentsInCourse(int coursID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assignmentID"></param>
        /// <returns></returns>
        public AssigmentViewModel getAssignmentByID (int assignmentID)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="partsID"></param>
        /// <returns></returns>
        public AssigmentViewModel submitAssignment (int userID, int partsID)
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