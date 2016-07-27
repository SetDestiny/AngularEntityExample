using System.Web.Mvc;
using AngularEntityExample.Data;
using AngularEntityExample.DataAccess.Repositories;

namespace AngularEntityExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IUserRepository rep = new UserRepository();
            var users = rep.GetUsersList();
            return View(users);
        }

        public ActionResult CreateUser(User user)
        {
            if (ModelState.IsValid && ModelState.Count!=0)
            {
                IUserRepository rep = new UserRepository();
                rep.CreateUser(user);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}