using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}