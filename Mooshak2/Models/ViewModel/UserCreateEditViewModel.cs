using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class UserCreateEditViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int roleID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int phoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string userPicture { get; set; }
    }
}