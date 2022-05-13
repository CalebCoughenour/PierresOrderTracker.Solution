using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    private static List<Order> _orders = new List<Order>{ };


    public Order(string orderName, string orderDescription, string orderDate)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      _orders.Add(this);
    }
    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }
  }
}