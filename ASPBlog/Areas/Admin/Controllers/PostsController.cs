using System.Web.Mvc;

namespace ASPBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("Posts!");
        }
    }
}