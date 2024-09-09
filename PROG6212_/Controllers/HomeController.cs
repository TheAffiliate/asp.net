//using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using PROG6212.Models;
using System.Diagnostics;

namespace PROG6212.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            return View();
        }

        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult CreateSubmitClaimForm(ClaimFormModel model)
        {
            return RedirectToAction("Index");
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle sign-up logic (e.g., save to database)
                return RedirectToAction("LogIn"); // Or another action
            }
            return View(model);
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle login logic (e.g., authenticate user)
                return RedirectToAction("SubmitClaim"); // Or another action
            }
            return View(model);
        }

        public IActionResult VerifyClaim(int id)
        {
            // Find the claim by ID (uncomment and implement as needed)
            // Example: var claim = _dbContext.Claims.Find(id);
            return View(/*claim*/);
        }

        [HttpPost]
        public IActionResult VerifyClaim(VerificationModel model)
        {
            if (ModelState.IsValid)
            {
                // Update claim status (uncomment and implement as needed)
                // Example: var claim = _dbContext.Claims.Find(model.ClaimId);
                // claim.Status = model.Status;
                // _dbContext.SaveChanges();

                return RedirectToAction("ClaimStatus");
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
