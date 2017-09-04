using System.Web.Mvc;

namespace ASPBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return Content("Users!");
        }
    }
}