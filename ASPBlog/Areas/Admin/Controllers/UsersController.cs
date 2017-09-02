using System.Web.Mvc;

namespace ASPBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return Content("Users!");
        }
    }
}