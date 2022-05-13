using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderOrganizer.Models;

namespace OrderOrganizer.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}