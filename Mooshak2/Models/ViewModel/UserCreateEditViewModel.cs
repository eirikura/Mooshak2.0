using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The user creation and editing view model is responsible for creating and editing users.
    /// It allows for creating and editing existing users and also managing their roles.
    /// Access only granted to administrators.
    /// </summary>
    public class UserCreateEditViewModel
    {
        /// <summary>
        /// The users ID number.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// The users username.
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// The users password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// The users email address.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// The users full name.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// The users role ID.
        /// </summary>
        public int roleID { get; set; }

        /// <summary>
        /// The users phone number.
        /// </summary>
        public int phoneNumber { get; set; }

        /// <summary>
        /// The address to users profile picture.
        /// </summary>
        public string userPicture { get; set; }
    }
}