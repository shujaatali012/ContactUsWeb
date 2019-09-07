/// <summary>
/// HomeController Implementation
/// </summary>

namespace WebApp.Host.Controllers
{
    #region namespaces

    using System.Web.Mvc;

    #endregion

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home - WebApp";

            return View();
        }
    }
}
