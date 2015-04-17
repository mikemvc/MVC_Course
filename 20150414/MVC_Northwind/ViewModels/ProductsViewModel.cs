using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Northwind.ViewModels
{
    // 新增的ProductsViewModel
    public class ProductsViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        // 新增的
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
    }
}