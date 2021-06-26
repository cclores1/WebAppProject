using Microsoft.AspNetCore.Mvc;
using RegAndLogIn.Models;
using RegAndLogIn.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegAndLogIn.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securitySerivce = new SecurityService();
            if(securitySerivce.isValid(userModel))
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LogInFailure", userModel);

            }
        }
    }
}
