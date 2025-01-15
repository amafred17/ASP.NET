using Microsoft.AspNetCore.Mvc;
using UserRegistrationApp.Models;

namespace UserRegistrationApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Save user to database or perform other actions
                return RedirectToAction("Success");
            }

            // If validation fails, return to the registration form with errors
            return View(user);
        }

        // GET: User/Success
        public IActionResult Success()
        {
            return View();
        }
    }
}