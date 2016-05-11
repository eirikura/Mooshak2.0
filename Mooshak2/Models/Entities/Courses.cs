﻿using System.ComponentModel.DataAnnotations;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// Courses are added into the system by an admin.
    /// The there is an special table named UsersAndCourses used to assign
    /// users to courses.
    /// Assignments are then made for a specified course.
    /// </summary>
    public class Courses
    {
        [Key]
        /// <summary>
        /// An unique auto-generated ID number of an course.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// A name(title) of a course
        /// </summary>
        public string courseName { get; set; }

        /// <summary>
        /// A short description of a course.
        /// </summary>
        public string courseDescription { get; set; }
    }
}