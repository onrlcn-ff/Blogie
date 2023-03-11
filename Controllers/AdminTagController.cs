using Blogie.Web.Models.ViewModels;
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
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //var name = Request.Form["name"];
            //var displayName= Request.Form["displayName"];

            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;
            return View("Add");

        }
    }
}
