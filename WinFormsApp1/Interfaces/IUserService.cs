using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Interfaces
{
    interface IUserService
    {
        [Post("/user/create")]
        Task<User> create([Body] User user);
        [Put("/user/update")]
        Task<User> update([Body] User user);

        [Get("/user")]
        Task<User> SignIn([Body] User user);

        [Get("/users")]
        Task<List<User>> GetUsers();

    }
}
