using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderOrganizer.Models;

namespace OrderOrganizer.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}