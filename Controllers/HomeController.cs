using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TriangleChecker.Models;

namespace TriangleChecker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View("TriangleForm");
        }

        [HttpGet("/TriangleResult")]
        public ActionResult TriangleResult()
        {
          Dictionary<string, object> Shapes = new Dictionary<string, object>();
          Triangle myTriangle = new Triangle(Int32.Parse(Request.Query["side-one"]), Int32.Parse(Request.Query["side-two"]), Int32.Parse(Request.Query["side-three"]));
          Shapes.Add("ResultingTriangle", myTriangle);
          return View(Shapes);
        }
    }
}
// Shapes is the new object that will be shown in the TriangleResult, to make sure it works you need to put the name "Shapes" in the view parameter
