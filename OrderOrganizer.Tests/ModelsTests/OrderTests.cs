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
      Order newOrder = new Order("testname", "testdescription", "testdate", "testtype");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "testdescription";
      Order newOrder = new Order("testname", description, "testdate", "testtype");
      string result = newOrder.OrderDescription;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      string description1 = "testdescription1";
      string name1 = "testname1";
      string date1 = "testdate1";
      string type1 = "testtype1";
      string description2 = "testdescription2";
      string name2 = "testname2";
      string date2 = "testdate2";
      string type2 = "testtype2";
      Order newOrder1 = new Order(name1, description1, date1, type1);
      Order newOrder2 = new Order(name2, description2, date2, type2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description1 = "testdescription1";
      string name1 = "testname1";
      string date1 = "testdate1";
      string type1 = "testtype1";
      string description2 = "testdescription2";
      string name2 = "testname2";
      string date2 = "testdate2";
      string type2 = "testtype2";
      Order newOrder1 = new Order(name1, description1, date1, type1);
      Order newOrder2 = new Order(name2, description2, date2, type2);
      Order result = Order.FindOrder(newOrder1.OrderName);
      Assert.AreEqual(newOrder1, result);
    }

    [TestMethod]
    public void PriceAdjuster_ChangesPriceBasedOffOrderType_Price()
    {
      string description = "testdesc";
      string name = "testname";
      string date = "testdate";
      string type = "bread";
      Order newOrder = new Order(name, description, date, type);
      Order.PriceAdjuster(newOrder.OrderType);
      Assert.AreEqual(6, newOrder.Price);
    }
  }
}