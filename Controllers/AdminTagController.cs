using Blogie.Web.Data;
using Blogie.Web.Models.Domain;
using Blogie.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blogie.Web.Controllers
{
    public class AdminTagController : Controller
    {
        private BlogieDBContext _blogieDbContext;
        public AdminTagController(BlogieDBContext blogieDBContext)
        {
            _blogieDbContext = blogieDBContext;
        }
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

            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };
            _blogieDbContext.Add(tag);
            _blogieDbContext.SaveChanges();
            return View("Add");
        }
        [HttpGet]
        public ActionResult List()
        {
            var tags = _blogieDbContext.Tags.ToList();
            return View(tags);
        }
    }
}
