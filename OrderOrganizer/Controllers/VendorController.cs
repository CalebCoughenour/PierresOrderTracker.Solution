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
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{vendorName}")]
    public ActionResult Show(string vendorName)
    {
      Vendor vendor = Vendor.FindVendor(vendorName);
      return View(vendor);
    }


  }
}