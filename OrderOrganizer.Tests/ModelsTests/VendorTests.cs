using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using OrderOrganizer.Models;

namespace OrderOrganizer.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Wonder", "Helps build strong bodies 12 ways!");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Wonder Bread";
      string description = "Helps build strong bodies 12 ways!";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Wonder Bread";
      string description1 = "Helps build strong bodies 12 ways!";
      string name2 = "Bimbo";
      string description2 = "Worldwide bakery!";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Wonder Bread";
      string description1 = "Helps build strong bodies 12 ways!";
      string name2 = "Bimbo";
      string description2 = "Worldwide bakery!";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.FindVendor(newVendor1.Name);
      Assert.AreEqual(newVendor1, result);
    }
    [TestMethod]
    public void AddVendor_AddOrderToVendor_OrderList()
    {
      string description = "10 loaves";
      string name = "Bimbo";
      string date = "12/22/22";
      string type = "bread";
      Order newOrder = new Order(name, description, date, type);
      List<Order> newOrderList = new List<Order> { newOrder };
      string vendorName = "Wonder Bread";
      string description1 = "Helps build strong bodies 12 ways!";
      Vendor newVendor = new Vendor(vendorName, description1);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}