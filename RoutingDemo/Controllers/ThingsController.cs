using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shortid;

namespace RoutingDemo.Controllers
{
    [Route("stuff/[action]")]
    public class ThingsController : Controller
    {
        public IActionResult Index()
        {
            return Json(new
            {
                controller = "Things",
                Action = "Index",
                Hash = ShortId.Generate(7)
            });
        }

        public IActionResult Other()
        {
            return Json(new { controller = "Things", Action = "Other" });
        }

        public IActionResult Whatever()
        {
            return Json(new { controller = "Things", Action = "Whatever" });
        }
    }
}

// https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-2.2?

    //http://localhost:10273/r$3d2m



