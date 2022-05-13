using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using OrderOrganizer.Models;

namespace OrderOrganizer.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Wonder", "Helps build strong bodies 12 ways!");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}