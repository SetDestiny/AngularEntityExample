using System.Collections.Generic;
using System.Linq;
using AngularEntityExample.Data;
using AngularEntityExample.DataAccess.Contexts;

namespace AngularEntityExample.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IList<User> GetUsersList()
        {
            var userContext = new UserContext();
            return userContext.Users.ToList();
        }

        public void CreateUser(User user)
        {
            var userContext = new UserContext();
            userContext.Users.Add(user);
            userContext.SaveChanges();
        }
    }
}