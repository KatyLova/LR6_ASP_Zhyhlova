using Microsoft.AspNetCore.Mvc;
using LR6_ASP_Zhyhlova.Models;

namespace LR6_ASP_Zhyhlova.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromQuery] int amountOfProducts, [FromQuery] string email, [FromQuery] uint age) => View(new UserToProductViewModel(amountOfProducts, email, age));

        [HttpPost]
        public IActionResult IndexPost([FromForm] UserToProductViewModel userToProductViewModel) =>
            View("ProductsList", userToProductViewModel);
    }
}
