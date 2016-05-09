using Mooshak2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Services
{
    /// <summary>
    /// Services are mainly used to connect entities to the database and retrieve/submit data
    /// from tables, for example: getUsernameByUserID returns an username assigned to the given user ID.
    /// </summary>
    public class AccountsService
    {
        /// <summary>
        /// Returns the username for an user with the given user ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getUsernameByUserID(int userId)
        {
            return null;
        }

        /// <summary>
        /// Returns the password for an user with the given user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getPasswordByUserID(int userID)
        {
            return null;
        }

        /// <summary>
        /// Returns the full name of an user with the given user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getFullNameByUserID(int userID)
        {
            return null;
        }

        /// <summary>
        /// Returns the role ID of an user by the specified user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getRoleIDByUserID(int userID)
        {
            return null;
        }

        /// <summary>
        /// Returns an users ID by the given username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getUserIDByUsername(string username)
        {
            return null;
        }
    }
}