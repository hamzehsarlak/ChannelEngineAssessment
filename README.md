## C# Assessment ChannelEngine

Create a .NET application with two entry points, a console app and an ASP.NET web app, which are connected to the **ChannelEngine** REST-API.

*Required functionality* 
Include at least the functionality listed below:
**Application Entry points**

 - A .NET console application which can execute the business logic
   listed below. Write the results of the logic below to the console
   output.    
 - An ASP.NET application, which can execute the business logic   
   listed below. Implement this using a controller which displays an   
   HTML table with the results.

**Business logic**
*Create the following methods in a shared library*

 - Fetch all orders with status IN_PROGRESS from the API
 - From these orders, compile a list of the top 5 products sold (product
   name, GTIN and total quantity), order these by the total quantity
   sold in descending order.
 - Pick one of the products from these orders and use the API to set the
   stock of this product to 25.

**Testing**

 - A unit test testing the expected outcome of the “top 5” functionality
   based on dummy input.
