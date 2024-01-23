using CarCatalogyProject.Data;
using CarCatalogyProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogyProject.Controllers
{
    public class ContactsController : Controller
    {
        private readonly AppDBContent _appDBContent;

        public ContactsController(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
