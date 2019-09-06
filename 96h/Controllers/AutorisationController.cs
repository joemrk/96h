using _96h.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _96h.Controllers
{
    public class AutorisationController : Controller
    {
        [Route("login")]
        public async Task<IActionResult> Login(UserModel model)
        {
            UserModel[] users = new UserModel[] {
                new UserModel { Id = 1, Name = "Mark1", Pass = "1" },
                new UserModel { Id = 2, Name = "Ann2", Pass = "2" },
                new UserModel { Id = 3, Name = "Joe3", Pass = "3" }
                };

            UserModel user = users.FirstOrDefault(u => u.Name == model.Name && u.Pass == model.Pass);

            if (user != null)
            {
                await Authenticate(model.Name);
                TempData["user"] = user.Name;;

                //di4
                string[] pathSegments = Request.Headers["Referer"].ToString().Split('%');
                
                if (Request.Headers["Referer"].ToString().Contains("communications"))
                    return Redirect("/communications/"+ pathSegments.Last().Remove(0,2));
                else return Redirect("/");
                //
            }
            else
            {
                TempData["authMess"] = "";
                return View();
            }
        }
        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [Route("exit")]
        public async Task<IActionResult> Exit()
        {
            TempData["user"] = null;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
    }
}