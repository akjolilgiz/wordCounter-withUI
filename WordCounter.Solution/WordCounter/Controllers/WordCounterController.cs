using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class RepeatCounterController : Controller
    {

        [HttpGet("/repeatCounter")]
        public ActionResult Index()
        {
          return View();
        }


        [HttpGet("/repeatCounter/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/repeatCounter")]
        public ActionResult Create()
        {
            RepeatCounter newCount = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);

            return RedirectToAction("Index");
        }
    }
}
