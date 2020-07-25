using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
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

    [HttpPost("/orders/{orderId}")]
    public ActionResult Destroy(int orderId)
    {
      Order orderToDelete = Order.Find(orderId);
      Vendor ownerVendor = Vendor.Find(orderToDelete.VendorId);
      ownerVendor.RemoveOrder(orderToDelete);
      return RedirectToAction("Index");
    }
  }
}