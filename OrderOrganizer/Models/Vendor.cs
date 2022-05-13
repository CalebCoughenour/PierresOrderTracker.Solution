using System.Collections.Generic;

namespace OrderOrganizer
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor>{};
    public string Name {get; set;}
    public string Description {get; set;}
    public List<Order> Orders {get; set;}

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      Orders = new List<Order>{};
      _vendors.Add(this);
    }
  }
}