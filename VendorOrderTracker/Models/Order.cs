using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set;}
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    private static int _idCount = 0;
    
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Parse(date);
      Id = _idCount;
      _idCount ++;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void ClearIdCount()
    {
      _idCount = 0;
    }
  }
}