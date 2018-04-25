using System;
using System.Collection.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Controllers;
using ToDoList.Models;

namespace AnagramMatch.Controllers
{
  public class HomeController : Controllers
  {
    [Route("/")]
    public ActionResult Index()
    {
      //home page
      return View();
    }
    [HttpGet("/anagrammatch/")]
    public ActionResult Form()
    {
      AnagramMatch _userInputs = new AnagramMatch();
      _userInputs.GetMarker("");
      _userInputs.GetAll("");
      return View(_userInputs);
    }

    public ActionResult Index()
    {
      AnagramMatch
    }

  }
}
