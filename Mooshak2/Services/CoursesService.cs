using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mooshak2.Models;
using Mooshak2.Models.Entities;

namespace Mooshak2.Services
{
    /// <summary>
    /// Services are mainly used to connect entities to the database and retrieve/submit data
    /// from tables, for example: getCourseNameByCourseID returns a course
    /// name by finding a given course ID assigned to it.
    /// </summary>
    public class CoursesService
    {

        private ApplicationDbContext db;

        public CoursesService()
        {
            db = new ApplicationDbContext();
        }

        /// <summary>
        /// This function returns a course by its ID.
        /// </summary>
        /// <param name="courseID">An ID number used to find the course in question.</param>
        /// <returns>A course is returned with id, name and description.</returns>
        public Courses getCourseByCourseID(int courseID)
        {
            //TODO:
            //fetch course object variables
            //return object
            return null;
        }

        /// <summary>
        /// This function returns a list of courses that a user is part of.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ICollection<Courses> getCoursesByUser(int userID)
        {
            //TODO:
            //pagination for long lists
            return null;
        }

        /// <summary>
        /// This function returns a list of all courses.
        /// </summary>
        /// <returns></returns>
        public ICollection<Courses> getAllCourses()
        {
            //TODO:
            //pagination for long lists
            return null;
        }

        /// <summary>
        /// This function adds a new course to the database.
        /// </summary>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewCourse()
        {
            //TODO:
            return true;
        }

        /// <summary>
        /// This function adds a new connection between a user and a course to the database.
        /// </summary>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewCourseAndUserConnection()
        {
            //TODO:
            return true;
        }
    }
}