using Musaca.Models;
using System.Collections.Generic;
using System.Linq;

namespace Musaca.Services
{
    public interface IUserService
    {
        User CreateUser(User user);

        User GetUserByUsernameAndPassword(string username, string password);

        IQueryable<Order> GetOrdersByUsername(string id);
    }
}
