using Microsoft.AspNetCore.Mvc;

namespace Blogie.Web.Controllers
{
    public class AdminTagController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmmitTag()
        {
            var name = Request.Form["name"];
            var displayName= Request.Form["displayName"];
            return View("Add");

        }
    }
}
