using System.Data.Entity;
using AngularEntityExample.Data;

namespace AngularEntityExample.DataAccess.Contexts
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}