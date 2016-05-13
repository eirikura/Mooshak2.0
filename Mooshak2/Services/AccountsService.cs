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
        /// Returns a list of all students
        /// </summary>
        /// <returns></returns>
        public ICollection<UserViewModel> getAllUsers()
        {/*
            var coursesQuery = (from course in _db.Courses
                                select course).ToList();

            var coursesModel = new List<CourseViewModel>();

            foreach (var course in coursesQuery)
            {
                coursesModel.Add(new CourseViewModel
                {
                    courseID = course.courseID,
                    courseName = course.name,
                    courseDescription = course.description
                });
            }*/




            var user = (from u in _db.Users
                        select u).ToList();

            var usersModel = new List<UserViewModel>();

            foreach (var u in user)
            {
                usersModel.Add(new UserViewModel
                {
                    username = u.username,
                    userID = u.userID
                });
            }

            return usersModel;
        }

        /// <summary>
        /// Returns an user with the given user ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getUserByUserID()
        {
            var currUserName = HttpContext.Current.User.Identity.GetUserName();

            var u = (from n in _db.Users
                     where n.email == currUserName
                     select n).SingleOrDefault();

            var model = new UserCreateEditViewModel
            {
                username = u.username,
                email = u.email,
                fullName = u.fullName
            };
            return model;
        }

        /// <summary>
        /// Returns the username for an user with the given user ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserCreateEditViewModel getUserByEmail(int userID)
        {
            var u = (from n in _db.Users
                     where n.userID == userID
                     select n).SingleOrDefault();

            var model = new UserCreateEditViewModel
            {
                username = u.username,
                email = u.email,
                fullName = u.fullName,
                phoneNumber = u.phoneNumber,
                role = u.role
            };
            return model;
        }

        public Users getUserByID(int userID)
        {
            var user = (from n in _db.Users
                        where n.userID == userID
                        select n).SingleOrDefault();

            return user;
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

        /// <summary>
        /// Adds a new user to the user table
        /// </summary>
        /// <param name="model"></param>
        public void newUser(RegisterViewModel model)
        {
            var newUser = new Users();

            newUser.email = model.Email;
            newUser.username = model.Email;
            newUser.fullName = model.FullName;
            newUser.phoneNumber = model.PhoneNumber;
            newUser.role = model.Role;

            _db.Users.Add(newUser);
            
            _db.SaveChanges();
        }

        /// <summary>
        /// Edits a user in a table
        /// </summary>
        /// <param name="model"></param>
        /// <param name="userID"></param>
        public void editUser(Users model, int userID)
        {
            var user = (from n in _db.Users
                     where n.userID == userID
                     select n).SingleOrDefault();

            user.email = model.email;
            user.fullName = model.fullName;
            user.phoneNumber = model.phoneNumber;
            user.role = model.role;

            _db.SaveChanges();
        }
    }
}