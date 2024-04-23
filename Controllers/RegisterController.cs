using Microsoft.AspNetCore.Mvc;
using live_auction_portal.Models; // Assuming Models.cs exists

namespace live_auction_portal.Controllers.RegisterController
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

