using Microsoft.AspNetCore.Mvc;
using FeedbackApp.Models;

namespace FeedbackApp.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: Feedback/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                // Save feedback to database or perform other actions
                return RedirectToAction("Success");
            }

            // If validation fails, return to the feedback form with errors
            return View(feedback);
        }

        // GET: Feedback/Success
        public IActionResult Success()
        {
            return View();
        }
    }
}