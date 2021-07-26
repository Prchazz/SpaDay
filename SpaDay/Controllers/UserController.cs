using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        
        // GET: /<controller>/
        [Route("/User/Add")]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Index ()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password == verify)
            {
                ViewBag.newPerson = newUser;
                return View("Index");
            }
            else
                @ViewBag.username = newUser.UserName;
                @ViewBag.email = newUser.Email;
                ViewBag.ErrorMessage = "Password does not match, please try again.";
                return View("add");
        }
    }
}
