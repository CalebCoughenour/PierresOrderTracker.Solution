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
    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      string description1 = "testdescription1";
      string name1 = "testname1";
      string date1 = "testdate1";
      string description2 = "testdescription2";
      string name2 = "testname2";
      string date2 = "testdate2";
      Order newOrder1 = new Order(name1, description1, date1);
      Order newOrder2 = new Order(name2, description2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}