using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
      Order.ClearIdCount();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("some title", "some description", 100, "2020-07-09");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string testTitle = "testTitle";
      Order newOrder = new Order(testTitle, "some description", 100, "2020-07-09");
      Assert.AreEqual(testTitle, newOrder.Title);
    }

    [TestMethod]
    public void SetTitle_SetsTitle_String()
    {
      string testTitle = "testTitle";
      Order newOrder = new Order(testTitle, "some description", 100, "2020-07-09");
      string testNewTitle = "testNewTitle";
      newOrder.Title = testNewTitle;
      Assert.AreEqual(testNewTitle, newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string testDescription = "testDescription";
      Order newOrder = new Order ("some title", testDescription, 100, "2020-07-09");
      Assert.AreEqual(testDescription, newOrder.Description);
    }

    [TestMethod]
    public void SetDescription_SetsDescription_String()
    {
      string testDescription = "testDescription";
      Order newOrder = new Order("some title", testDescription, 100, "2020-07-09");
      string testNewDescription = "testNewDescription";
      newOrder.Description = testNewDescription;
      Assert.AreEqual(testNewDescription, newOrder.Description);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int testPrice = 100;
      Order newOrder = new Order ("some title", "some description", testPrice, "2020-07-09");
      Assert.AreEqual(testPrice, newOrder.Price);
    }

    [TestMethod]
    public void SetPrice_SetsPrice_Int()
    {
      int testPrice = 100;
      Order newOrder = new Order("some title", "some description", testPrice, "2020-07-09");
      int testNewPrice = 200;
      newOrder.Price = testNewPrice;
      Assert.AreEqual(testNewPrice, newOrder.Price);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_DateTime()
    {
      string testDate = "2020-07-09";
      Order newOrder = new Order ("some title", "some description", 100, testDate);
      Assert.AreEqual(typeof(DateTime), newOrder.Date.GetType());
      Assert.AreEqual(2020, newOrder.Date.Year);
      Assert.AreEqual(7, newOrder.Date.Month);
      Assert.AreEqual(9, newOrder.Date.Day);
    }

    [TestMethod]
    public void SetDate_SetsDate_DateTime()
    {
      string testDate = "2020-07-09";
      Order newOrder = new Order("some title", "some description", 100, testDate);
      DateTime newTestDate = DateTime.Parse("1999-12-31");
      newOrder.Date = newTestDate;
      Assert.AreEqual(1999, newOrder.Date.Year);
      Assert.AreEqual(12, newOrder.Date.Month);
      Assert.AreEqual(31, newOrder.Date.Day);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_List()
    {
      Order newOrder = new Order("some title", "some description", 100, "2020-07-09");
      Assert.AreEqual(typeof(List<Order>), Order.GetAll().GetType());
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Order newOrder = new Order("some title", "some description", 100, "2020-07-09");
      Assert.AreEqual(0, newOrder.Id);
    }

    [TestMethod]
    public void Find_ReturnsOrderById_Order()
    {
      Order newOrder = new Order("some title", "some description", 100, "2020-07-09");
      Assert.AreEqual(newOrder, Order.Find(0));
    }
  }
}