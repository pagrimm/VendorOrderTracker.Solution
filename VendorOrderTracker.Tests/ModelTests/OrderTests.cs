using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("some title", "some description", 100);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string testTitle = "testTitle";
      Order newOrder = new Order(testTitle, "some description", 100);
      Assert.AreEqual(testTitle, newOrder.Title);
    }

    [TestMethod]
    public void SetTitle_SetsTitle_String()
    {
      string testTitle = "testTitle";
      Order newOrder = new Order(testTitle, "some description", 100);
      string testNewTitle = "testNewTitle";
      newOrder.Title = testNewTitle;
      Assert.AreEqual(testNewTitle, newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string testDescription = "testDescription";
      Order newOrder = new Order ("some title", testDescription, 100);
      Assert.AreEqual(testDescription, newOrder.Description);
    }

    [TestMethod]
    public void SetDescription_SetsDescription_String()
    {
      string testDescription = "testDescription";
      Order newOrder = new Order("some title", testDescription, 100);
      string testNewDescription = "testNewDescription";
      newOrder.Description = testNewDescription;
      Assert.AreEqual(testNewDescription, newOrder.Description);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int testPrice = 100;
      Order newOrder = new Order ("some title", "some description", testPrice);
      Assert.AreEqual(testPrice, newOrder.Price);
    }

    [TestMethod]
    public void SetPrice_SetsPrice_Int()
    {
      int testPrice = 100;
      Order newOrder = new Order("some title", "some description", testPrice);
      int testNewPrice = 200;
      newOrder.Price = testNewPrice;
      Assert.AreEqual(testNewPrice, newOrder.Price);
    }
  }
}