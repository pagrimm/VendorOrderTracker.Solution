# Vendor Order Tracker
**Weekly Independent Project for Epicodus**  
**By Peter Grimm, 07.24.2020**

## Description

Weekly project independent for Epicodus, an MVC application to help track the vendors that purchase baked goods and the orders belonging to those vendors. Designed to showcase my ability creating basic web applications with ASP.NET Core MVC, using the MVC pattern, routes and controllers, and RESTful routing.

## Specifications
Back-End
* Can create vendor objects with properties for vendor name, description, list of orders, id
* Can create order objects with properties for title, description, price, date, id
* Ids are assigned to orders and vendors on creation
* Can find orders and vendors by id
* Can add orders to vendors
* Can get a list of all vendors and orders
* Can get a list of all orders belonging to a specific vendor

Front-End
* The homepage of the app at the root path is a splash page welcoming and providing a link to a vendors page
* Can navigate to a page with a form to create a new Vendor
* Can navigate to a page with a form to create a new Order for a particular vendor
* Can see all vendors displayed
* Orders for each vendor are displayed
* Can click on orders to display details

## Setup/Installation Requirements

* .NET Core 2.2 will need to be installed, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* Check out the repository using `git clone https://github.com/pagrimm/VendorOrderTracker.Solution.git` in your terminal
* Navigate to the newly created `VendorOrderTracker.Solution` folder
* Navigate to the `VendorOrderTracker` subfolder and run `dotnet restore`
* Run `dotnet build` to build the app and `dotnet run` to run it
* The web app will now be available on `http://localhost:5000/` in your browser

## Technologies Used

C#  
.NET Core 2.2  
ASP.NET Core MVC  

## Legal

Copyright (c) 2020, Peter Grimm  
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) This software is licensed under the MIT license.