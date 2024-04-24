﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SignalR.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public string TProductNameByMaxPrice()
        {
            throw new NotImplementedException();
        }

        public string TProductNameByMinPrice()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
           return _productDal.GetProductsWithCategories();
        }

        public int TProductCount()
        {
            throw new NotImplementedException();
        }

        public int TProductCountByCategoryNameDrink()
        {
            throw new NotImplementedException();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            throw new NotImplementedException();
        }

        public decimal TProductPriceAvg()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product entity)
        {
           _productDal.Update(entity);
        }

        public decimal TProductAvgPriceByHamburger()
        {
            throw new NotImplementedException();
        }
    }
}
