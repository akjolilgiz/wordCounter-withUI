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
          List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
          return View(allRepeatCounters);
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
            int countNumber = newCount.Count();
            newCount.SetCount(countNumber);


            return View("Index", newCount);
        }
    }
}
