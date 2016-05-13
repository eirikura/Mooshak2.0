﻿using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mooshak2.Models;

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
        public CourseViewModel getCourseByCourseID(int courseID)
        {
            var courseQuery = (from course in db.Courses
                               where course.courseID == courseID
                               select course).SingleOrDefault();

            var courseModel = new CourseViewModel()
            {
                courseID = courseQuery.courseID,
                courseName = courseQuery.name,
                courseDescription = courseQuery.description
            };

            return courseModel;
        }

        /// <summary>
        /// This function returns a list of courses that a user is part of.
        /// </summary>
        /// <param name="userID">Takes in a user's ID number.</param>
        /// <returns>A list of courses.</returns>
        public ICollection<CourseViewModel> getCoursesByUser(int userID)
        {
            var userCoursesQuery = (from userCourses in db.UsersAndCourses
                                    where userCourses.userID == userID
                                    join courses in db.Courses 
                                    on userCourses.courseID equals courses.courseID
                                    select courses).ToList();

            var userCoursesModel = new List<CourseViewModel>();

            foreach (var course in userCoursesQuery)
            {
                userCoursesModel.Add(new CourseViewModel
                {
                    courseID = course.courseID,
                    courseName = course.name,
                    courseDescription = course.description
                });
            }

            return userCoursesModel;
        }

        /// <summary>
        /// This function returns a list of all courses.
        /// </summary>
        /// <returns>A list of courses.</returns>
        public ICollection<CourseViewModel> getAllCourses()
        {
            var coursesQuery = (from course in db.Courses
                                select course).ToList();

            var coursesModel = new List<CourseViewModel>();

            foreach (var course in coursesQuery)
            {
                coursesModel.Add(new CourseViewModel
                {
                    courseID = course.courseID,
                    courseName = course.name,
                    courseDescription = course.description
                });
            }

            return coursesModel;
        }

        /// <summary>
        /// This function adds a new course to the database.
        /// </summary>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewCourse(CourseCreateViewModel newCourse)
        {
            bool successfullyAdded = false;

            Models.Entities.Courses addCourse = new Models.Entities.Courses()
            {
                name = newCourse.courseName,
                description = newCourse.courseDescription
            };

            db.Courses.Add(addCourse);

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
       /* public bool addNewCourseAndUserConnection(UsersAndCoursesViewModel connectionToAdd)
        {
            bool successfullyAdded = false;

            Models.Entities.UsersAndCourses addConnection = new Models.Entities.UsersAndCourses()
            {
                userID = connectionToAdd.userID,
                courseID = connectionToAdd.courseID
            };

            db.UsersAndCourses.Add(addConnection);

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
        }*/

        /// <summary>
        /// This function updates values for a chosen course when an admin changes its values.
        /// Possible values to change are name and description.
        /// </summary>
        /// <param name="courseToChange">Takes in a course to change.</param>
        /// <returns>Returns true if editing the course finished successfully, else false.</returns>
        public bool updateCourseInfo (CourseEditViewModel courseToChange)
        {
            bool successfullyEdited = false;

            try
            {
                var query = (from course in db.Courses
                             where course.courseID == courseToChange.courseID
                             select course).SingleOrDefault();

                if (query != null)
                {
                    query.name = courseToChange.courseName;
                    query.description = courseToChange.courseDescription;
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