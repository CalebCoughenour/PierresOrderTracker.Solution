using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using OrderOrganizer.Models;

namespace OrderOrganizer.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testname", "testdescription", "testdate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "testdescription";
      Order newOrder = new Order("testname", description, "testdate");
      string result = newOrder.OrderDescription;
      Assert.AreEqual(description, result);
    }
  }
}