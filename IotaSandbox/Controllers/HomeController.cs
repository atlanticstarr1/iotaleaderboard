using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IotaSandbox.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Receive()
        {
            ViewData["Message"] = "Leader board.";

            return View();
        }
        public IActionResult Send()
        {
            ViewData["Message"] = "Send Iota.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
