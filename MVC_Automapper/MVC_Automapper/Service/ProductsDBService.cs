using MVC_Automapper.Models;
using MVC_Automapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// 1. 首先加入AutoMapper的namespace
using AutoMapper;

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
            //var result = db.Products.Select(p => new ProductsViewModel()
            //    {
            //        ProductID = p.ProductID,
            //        ProductName = p.ProductName,
            //        SupplierID = p.SupplierID,
            //        CategoryID = p.CategoryID,
            //        QuantityPerUnit = p.QuantityPerUnit,
            //        UnitPrice = p.UnitPrice,
            //        UnitsInStock = p.UnitsInStock,
            //        UnitsOnOrder = p.UnitsOnOrder,
            //        ReorderLevel = p.ReorderLevel,
            //        Discontinued = p.Discontinued,
            //        Categories = p.Categories,
            //        Suppliers = p.Suppliers
            //    }).OrderBy(o => o.ProductID).ToList();
            //return result;

            // 採用AutoMapper的做法
            var data = db.Products.ToList();
            // 首先建立一個AutoMapper的設計，第一個傳入的是原始型別，第二個傳入的是轉型後的型別
            Mapper.CreateMap<Products, ProductsViewModel>();
            // 傳入要轉型的data，開始轉型為ProductsViewModel的型別
            List<ProductsViewModel> result = Mapper.Map<List<Products>, List<ProductsViewModel>>(data);
            return result;
        }


    }
}