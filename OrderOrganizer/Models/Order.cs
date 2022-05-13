using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Order
  {
    public string OrderName {get; set;}
    public string OrderDescription {get; set;}
    public string OrderDate {get; set;}
    private static double _Price = 5;

  }
}