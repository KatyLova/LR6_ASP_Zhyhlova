using LR6_ASP_Zhyhlova.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LR6_ASP_Zhyhlova.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
