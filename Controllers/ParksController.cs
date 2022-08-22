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
  [Authorize]
  public class ParksController : Controller
  {
    [AllowAnonymous]
    public IActionResult Index()
    {
      var allParks = Park.GetParks();
      return View(allParks);
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      return View(Park.GetDetails(id));
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(string name, string location, string description, string photoUrl)
    {
      Park park = new Park { Name = name, Location = location, Description = description, PhotoUrl = photoUrl};
      await Task.Run(() => Park.Post(park));
      return RedirectToAction("Index", "Parks");
    }

    public ActionResult Edit(int id)
    {
      return View(Park.GetDetails(id));
    }

    [HttpPost]
    public async Task<ActionResult> Edit(Park park)
    {
      await Task.Run(() => Park.Put(park));
      return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<ActionResult> Delete(int id)
    {
      await Task.Run(() => Park.Delete(id));
      return RedirectToAction("Index");
    }
  }
}