using System.Diagnostics;
using Cashier.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cashier.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
