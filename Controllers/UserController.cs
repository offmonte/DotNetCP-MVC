using DotNetCP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCP.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {

            User user = new User
            {
                Id = 1,
                Name = "Lucas",
                Email = "lucas@mail.com",
                Password = "RM551604"
            };

            return View(User);


        }
    }
}