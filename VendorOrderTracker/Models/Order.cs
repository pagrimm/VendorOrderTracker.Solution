using System;
using System.Linq;
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
    public string VendorName { get; set;}
    public int VendorId { get; set; }
    private static Dictionary<int, Order> _instances = new Dictionary<int, Order> {};
    private static int _idCount = 0;
    
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Parse(date);
      Id = _idCount;
      VendorName = null;
      VendorId = -1;
      _idCount ++;
      _instances.Add(Id, this);
    }

    public static List<Order> GetAll()
    {
      return _instances.Values.ToList();
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void ClearIdCount()
    {
      _idCount = 0;
    }

    public static Order Find(int id)
    {
      return _instances[id];
    }

    public static void Remove(int id)
    {
      if (_instances[id].VendorId != -1)
      {
        Vendor.Find(_instances[id].VendorId).OrderList.Remove(_instances[id]);
      }
      _instances.Remove(id);
    }
  }
}