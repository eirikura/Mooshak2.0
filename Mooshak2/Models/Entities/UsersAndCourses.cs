﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// This entity connects users(teachers and students) to courses.
    /// Only admin is able to assign users to courses and
    /// an user might be assigned to the course either as a teacher or a student.
    /// </summary>
    public class UsersAndCourses
    {
        [Key]
        /// <summary>
        /// An ID number of an user used to connect an user with a course.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// An ID number of an course used to connect a course with an user.
        /// </summary>
        public int courseID { get; set; }

    }
}