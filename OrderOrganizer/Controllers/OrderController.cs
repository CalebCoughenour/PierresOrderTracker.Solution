using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderOrganizer.Models;

namespace OrdersOrganizer.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Show()
    {
      List<Order> orders = Order.GetAll();
      return View(orders);
    }
    
    [HttpGet("/vendors/{vendorName}/orders/new")]
    public ActionResult New(string vendorName)
    {
      Vendor vendor = Vendor.FindVendor(vendorName);
      return View("New", vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", order);
      model.Add("vendors", vendor);
      return View(model);
    }
  }
}