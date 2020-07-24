using System.Linq;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> OrderList { get; }
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
  }
}