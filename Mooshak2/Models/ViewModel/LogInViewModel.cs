using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class LogInViewModel
    {
        /// <summary>
        /// Used to get the users username, for the log in process.
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Used to get the users password, for the log in process.
        /// </summary>
        public string password { get; set; }
    }
}