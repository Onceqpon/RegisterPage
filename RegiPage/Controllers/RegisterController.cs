using Microsoft.AspNetCore.Mvc;
using RegiPage.Models;

namespace RegiPage.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Akcja obsługująca przesyłanie formularza
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                return View("Success", model);
            }
            else return View();

        }
        public IActionResult Success(User dane)
        {

            return View(dane);
        }
    }
}

