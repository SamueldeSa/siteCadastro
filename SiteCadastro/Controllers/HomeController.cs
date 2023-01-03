using Microsoft.AspNetCore.Mvc;
using SiteCadastro.Models;
using System.Diagnostics;

namespace SiteCadastro.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Name = "Samuel Vitor";
            home.Email = "samuel.vitor@gmail.com";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}