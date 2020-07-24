using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controllers
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Orders> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor inputVendor = Vendor.Find(vendorId);
      return View(inputVendor);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Vendor inputVendor = Vendor.Find(vendorId);
      Order inputOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      inputVendor.AddOrder(inputOrder);
      return RedirectToAction("Index", "Vendors");
    }

    [HttpGet("/orders/{orderId}")]
    public ActionResult Show(int orderId)
    {
      Order inputOrder = Order.Find(orderId);
      return View(inputOrder);
    }
  }
}