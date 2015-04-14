using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LINQ_CRUD.Models;

namespace LINQ_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities Dbcontext = new NorthwindEntities();

            #region MVC5 LINQ_CRUD 練習 - 2015.2.7

                #region 練習一 CRUD 單一表單資料

                //var query = (from E in Dbcontext.Employees
                //             select new
                //             {
                //                 ID = E.EmployeeID,
                //                 Name = E.LastName + " " + E.FirstName,
                //                 Address = E.Address,
                //                 City = E.City,
                //                 Region = E.Region
                //             }).ToList();

                //foreach (var e in query)
                //{
                //    Console.WriteLine("ID: " + e.ID + " 姓名: " + e.Name + " 地址:" + e.Address + " 城市:" + e.City);
                //}

                //Employees newEmployee = new Employees();

                //newEmployee.LastName = "YaoChu";
                //newEmployee.FirstName = "Lu";
                //newEmployee.Address = "台中市西屯區大弘街23-4號";
                //newEmployee.City = "Taichung";

                //Dbcontext.Employees.Add(newEmployee);
                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("-------------以下是新增過後的資料表---------------\n");

            //var query2 = (from E in Dbcontext.Employees
            //              select new
            //              {
            //                  ID = E.EmployeeID,
            //                  Name = E.LastName + " " + E.FirstName,
            //                  Address = E.Address,
            //                  City = E.City,
            //                  Region = E.Region
            //              }).ToList();

            //foreach (var e in query2)
            //{
            //    Console.WriteLine("ID: " + e.ID + " 姓名: " + e.Name + " 地址:" + e.Address + " 城市:" + e.City);
            //}

                //Console.ReadLine();

                //Employee oldEmployee = Dbcontext.Employees.Where(e => e.FirstName == "Lu").FirstOrDefault();


                //////把原始的資料 "更換" 並增加了 Country = Taiwan    
                //oldEmployee.FirstName = "Wu";
                //oldEmployee.LastName = "YingTin";
                //oldEmployee.Country = "Taiwan";

                //Dbcontext.SaveChanges();


                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是修改過後的資料表-----------------\n");

                //var query3 = (from E in Dbcontext.Employees
                //              select new
                //              {
                //                  ID = E.EmployeeID,
                //                  Name = E.LastName + " " + E.FirstName,
                //                  Address = E.Address,
                //                  City = E.City,
                //                  Country = E.Country
                //              }).ToList();

                //foreach (var e in query3)
                //{
                //    Console.WriteLine("ID :" + e.ID + " 姓名: " + e.Name + " 地址:" + e.Address + " 城市:" + e.City);
                //}

                //Console.ReadLine();

                ////刪除剛剛增加的資料
                //Employee DeleteEmployee = Dbcontext.Employees.Where(e => e.FirstName == "Wu").FirstOrDefault();
                //Dbcontext.Employees.Remove(DeleteEmployee);
                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是刪除過後的資料表-----------------\n");


                //var query4 = (from E in Dbcontext.Employees
                //              select new
                //              {
                //                  ID = E.EmployeeID,
                //                  Name = E.LastName + " " + E.FirstName,
                //                  Address = E.Address,
                //                  City = E.City,
                //                  Country = E.Country
                //              }).ToList();

                //foreach (var e in query4)
                //{
                //    Console.WriteLine("ID: " + e.ID + " 姓名: " + e.Name + " 地址:" + e.Address + " 城市:" + e.City);
                //}

                #endregion

                #region 練習二 CRUD單一表單資料

                //var query = from E in Dbcontext.Shippers
                //            select new
                //            {
                //                ShipperID = E.ShipperID,
                //                CompanyName = E.CompanyName,
                //                Phone = E.Phone
                //            };

                //foreach (var e in query)
                //{
                //    Console.WriteLine("運貨ID: " + e.ShipperID + "公司名稱: " + e.CompanyName + " 電話: " + e.Phone);
                //}

                //Shipper newShipper = new Shipper();

                //newShipper.CompanyName = "HandyMenu";
                //newShipper.Phone = "04-23169966";

                //Dbcontext.Shippers.Add(newShipper);
                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是新增過後的資料表-----------------\n");

                //var query2 = from E in Dbcontext.Shippers
                //             select new
                //             {
                //                 ShipperID = E.ShipperID,
                //                 CompanyName = E.CompanyName,
                //                 Phone = E.Phone
                //             };

                //foreach (var e in query2)
                //{
                //    Console.WriteLine("運貨ID: " + e.ShipperID + "公司名稱: " + e.CompanyName + " 電話: " + e.Phone);
                //}

                ////修改資料
                //Shipper oldShipper = Dbcontext.Shippers.Where(s => s.ShipperID == 4).FirstOrDefault();

                //oldShipper.Phone = "(04)-23169966";
                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是修改過後的資料表-----------------\n");

                //var query3 = from E in Dbcontext.Shippers
                //             select new
                //             {
                //                 ShipperID = E.ShipperID,
                //                 CompanyName = E.CompanyName,
                //                 Phone = E.Phone
                //             };

                //foreach (var e in query3)
                //{
                //    Console.WriteLine("運貨ID: " + e.ShipperID + "公司名稱: " + e.CompanyName + " 電話: " + e.Phone);

                //}

                //Console.WriteLine("\n");

                #endregion

                #region 練習三 CRUD兩個表單資料

                //var query = (from S in Dbcontext.Shippers
                //             from O in S.Orders
                //             where O.ShipVia > 1 && O.ShipVia < 3
                //             select new
                //             {
                //                 ShipperID = O.ShipVia,
                //                 ShipperCountry = O.ShipCountry,
                //                 ShipperCity = O.ShipCity,
                //                 ShipperCompanyName = S.CompanyName,
                //                 OrderID = O.OrderID,
                //                 CustomerID = O.CustomerID,
                //                 EmployeeID = O.EmployeeID

                //             }).ToList();

                //foreach (var s in query)
                //{
                //    Console.WriteLine("運貨公司ID: " + s.ShipperID + " 送貨國家: " + s.ShipperCountry + " 運送城市: " + s.ShipperCity);
                //}

                ////新增
                //Shippers newShipper = new Shippers();
                ////newShipper.CompanyName = "AAA";
                ////Dbcontext.Shippers.Add(newShipper);

                //Orders newOrders = new Orders();
                ////newOrders.ShipVia = shipper.ShipperID;
                ////newOrders.ShipCountry = "AAAAA";
                ////newOrders.ShipCity = "BBBB";
                ////Dbcontext.Orders.Add(newOrders);


                ////Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是新增過後的資料表-----------------\n");

                //var query2 = (from S in Dbcontext.Shippers
                //              from O in S.Orders
                //              where O.ShipVia >= 4
                //              select new
                //              {
                //                  ShipperID = O.ShipVia,
                //                  ShipperCountry = O.ShipCountry,
                //                  ShipperCity = O.ShipCity,
                //                  ShipperCompanyName = S.CompanyName,
                //                  OrderID = O.OrderID,
                //                  CustomerID = O.CustomerID,
                //                  EmployeeID = O.EmployeeID

                //              }).ToList();

                //foreach (var s in query2)
                //{
                //    Console.WriteLine("運貨公司ID: " + s.ShipperID + " 送貨國家: " + s.ShipperCountry + " 運送城市: " + s.ShipperCity);
                //}


                ////修改
                //Shippers oldShipper = Dbcontext.Shippers.Where(s => s.ShipperID == 4).FirstOrDefault();

                //oldShipper.CompanyName = "Bigdad";
                //oldShipper.Phone = "04-23169966";

                //Orders oldOrder = Dbcontext.Orders.Where(o => o.ShipVia == 4).FirstOrDefault();

                //oldOrder.ShipCity = "Taichung";
                //oldOrder.ShipCountry = "Taiwan";

                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是修改過後的資料表-----------------\n");


                //var query3 = (from S in Dbcontext.Shippers
                //              from O in S.Orders
                //              where O.ShipVia >= 4
                //              select new
                //              {
                //                  ShipperID = O.ShipVia,
                //                  ShipperCountry = O.ShipCountry,
                //                  ShipperCity = O.ShipCity,
                //                  ShipperCompanyName = S.CompanyName,
                //                  OrderID = O.OrderID,
                //                  CustomerID = O.CustomerID,
                //                  EmployeeID = O.EmployeeID

                //              }).ToList();

                //foreach (var s in query3)
                //{
                //    Console.WriteLine("運貨公司ID: " + s.ShipperID + " 送貨國家: " + s.ShipperCountry + " 運送城市: " + s.ShipperCity);
                //}



                ////刪除貨運公司ShipperID == 5 的公司
                //Shippers DeleteShipper = Dbcontext.Shippers.Where(s => s.ShipperID == 5).FirstOrDefault();
                //Dbcontext.Shippers.Remove(DeleteShipper);


                //Orders DeleteOrder = Dbcontext.Orders.Where(o => o.ShipVia == 5).FirstOrDefault();
                //Dbcontext.Orders.Remove(DeleteOrder);

                //Dbcontext.SaveChanges();


                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是刪除過後的資料表-----------------\n");


                //var query4 = (from S in Dbcontext.Shippers
                //              from O in S.Orders
                //              where O.ShipVia >= 4
                //              select new
                //              {
                //                  ShipperID = O.ShipVia,
                //                  ShipperCountry = O.ShipCountry,
                //                  ShipperCity = O.ShipCity,
                //                  ShipperCompanyName = S.CompanyName,
                //                  OrderID = O.OrderID,
                //                  CustomerID = O.CustomerID,
                //                  EmployeeID = O.EmployeeID

                //              }).ToList();

                //foreach (var s in query4)
                //{
                //    Console.WriteLine("運貨公司ID: " + s.ShipperID + " 送貨國家: " + s.ShipperCountry + " 運送城市: " + s.ShipperCity);
                //}

                #endregion

                #region 練習四 CRUD兩個表單資料

                //var query = (from C in Dbcontext.Customers
                //             from O in C.Orders
                //             select new
                //             {
                //                 ContactName = C.ContactName,
                //                 ShipCity = O.ShipCity,
                //                 ShipCountry = O.ShipCountry

                //             }).ToList();


                //foreach (var s in query)
                //{
                //    Console.WriteLine("聯絡人: " + s.ContactName + " 運送國家" + s.ShipCountry + " 運送城市: " + s.ShipCity);
                //}

                ////新增

                //Customers newCustomer = new Customers();

                //newCustomer.CustomerID = "twMVC";
                //newCustomer.CompanyName = "BigDady";
                //newCustomer.ContactName = "呂曜竹";
                //newCustomer.Country = "Taiwan";
                //newCustomer.City = "Taichung";
                //newCustomer.Phone = "04-23169966";

                //Dbcontext.Customers.Add(newCustomer);

                //Orders newOrders = new Orders();

                //newOrders.CustomerID = newCustomer.CustomerID;
                //newOrders.ShipVia = 4;
                //newOrders.ShipCountry = newCustomer.Country;
                //newOrders.ShipCity = newCustomer.City;
                //Dbcontext.Orders.Add(newOrders);

                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是新增過後的資料表-----------------\n");


                //var query2 = (from C in Dbcontext.Customers
                //              from O in C.Orders
                //              where O.CustomerID == "twMVC"
                //              select new
                //              {
                //                  ContactName = C.ContactName,
                //                  ShipCity = O.ShipCity,
                //                  ShipCountry = O.ShipCountry

                //              }).ToList();


                //foreach (var c in query2)
                //{
                //    Console.WriteLine("聯絡人: " + c.ContactName + " 運送國家" + c.ShipCountry + " 運送城市: " + c.ShipCity);
                //}


                ////修改
                //Customers oldCustomer = Dbcontext.Customers.Where(c => c.CustomerID == "twMVC").FirstOrDefault();

                //oldCustomer.ContactTitle = "WebEngineer";
                //oldCustomer.Address = "Taiwan-Taichung";
                //oldCustomer.Fax = "123456789";

                //Orders oldOrder = Dbcontext.Orders.Where(o => o.CustomerID == "twMVC").FirstOrDefault();


                //oldOrder.OrderDate = DateTime.Now;
                //oldOrder.ShippedDate = DateTime.Now;
                //oldOrder.ShipVia = 4;
                //oldOrder.ShipAddress = "Taiwan-Taichung";
                //oldOrder.ShipPostalCode = "407";

                //Dbcontext.SaveChanges();


                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是修改過後的資料表-----------------\n");


                //var query3 = (from C in Dbcontext.Customers
                //              from O in C.Orders
                //              where C.CustomerID == "twMVC"
                //              select new
                //              {
                //                  ContactTitle = C.ContactTitle,
                //                  Address = C.Address,
                //                  Fax = C.Fax,
                //                  OrderDate = O.OrderDate,
                //                  ShipPostalCode = O.ShipPostalCode

                //              }).ToList();


                //foreach (var c in query3)
                //{
                //    Console.WriteLine("聯絡人title: " + c.ContactTitle + " 聯絡人地址: " + c.Address + " 運送地址的PostCode: " + c.ShipPostalCode);
                //}


                ////刪除
                ////手動刪除新增資料

                //Customers DeleteCustomer = Dbcontext.Customers.Where(c => c.CustomerID == "twMVC").FirstOrDefault();
                //Dbcontext.Customers.Remove(DeleteCustomer);


                //Orders DeleteOrder = Dbcontext.Orders.Where(o => o.ShipVia == 4).FirstOrDefault();
                //Dbcontext.Orders.Remove(DeleteOrder);

                //Dbcontext.SaveChanges();



                #endregion

                #region 練習五 新增三個表單資料

                //var query = (from C in Dbcontext.Customers
                //             from O in C.Orders
                //             where C.Country == "Taiwan" && O.CustomerID == "twMVC" 
                //             select new
                //             {
                //                 CustomerID = C.CustomerID,
                //                 CompanyName = C.CompanyName,
                //                 ContactName = C.ContactName,
                //                 OrderID = O.OrderID, 
                //                 ShipAddress = O.ShipAddress

                //             }).ToList();

                //foreach (var c in query)
                //{
                //    Console.WriteLine("ID: " + c.CustomerID + " 聯絡人名子: " + c.ContactName + " 運送地點: " + c.ShipAddress);
                //}

                ////新增&修改
                //Customers oldCustomer = Dbcontext.Customers.Where(c => c.Country == "Taiwan").FirstOrDefault();
                //oldCustomer.PostalCode = "407";

                //Orders oldOrder = Dbcontext.Orders.Where(o => o.CustomerID == "twMVC").FirstOrDefault();

                ////這邊有關聯性 只能增加1~9. 不能增加EmployeeID原有以外的數字?    
                //oldOrder.EmployeeID = 9;


                //Order_Details newOrder_Detail = new Order_Details();


                //newOrder_Detail.OrderID = oldOrder.OrderID;
                //newOrder_Detail.ProductID = 77;
                //newOrder_Detail.UnitPrice = 1000;
                //newOrder_Detail.Quantity = 3;

                //Dbcontext.Order_Details.Add(newOrder_Detail);

                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n-------------------我是分隔線-------------------");
                //Console.WriteLine("----------------以下是新增過後的資料表-----------------\n");


                //var query2 = (from C in Dbcontext.Customers
                //              from O in C.Orders
                //              from Od in O.Order_Details
                //              where C.Country == "Taiwan" && O.CustomerID == "twMVC"
                //              select new
                //              {
                //                  PostalCode = C.PostalCode,
                //                  EmpolyeeID = O.EmployeeID,
                //                  ProductID = Od.ProductID,
                //                  Price = Od.UnitPrice
                //              }).ToList();

                //foreach (var s in query2)
                //{
                //    Console.WriteLine("郵遞號碼: " + s.PostalCode + " 員工編號: " + s.EmpolyeeID + "  產品編號: " + s.ProductID + " 產品價格: "+ s.Price);
                //}


                //修改

                //var query3 = (from O in Dbcontext.Orders
                //              from Od in O.Order_Details
                //              where O.CustomerID == "twMVC"
                //              select new 
                //              {
                //                  OrderID = Od.OrderID, 
                //                  ProductID = Od.ProductID, 
                //                  Price = Od.UnitPrice,
                //                  Quantity = Od.Quantity
                //              }).ToList();

                //foreach (var od in query3)
                //{
                //    Console.WriteLine("OrderID: " + od.OrderID + " ProductID: " + od.ProductID + " 價錢: " + od.Price);
                //}


                //Console.WriteLine("---------------------Lambda------------------------\n");

                //// Lambda Style
                //var TableOrder = Dbcontext.Orders.AsEnumerable();
                //var TableOrder_Details = Dbcontext.Order_Details.AsEnumerable();


                //var query3 = TableOrder.SelectMany(o => TableOrder_Details, (o, od) => new { o, od })
                //             .Where(@x => @x.o.CustomerID == "twMVC")
                //             .Select(@x => new
                //             {

                //                 OrderID = @x.o.CustomerID,
                //                 ProductID = @x.od.ProductID,
                //                 Price = @x.od.UnitPrice,
                //                 Quantity = @x.od.Quantity
                //             });

                //foreach (var od in query3)
                //{
                //    Console.WriteLine("OrderID: " + od.OrderID + " ProductID: " + od.ProductID + " 價錢: " + od.Price);
                //}

                //Console.WriteLine("---------------------一般查詢------------------------\n");

                //var query4 = (from O in Dbcontext.Orders
                //              from Od in O.Order_Details
                //              where O.CustomerID == "twMVC"
                //              select new
                //              {
                //                  OrderID = O.CustomerID,
                //                  ProductID = Od.ProductID,
                //                  Price = Od.UnitPrice,
                //                  Quantity = Od.Quantity
                //              }).ToList();

                //foreach (var od in query4)
                //{
                //    Console.WriteLine("OrderID: " + od.OrderID + " ProductID: " + od.ProductID + " 價錢: " + od.Price);
                //}

                //刪除
                //手動刪除新增資料
                //Order_Details DeletOrder_Detail = Dbcontext.Order_Details.Where(od => od.OrderID == "")
                //Dbcontext.Customers.Remove(DeletOrder_Detail);

                //Dbcontext.SaveChanges();


                #endregion

                #region 練習六 新增三個表單資料

                //Console.WriteLine("-----------------新增三個資料表--------------------");

                ////這裡新增一個客戶資料
                //Customers newCustomer = new Customers();
                //newCustomer.CustomerID = "Api2";
                //newCustomer.CompanyName = "ShowMeTheMoney";
                //Dbcontext.Customers.Add(newCustomer);

                ////同時建立一個訂單資料
                //Orders newOrder = new Orders();
                //newOrder.CustomerID = newCustomer.CustomerID;
                //Dbcontext.Orders.Add(newOrder);

                ////在同時建立訂單資料的時候 順便建立訂單細節
                //Order_Details newOrderDetail = new Order_Details();

                //Products oldProduct = new Products();
                //oldProduct = Dbcontext.Products.Where(p => p.ProductID == 1).FirstOrDefault();

                //newOrderDetail.OrderID = newOrder.OrderID;
                //newOrderDetail.ProductID = oldProduct.ProductID;
                //newOrderDetail.Quantity = 1;


                //Dbcontext.Order_Details.Add(newOrderDetail);
                //Dbcontext.SaveChanges();

                //Console.WriteLine("\n");
                //Console.WriteLine("--------------------新增成功-----------------------");

                //Console.Read();

                #endregion

                #region 練習七 新增四個表單資料

                ////一次新增四個資料表單
                //Customers newCustomer = new Customers();
                //newCustomer.CustomerID = "Api2";
                //newCustomer.CompanyName = "ShowMeTheMoney";
                //Dbcontext.Customers.Add(newCustomer);

                //Orders newOrder = new Orders();
                //newOrder.CustomerID = newCustomer.CustomerID;
                //Dbcontext.Orders.Add(newOrder);


                //Order_Details newOrder_Detail = new Order_Details();
                //newOrder_Detail.OrderID = newOrder.OrderID;
                //newOrder_Detail.ProductID = 77;
                //newOrder_Detail.UnitPrice = 1000;
                //newOrder_Detail.Quantity = 3;
                //Dbcontext.Order_Details.Add(newOrder_Detail);

                //Products newProduct = new Products();
                //newProduct.ProductID = newOrder_Detail.ProductID;
                //newProduct.ProductName = "Asp.net Web Api2.0";
                //Dbcontext.Products.Add(newProduct);

                //Dbcontext.SaveChanges();

                //var query = (from C in Dbcontext.Customers
                //             from O in C.Orders
                //             from Od in O.Order_Details
                //             join P in Dbcontext.Products on Od.ProductID equals P.ProductID
                //             where C.CustomerID == "Api2"
                //             select new
                //             {
                //                 CustomerID = C.CustomerID,
                //                 CustomerCompanyName = C.CompanyName,
                //                 OrderID = O.OrderID,
                //                 ProductID = Od.ProductID,
                //                 ProductName = P.ProductName

                //             }).ToList();

                //Console.WriteLine("----------------------以下是新增的資料----------------------\n");


                //foreach (var result in query)
                //{
                //    Console.WriteLine("顧客ID: " + result.CustomerID + " 公司名稱: " + result.CustomerCompanyName + " 訂單編號: " + result.OrderID + " 產品編號: " + result.ProductID + " 產品名稱: " + result.ProductName);
                //}


                ////修改四個資料表單

                //Customers oldCustomer = new Customers();
                //oldCustomer = Dbcontext.Customers.Where(c => c.CustomerID == "Api2").FirstOrDefault();
                //oldCustomer.ContactName = "呂曜竹";

                //Orders oldOrder = new Orders();
                //oldOrder = Dbcontext.Orders.Where(o => o.CustomerID == "Api2").FirstOrDefault();
                //oldOrder.ShipCountry = "Taiwan";

                ////這邊的查詢應該做第二次的重新查詢
                //Order_Details oldOrder_Details = new Order_Details();
                //oldOrder_Details = Dbcontext.Order_Details.Where(od => od.OrderID == 15078).FirstOrDefault();
                //oldOrder_Details.UnitPrice = 998;

                //Products oldProduct = new Products();
                //oldProduct = Dbcontext.Products.Where(p => p.ProductID == oldOrder_Details.ProductID).FirstOrDefault();
                //oldProduct.ProductName = "BigMan";

                //Dbcontext.SaveChanges();

                //Console.WriteLine("--------------------------修改成功----------------------------------");

                ////刪除
                ////手動刪除新增資料

                //Customers DeleteCustomer = Dbcontext.Customers.Where(c => c.CustomerID == "Api").FirstOrDefault();
                //Dbcontext.Customers.Remove(DeleteCustomer);

                //Orders DeleteOrder = Dbcontext.Orders.Where(o => o.CustomerID == "Api").FirstOrDefault();
                //Dbcontext.Orders.Remove(DeleteOrder);

                //Order_Details DeleteOrder_Details = Dbcontext.Order_Details.Where(od => od.UnitPrice == 1000).FirstOrDefault();
                //Dbcontext.Order_Details.Remove(DeleteOrder_Details);


                //Dbcontext.SaveChanges();


                #region //測試區

                //var query = (from C in Dbcontext.Customers
                //                     where C.CustomerID == "Api"
                //                     select new
                //                     {
                //                         CustomerID = C.CustomerID,
                //                         ConpanyName = C.CompanyName
                //                     }).ToList();

                //    foreach (var c in query)
                //    {
                //        Console.WriteLine("CustomerID: " + c.CustomerID + "CompanyName: " + c.ConpanyName);
                //    }


                //var query2 = (from Od in Dbcontext.Order_Details
                //              where Od.UnitPrice == 1000
                //              select new
                //              {
                //                  OrderID = Od.OrderID,
                //                  ProductID = Od.ProductID,
                //                  UnitPrice = Od.UnitPrice,
                //                  Quantity = Od.Quantity
                //              }).ToList();

                //foreach (var od in query2)
                //{
                //    Console.WriteLine("訂單編號: " + od.OrderID + "產品ID: " + od.ProductID + "單價: " + od.UnitPrice);
                //}

                #endregion


                #endregion

                #region 練習八 新增四個表單資料

                //先查詢看看Customer裡的api2的訂單編號

                //Customers oldCustomer = new Customers();
                //oldCustomer = Dbcontext.Customers.Where(c => c.CustomerID == "Api2").FirstOrDefault();
                //oldCustomer.ContactName = "呂曜竹";

                //Orders oldOrder = new Orders();
                //oldOrder = Dbcontext.Orders.Where(o => o.CustomerID == oldCustomer.CustomerID).FirstOrDefault();
                //oldOrder.ShipCountry = "Taiwan";

                ////這邊的查詢應該做第二次的重新查詢
                //Order_Details oldOrder_Details = new Order_Details();
                //oldOrder_Details = Dbcontext.Order_Details.Where(od => od.OrderID == oldOrder.OrderID).FirstOrDefault();
                ////oldOrder_Details.UnitPrice = 998;

                //Console.WriteLine("訂單編號: " + oldOrder_Details.OrderID);

                #endregion

                #region 練習九 新增 一次多筆資料

                //var data = Dbcontext.Orders.FirstOrDefault();
                //foreach (var item in data.Order_Details)
                //{
                //    //存放Detail資訊
                //}

                //List<Permission_RoleUserMapping> newPermissionRoleUserMapping = new List<Permission_RoleUserMapping>();
                //newPermissionRoleUserMapping.Add(new Permission_RoleUserMapping() { URoleID = 99, UserID = 99, Status = 99 });
                //newPermissionRoleUserMapping.Add(new Permission_RoleUserMapping() { URoleID = 98, UserID = 99, Status = 99 });
                //newPermissionRoleUserMapping.Add(new Permission_RoleUserMapping() { URoleID = 97, UserID = 99, Status = 99 });

                //var createdata = new Permission_Roles();
                //createdata.RoleID = 99;
                //createdata.Name = "99";
                //createdata.Status = 100;


                //foreach (var item in newPermissionRoleUserMapping)
                //{
                //    createdata.Permission_RoleUserMapping.Add(item);
                //}

                //Dbcontext.Permission_Roles.Add(createdata);
                //Dbcontext.SaveChanges();

                //var result = Dbcontext.Permission_Roles.Where(p => p.RoleID == 2).FirstOrDefault();

                //Console.WriteLine("Permission_RolesID : " + result.RoleID);

                //foreach (var item in result.Permission_RoleUserMapping)
                //{
                //    Console.WriteLine("Permission_RoleUserMappingID : " + item.URoleID);
                //}

                //Console.WriteLine("----------------------新增成功-------------------------------");

                //Console.Read();

                #endregion

                #region 練習十 新增 一次多筆資料 2

                //List<Order_Details> newOrderDeltails = new List<Order_Details>();
                //newOrderDeltails.Add(new Order_Details() { ProductID = 1, UnitPrice = 100, Quantity = 5 });
                //newOrderDeltails.Add(new Order_Details() { ProductID = 2, UnitPrice = 200, Quantity = 4 });
                //newOrderDeltails.Add(new Order_Details() { ProductID = 3, UnitPrice = 150, Quantity = 3 });
                //newOrderDeltails.Add(new Order_Details() { ProductID = 4, UnitPrice = 200, Quantity = 2 });

                //var newOrder = new Orders();
                //newOrder.OrderID = 99;   

                //foreach (var item in newOrderDeltails)
                //{
                //    newOrder.Order_Details.Add(item);
                //}

                //Dbcontext.Orders.Add(newOrder);
                //Dbcontext.SaveChanges();

                //var result = Dbcontext.Orders.Where(p => p.OrderID == 20083).FirstOrDefault();

                //Console.WriteLine("OrderID = " + result.OrderID);

                //foreach (var item in result.Order_Details)
                //{
                //    Console.WriteLine("訂單編號: " + item.OrderID + " 產品: " + item.ProductID + " 產品名稱: " + item.Products.ProductName);
                //}

                //Console.Read();

                #endregion

                #region 練習另外的新增方法

                //var result = Dbcontext.Orders.Where(p => p.OrderID == 20083).FirstOrDefault();
                //Console.WriteLine("OrderID = " + result.OrderID);
                //var data = new Order_Details() { Products = Dbcontext.Products.Where(p=>p.ProductID == 6).FirstOrDefault(), UnitPrice = 200, Quantity = 2 };
                //result.Order_Details.Add(data);
                //foreach (var item in result.Order_Details)
                //{
                //    if (item.ProductID == 3)
                //        item.UnitPrice = 800;
                //}

                //Dbcontext.SaveChanges();

                //var result1 = Dbcontext.Orders.Where(p => p.OrderID == 20083).FirstOrDefault();
                //Console.WriteLine("OrderID = " + result1.OrderID);
                //foreach (var item in result1.Order_Details)
                //{
                //    Console.WriteLine("OrderID=" + item.OrderID + "ProjectID=" + item.ProductID + "ProjectName = " + item.Products.ProductName + "Price=" + item.UnitPrice);
                //}

                //Console.Read();

                #endregion


            #endregion
        }
    }
}
