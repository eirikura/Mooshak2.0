﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// This entity stores all the details about allthe users in the system.
    /// An users is created by an admin and he is assigned to a specific role.
    /// </summary>
    public class Users
    {

        /// <summary>
        /// An unique auto-generated ID number of an user.
        /// </summary>
        [Key]
        public int userID { get; set; }

        /// <summary>
        /// An username the user has and uses in order to log in to the system.
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// This is the email of the user.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// This is the full name of the user.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// This is the phone number the user has given.
        /// </summary>
        public int phoneNumber { get; set; }

        /// <summary>
        /// This is the role user is currently assigned to.
        /// </summary>
        public string role { get; set; }

    }
}