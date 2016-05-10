using System;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// An assignment for a specific course, may be divided into many parts.
    /// Teacher creates assignments which students have to solve and submit.
    /// </summary>
    public class Assignments
    {
        /// <summary>
        /// An unique auto-generated ID number of an assignment.
        /// </summary>
        public int assignmentID { get; set; }

        /// <summary>
        /// An unique ID used to connect an assignment with a course.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// An unique ID used to connect an assignment with its parts.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// A name(title) of an assignment.
        /// </summary>
        public string assignmentName { get; set; }

        /// <summary>
        /// The due time of an assignment. The assignment cannot be longer submitted past
        /// this specified due time.
        /// </summary>
        public DateTime assignmentDueDate { get; set; }


    }
}