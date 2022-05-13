using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor>{};
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      Orders = new List<Order>{};
      _vendors.Add(this);
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static Vendor FindVendor(string name)
    {
      foreach (Vendor vendor in _vendors)
      {
        if (name == vendor.Name)
        {
          return vendor;
        }
      }
      return null;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}