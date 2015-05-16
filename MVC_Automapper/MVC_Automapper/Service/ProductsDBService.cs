using MVC_Automapper.Models;
using MVC_Automapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Automapper.Service
{
    public class ProductsDBService
    {
        // 資料庫資源
        private NorthwindDBEntities db = new NorthwindDBEntities();

        /// <summary>
        /// 取得所有產品
        /// </summary>
        /// <returns></returns>
        public List<ProductsViewModel> GetAllProducts()
        {
            var result = db.Products.Select(p => new ProductsViewModel()
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    SupplierID = p.SupplierID,
                    CategoryID = p.CategoryID,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    ReorderLevel = p.ReorderLevel,
                    Discontinued = p.Discontinued,
                    Categories = p.Categories,
                    Suppliers = p.Suppliers
                }).OrderBy(o => o.ProductID).ToList();
            return result;
        }


    }
}