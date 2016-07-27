using System.Collections.Generic;
using AngularEntityExample.Data;

namespace AngularEntityExample.DataAccess.Repositories
{
    public interface IUserRepository
    {
        IList<User> GetUsersList();
        void CreateUser(User user);
    }
}