using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LeapYear.Models;
using System;

namespace LeapYear.Controllers
{
  public class LeapYearVariableController : Controller

  {
    [HttpGet("/leapyear")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/leapyear/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/leapyear/")]
    public ActionResult Create()
    {
      LeapYearVariable myLeapYearVariable = new LeapYearVariable();
      myLeapYearVariable.SetYear(int.Parse(Request.Form["year"]));
      return View("Index", myLeapYearVariable);
    }
  }
}
