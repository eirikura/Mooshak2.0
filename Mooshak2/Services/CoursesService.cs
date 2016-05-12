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
            return db.Courses.SingleOrDefault(x => x.courseID == courseID);
        }

        /// <summary>
        /// This function returns a list of courses that a user is part of.
        /// </summary>
        /// <param name="userID">Takes in a user's ID number.</param>
        /// <returns>A list of courses.</returns>
        public ICollection<Courses> getCoursesByUser(int userID)
        {
            var userCoursesQuery = (from userCourses in db.UsersAndCourses
                                    where userCourses.userID == userID
                                    join courses in db.Courses 
                                    on userCourses.courseID equals courses.courseID
                                    select courses).ToList();

            return userCoursesQuery;
        }

        /// <summary>
        /// This function returns a list of all courses.
        /// </summary>
        /// <returns>A list of courses.</returns>
        public ICollection<Courses> getAllCourses()
        {
            var courses = (from course in db.Courses
                          select course).ToList();

            return courses;
        }

        /// <summary>
        /// This function adds a new course to the database.
        /// </summary>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewCourse(Courses newCourse)
        {
            bool successfullyAdded = false;

            db.Courses.Add(newCourse);

            try
            {
                db.SaveChanges();
                successfullyAdded = true;
            }
            catch
            {
                successfullyAdded = false;
            }

            return successfullyAdded;
        }

        /// <summary>
        /// This function adds a new connection between a user and a course to the database.
        /// </summary>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewCourseAndUserConnection(UsersAndCourses connectionToAdd)
        {
            bool successfullyAdded = false;

            db.UsersAndCourses.Add(connectionToAdd);

            try
            {
                db.SaveChanges();
                successfullyAdded = true;
            }
            catch
            {
                successfullyAdded = false;
            }

            return successfullyAdded;
        }

        /// <summary>
        /// This function updates values for a chosen course when an admin changes its values.
        /// Possible values to change are name and description.
        /// </summary>
        /// <param name="courseToChange">Takes in a course to change.</param>
        /// <returns>Returns true if editing the course finished successfully, else false.</returns>
        public bool updateCourseInfo (Courses courseToChange)
        {
            bool successfullyEdited = false;

            try
            {
                var query = (from course in db.Courses
                             where course.courseID == courseToChange.courseID
                             select course).SingleOrDefault();

                if (query != null)
                {
                    query.name = courseToChange.name;
                    query.description = courseToChange.description;
                    db.SaveChanges();
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