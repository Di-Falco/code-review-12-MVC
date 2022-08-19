using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using ParksMVC.Models;

namespace ParksMVC.Controllers
{
  public class ParksController : Controller
  {
    public IActionResult Index()
    {
      var allParks = Park.GetParks();
      return View(allParks);
    }

    [HttpPost]
    public async Task<ActionResult> Create(string name, string location, string description, string photoUrl)
    {
      Park park = new Park { Name = name, Location = location, Description = description, PhotoUrl = photoUrl};
      await Task.Run(() => Park.Post(park));
      return RedirectToAction(Request.Headers["Referer"].ToString());
    }

    public ActionResult Edit(int id)
    {
      return View(Park.GetDetails(id));
    }

    [HttpPost]
    public async Task<ActionResult> Delete(int id)
    {
      await Task.Run(() => Park.Delete(id));
      return RedirectToAction("Index");
    }
  }
}