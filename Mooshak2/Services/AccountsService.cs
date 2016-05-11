using Microsoft.AspNet.Identity;
using Mooshak2.Models;
using Mooshak2.Models.Entities;
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
        private ApplicationDbContext _db;

        public AccountsService ()
        {
            _db = new ApplicationDbContext();
        }


        /// <summary>
        /// Returns the username for an user with the given user ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getUsernameByUserID()
        {
            
            var currentUser = HttpContext.Current.User.Identity.GetUserId();
            int x = int.Parse(currentUser);
            var user = (from n in _db.Users
                        where n.userID == x
                        select n).SingleOrDefault();

            var currUserName = HttpContext.Current.User.Identity.GetUserName();

            var u = (from n in _db.Users
                     where n.email == currUserName
                     select n).SingleOrDefault();


            var viewModel = new UserCreateEditViewModel
            {
                username = user.username,
                email = user.email,
                fullName = user.fullName
            };
            // return viewModel;

            var model = new UserCreateEditViewModel
            {
                username = u.username,
                email = u.email,
                fullName = u.fullName
            };
            return model;
        }

        /// <summary>
        /// Returns the password for an user with the given user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getPasswordByUserID(int userID)
        {
            var password = _db.Users.SingleOrDefault(x => x.userID == userID);

            var viewModel = new UserCreateEditViewModel
            {
                password = password.password
            };
            return viewModel;
        }

        /// <summary>
        /// Returns the full name of an user with the given user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getFullNameByUserID(int userID)
        {
            var fullName = _db.Users.SingleOrDefault(x => x.userID == userID);

            var viewModel = new UserCreateEditViewModel
            {
                fullName = fullName.fullName
            };
            return viewModel;
        }

        /// <summary>
        /// Returns the role ID of an user by the specified user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getRoleIDByUserID(int userID)
        {
            var roleID = _db.Users.SingleOrDefault(x => x.userID == userID);

            var viewModel = new UserCreateEditViewModel
            {
                roleID = roleID.roleID
            };
            return viewModel;
        }

        /// <summary>
        /// Returns an users ID by the given username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getUserIDByUsername(string username)
        {
            var userID = _db.Users.SingleOrDefault(x => x.username == username);

            var viewModel = new UserCreateEditViewModel
            {
                userID = userID.userID
            };
            return viewModel;
        }
    }
}