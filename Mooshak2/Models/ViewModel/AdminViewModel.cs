using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// Frontpage for the Admin. Shows latest changes for assignments added, user created or 
    /// course created in a list. Home,  Users, Courses and settings buttons should be displayed on the frontpage.
    /// </summary>
    public class AdminViewModel
    {
        /// <summary>
        /// Full name of the admin that is logged in.
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// List of the latest changes for changes like assignment added, user created or course created.
        /// </summary>
        public List<AssignmentViewModel> latestChanges { get; set; }
    }
}