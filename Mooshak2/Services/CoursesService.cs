using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mooshak2.Models;
using System.Web.Mvc;
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

        private ApplicationDbContext _db;

        public CoursesService()
        {
            _db = new ApplicationDbContext();
        }

        /// <summary>
        /// This function returns a course by its ID.
        /// </summary>
        /// <param name="courseID">An ID number used to find the course in question.</param>
        /// <returns>A course is returned with id, name and description.</returns>
        public CourseViewModel getCourseByCourseID(int courseID)
        {
            var courseQuery = (from course in _db.Courses
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
        /// This functions returns a course by its ID.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public CourseEditViewModel getEditCourseByCourseID(int courseID)
        {
            var courseQuery = (from course in _db.Courses
                               where course.courseID == courseID
                               select course).SingleOrDefault();

            var courseModel = new CourseEditViewModel()
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
            var userCoursesQuery = (from userCourses in _db.UsersAndCourses
                                    where userCourses.userID == userID
                                    join courses in _db.Courses 
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
            var coursesQuery = (from course in _db.Courses
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

            _db.Courses.Add(addCourse);

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
        /// This function adds a new connection between a user and a course to the database.
        /// </summary>
        /// <returns>Returns true if able to add, else returns false.</returns>
        public bool addNewCourseAndUserConnection(UsersAndCoursesViewModel connectionToAdd)
        {
            bool successfullyAdded = false;

            Models.Entities.UsersAndCourses addConnection = new Models.Entities.UsersAndCourses()
            {
                userID = connectionToAdd.userID,
                courseID = connectionToAdd.courseID
            };

            _db.UsersAndCourses.Add(addConnection);

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
                var query = (from course in _db.Courses
                             where course.courseID == courseToChange.courseID
                             select course).SingleOrDefault();

                if (query != null)
                {
                    query.name = courseToChange.courseName;
                    query.description = courseToChange.courseDescription;
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
        /// Function fetches a user list of all users in a course.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ICollection<UserViewModel> getUsersInCourse(int courseID)
        {
            var courseUsersQuery = (from courseUsers in _db.UsersAndCourses
                                    where courseUsers.courseID == courseID
                                    join users in _db.Users
                                    on courseUsers.userID equals users.userID
                                    select users).ToList();

            var courseUsersModel = new List<UserViewModel>();

            foreach (var user in courseUsersQuery)
            {
                courseUsersModel.Add(new UserViewModel
                {
                    userID = user.userID,
                    username = user.username,
                    email = user.email,
                    fullName = user.fullName,
                    role = user.role,
                    phoneNumber = user.phoneNumber
                });
            }

            return courseUsersModel;
        }

        /// <summary>
        /// Function fetches a user list of all teachers in a course.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ICollection<UserViewModel> getTeachersInCourse(int courseID)
        {
            var courseTeachersQuery = (from user in getUsersInCourse(courseID)
                                       where user.role == "Teacher"
                                       select user).ToList();

            var courseTeachersModel = new List<UserViewModel>();

            foreach (var teacher in courseTeachersQuery)
            {
                courseTeachersModel.Add(new UserViewModel
                {
                    userID = teacher.userID,
                    username = teacher.username,
                    email = teacher.email,
                    role = teacher.role,
                    fullName = teacher.fullName,
                    phoneNumber = teacher.phoneNumber
                });
            }

            return courseTeachersModel;
        }

        /// <summary>
        /// Function fetches a user list of all students in a course.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ICollection<UserViewModel> getStudentsInCourse(int courseID)
        {
            var courseStudentsQuery = (from user in getUsersInCourse(courseID)
                                       where user.role == "Student"
                                       select user).ToList();

            var courseStudentsModel = new List<UserViewModel>();

            foreach (var student in courseStudentsQuery)
            {
                courseStudentsModel.Add(new UserViewModel
                {
                    userID = student.userID,
                    username = student.username,
                    email = student.email,
                    role = student.role,
                    fullName = student.fullName,
                    phoneNumber = student.phoneNumber
                });
            }

            return courseStudentsModel;
        }

        /// <summary>
        /// Function fetches a user list of all users not in course.
        /// </summary>
        /// <param name="courseID"></param>
        /// <returns></returns>
        public ICollection<UserViewModel> getUsersNotInCourse(int courseID)
        {
            var courseNonUsersQuery = (from users in _db.Users
                                       where !(from courseUsers in getUsersInCourse(courseID)
                                               select courseUsers.userID).Contains(users.userID)
                                       select users).ToList();

            var courseNonUsersModel = new List<UserViewModel>();

            foreach (var user in courseNonUsersQuery)
            {
                courseNonUsersModel.Add(new UserViewModel
                {
                    userID = user.userID,
                    username = user.username,
                    email = user.email,
                    role = user.role,
                    fullName = user.fullName,
                    phoneNumber = user.phoneNumber
                });
            }

            return courseNonUsersModel;
        }

        public UsersAndCoursesViewModel getAssigningCourseByCourseID(int courseID)
        {
            var courseQuery = (from course in _db.Courses
                               where course.courseID == courseID
                               select course).SingleOrDefault();

            var courseModel = new UsersAndCoursesViewModel()
            {
                courseID = courseQuery.courseID,
                courseName = courseQuery.name
            };

            return courseModel;
        }

        public List<SelectListItem> getAllUsersForAssigning(UsersAndCoursesViewModel course)
        {
            List<SelectListItem> listSelectListItems = new List<SelectListItem>();



            foreach (Users user in _db.Users)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = user.username,
                    Value = user.userID.ToString()
                };
                listSelectListItems.Add(selectList);
            }
            return listSelectListItems;
        }
    }
}