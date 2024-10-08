﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() 
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15},
                new Product{ProductId=2, CategoryId=2, ProductName="Tabak", UnitPrice=35},
                new Product{ProductId=3, CategoryId=1, ProductName="Araba", UnitPrice=89},
                new Product{ProductId=4, CategoryId=4, ProductName="Kalem", UnitPrice=12},
                new Product{ProductId=5, CategoryId=3, ProductName="Kitap", UnitPrice=8}
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Intergrated Query
            //Lamba
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiği ürün id'sine Sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitPrice= product.UnitPrice;
        }

        List<ProductDetailDto> IProductDal.GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
