using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    private static double _Price = 5;
    private static List<Order> _orders = new List<Order>{ };

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }
    public Order(string orderName, string orderDescription, string orderDate)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      _Price = Price;
    }
    public static void ClearAll()
    {
      _orders.Clear();
    }
  }
}