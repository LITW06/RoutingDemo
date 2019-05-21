using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Other", "Home");
        }

        [Route("contact/us")]
        public IActionResult Other()
        {
            return View();
        }

        public IActionResult GetData(int id)
        {
            return Json(new {id = id});
        }

        //   /simchas/73/contributions
        [Route("r/{text}")]
        public IActionResult Reverse(string text)
        {
            return Json(new
            {
                reverse = new string(text.Reverse().ToArray()),
                original = text
            });
        }

        [Route("simchas/{id}/contributions")]
        public IActionResult Stupid(int id)
        {
            return Json(new {SimchaId = id});
        }
    }
}
