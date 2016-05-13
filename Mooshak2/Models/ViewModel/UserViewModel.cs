using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The user creation and editing view model is responsible for creating and editing users.
    /// It allows for creating and editing existing users and also managing their roles.
    /// Access only granted to administrators.
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// The users ID number.
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// The users username.
        /// </summary>
        [Display(Name = "Username")]
        public string username { get; set; }

        /// <summary>
        /// The users email address.
        /// </summary>
        [Display(Name = "Email")]
        public string email { get; set; }

        /// <summary>
        /// The users full name.
        /// </summary>
        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        /// <summary>
        /// The users phone number.
        /// </summary>
        [Display(Name = "Phone Number")]
        public int phoneNumber { get; set; }

        /// <summary>
        /// This is the role user is currently assigned to.
        /// </summary>
        [Display(Name = "Role")]
        public string role { get; set; }
    }
}