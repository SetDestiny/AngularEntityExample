using System.Web.Mvc;
using AngularEntityExample.Data;
using AngularEntityExample.DataAccess.Repositories;

namespace AngularEntityExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IUserRepository da = new UserRepository();
            var users = da.GetUsersList();
            return View(users);
        }

        public ActionResult CreateUser(User user)
        {
            if (ModelState.IsValid && ModelState.Count!=0)
            {
                IUserRepository da = new UserRepository();
                da.CreateUser(user);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}