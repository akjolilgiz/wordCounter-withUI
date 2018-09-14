using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/repeatCounter")]
        public ActionResult Form()
        {
          return View();
        }


        [HttpGet("/repeatCounter/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/repeatCounter")]
        public ActionResult Create(string word, string sentence)
        {
            RepeatCounter myItem = new RepeatCounter(word, sentence);
            return RedirectToAction("Index");
        }
    }
}
