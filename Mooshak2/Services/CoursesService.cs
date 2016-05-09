using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Services
{
    /// <summary>
    /// This service is mainly used to connect entities to the database and retrive data
    /// by a specified value, for example: getCourseNameByCourseID returns a course
    /// name by finding a given course ID assigned to it.
    /// </summary>
    public class CoursesService
    {
        /// <summary>
        /// This functions returns a courses name assigned to the given course ID.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public CourseCreateEditViewModel getCourseNameByCourseID (int courseID)
        {
            //TODO:
            return null;
        }

        /// <summary>
        /// This function returns the courses description assigned to the given course ID.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public CourseCreateEditViewModel getCourseDescriptionByCourseID (int courseID)
        {
            //TODO:
            return null;
        }
    }
}