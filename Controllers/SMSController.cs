using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using ConManApp.EnModels;
using ConManApp.Models;
using Nexmo.Api;
using ConManApp.DB;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Web.Http.ExceptionHandling;

namespace ConManApp.Controllers
{
    public class SMSController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(string text, string to = "38761290107")
        {
            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "fcb21fdd",
                ApiSecret = "JNid181Jk460e6E3"
            });
            var results = client.SMS.Send(request: new SMS.SMSRequest
            {
                from = "Poslovodja",
                to = to,
                text = text
            });
            return View();
        }


    }
}
