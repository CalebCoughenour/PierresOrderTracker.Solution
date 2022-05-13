using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    public int Price { get; }
    private static List<Order> _orders = new List<Order>{ };


    public Order(string orderName, string orderDescription, string orderDate)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      _orders.Add(this);
      Id = _orders.Count;
      Price = 5;
    }
    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }
    public static Order FindOrder(string name)
    {
      foreach (Order order in _orders)
      {
        if (name == order.OrderName)
        {
          return order;
        }
      }
      return null;
    }
    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }
  }
}