using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
      Vendor.ClearIdCount();
    }
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string testName = "testName";
      Vendor newVendor = new Vendor(testName, "some description");
      Assert.AreEqual(testName, newVendor.Name);
    }

    [TestMethod]
    public void SetName_SetsName_String()
    {
      string testName = "testName";
      Vendor newVendor = new Vendor(testName, "some description");
      string testNewName = "testNewName";
      newVendor.Name = testNewName;
      Assert.AreEqual(testNewName, newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string testDescription = "testDescription";
      Vendor newVendor = new Vendor ("some name", testDescription);
      Assert.AreEqual(testDescription, newVendor.Description);
    }

    [TestMethod]
    public void SetDescription_SetsDescription_String()
    {
      string testDescription = "testDescription";
      Vendor newVendor = new Vendor("some name", testDescription);
      string testNewDescription = "testNewDescription";
      newVendor.Description = testNewDescription;
      Assert.AreEqual(testNewDescription, newVendor.Description);
    }

    [TestMethod]
    public void GetOrderList_ReturnsOrderList_List()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(typeof(List<Order>), newVendor.OrderList.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_List()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(typeof(List<Vendor>), Vendor.GetAll().GetType());
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(0, newVendor.Id);
    }

    [TestMethod]
    public void Find_ReturnsVendorById_Vendor()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(newVendor, Vendor.Find(0));
    }

    [TestMethod]
    public void Delete_DeletesVendorById_Vendor()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(1, Vendor.GetAll().Count);
      Vendor.Delete(0);
      Assert.AreEqual(0, Vendor.GetAll().Count);
    }

    [TestMethod]
    public void AddOrder_AddsOrderObjectToOrderList_Order()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Assert.AreEqual(0, newVendor.OrderList.Count);
      Order newOrder = new Order("some title", "some description", 100, "2020-07-09");
      newVendor.AddOrder(newOrder);
      Assert.AreEqual(1, newVendor.OrderList.Count);
    }

    [TestMethod]
    public void RemoveOrder_RemovesOrderObjectFromOrderList_Order()
    {
      Vendor newVendor = new Vendor("some name", "some description");
      Order newOrder = new Order("some title", "some description", 100, "2020-07-09");
      newVendor.AddOrder(newOrder);
      Assert.AreEqual(1, newVendor.OrderList.Count);
      newVendor.RemoveOrder(newOrder);
      Assert.AreEqual(0, newVendor.OrderList.Count);
    }
  }
}