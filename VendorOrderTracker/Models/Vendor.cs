using System.Linq;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> OrderList { get; set; }
    public int Id { get; }
    private static Dictionary<int, Vendor> _instances = new Dictionary<int, Vendor> {};
    private static int _idCount = 0;
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      OrderList = new List<Order>{};
      Id = _idCount;
      _idCount ++;
      _instances.Add(Id, this);
    }

    public static List<Vendor> GetAll()
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

    public static Vendor Find(int id)
    {
      return _instances[id];
    }

    public static void Delete(int id)
    {
      Vendor toDelete = Vendor.Find(id);
      foreach(Order order in toDelete.OrderList)
      {
        Order.Remove(order.Id);
      }
      _instances.Remove(id);
    }

    public void AddOrder(Order inputOrder)
    {
      inputOrder.VendorName = Name;
      inputOrder.VendorId = Id;
      OrderList.Add(inputOrder);
    }

    public void RemoveOrder(Order inputOrder)
    {
      OrderList.Remove(inputOrder);
      Order.Remove(inputOrder.Id);
    }
  }
}