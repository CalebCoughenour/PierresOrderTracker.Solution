using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderOrganizer.Models;

namespace OrdersOrganizer.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorName}/orders/new")]
    public ActionResult New(string vendorName)
    {
      Vendor vendor = Vendor.FindVendor(vendorName);
      return View(vendor);
    }
  }
}