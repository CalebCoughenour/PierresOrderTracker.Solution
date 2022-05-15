using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    public int Price { get; set; }
    public string OrderType { get; set; }
    public bool PriceAdjusted { get; set; }
    private static List<Order> _orders = new List<Order>{ };


    public Order(string orderName, string orderDescription, string orderDate, string orderType)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderType = orderType;
      _orders.Add(this);
      Id = _orders.Count;
      Price = 5;
      PriceAdjusted = false;
    }

    public static void PriceAdjuster(string orderType) 
    {
      foreach (Order order in _orders)
      {
        if(orderType == "bread" && order.PriceAdjusted == false)
        {
          order.Price += 1;
          order.PriceAdjusted = true;
        }
        else
        {
          order.Price += 2;
          order.PriceAdjusted = true;
        }
      }
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