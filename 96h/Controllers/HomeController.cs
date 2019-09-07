using _96h.Models;
using _96h.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _96h.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRequestFlurl _requestFlurl;
        private string edrpouRegex = @"[0-9]{8}";

        public HomeController(IRequestFlurl requestFlurl)
        {
            _requestFlurl = requestFlurl; // ?? throw new ArgumentNullException(nameof(requestFlurl));
        }
        private void UserIsAuthenticated()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData["user"] = User.Identity.Name;
            }
        }

        [Route("company/{edrpou}")]
        [Route("company")]
        [Route("")]
        public async Task<IActionResult> Index(string edrpou = null)
        {
            //Dossier
            UserIsAuthenticated();

            if (edrpou != null && Regex.IsMatch(edrpou, edrpouRegex))
            {
                string apiMethod = "Dossier/";
                ResponseObject<Dossier> responseObject = await _requestFlurl.GetRequestAsync<ResponseObject<Dossier>>(apiMethod + edrpou);

                return View(responseObject.Response);
            }
            else
            {
                TempData["homeMess"] = "Нічого не знайдено...(";
                return View();
            }
        }

        [Authorize]
        [Route("communications/{edrpou}")]
        [Route("communications")]
        public async Task<IActionResult> Communications(string edrpou = null)
        {
            //Communication
            UserIsAuthenticated();

            if (edrpou != null && Regex.IsMatch(edrpou, edrpouRegex))
            {
                string apiMethod = "Communication/";
                ResponseObject<Communication> responseObject = await _requestFlurl.GetRequestAsync<ResponseObject<Communication>>(apiMethod + edrpou);
                return View(responseObject.Response);
            }
            else
            {
                TempData["homeMess"] = "Нічого не знайдено...(";
                return View();
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
