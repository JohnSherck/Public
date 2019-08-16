using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.DAL
{
    public interface IUserDAL
    {
        /// <summary>
        /// Retrieves a user from the system by username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        User GetUser(string username);

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="user"></param>
        void CreateUser(User user);

        /// <summary>
        /// Updates a user.
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(User user);

        /// <summary>
        /// Deletes a user from the system.
        /// </summary>
        /// <param name="user"></param>
        void DeleteUser(User user);


        /// <summary>
        /// Updates a users personal information
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <param name="firstName">The user's first name</param>
        /// <param name="lastName">The user's last name</param>
        /// <param name="city">The user's city</param>
        /// <param name="state">The user's state</param>
        /// <param name="zip">The user's zip code</param>
        /// <param name="address">The user's home/billing address</param>
        /// <param name="email">The user's email address</param>
        void UpdateUser(User user, string firstName, string lastName, string city, string state, string zip, string address, string email);
    }
}
