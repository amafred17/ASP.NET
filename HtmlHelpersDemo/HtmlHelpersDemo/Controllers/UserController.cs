using Microsoft.AspNetCore.Mvc;
using HtmlHelpersDemo.Models;

namespace HtmlHelpersDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            var model = new UserModel
            {
                Skills = new List<string> { "C#", "JavaScript", "Python", "Java" },
                Country = "USA" // Default value for dropdown
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Save the user model to the database or perform other actions
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}