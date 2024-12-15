using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres, MongoDB
            _products = new List<Product>
            {
               new Product{ProductId = 1,CategoryId = 1,ProductName = "Bardak",UnitPrice = 15,UnitInStock = 15},
               new Product{ProductId = 2,CategoryId = 1,ProductName = "Kamera",UnitPrice = 500,UnitInStock = 3},
               new Product{ProductId = 3,CategoryId = 2,ProductName = "Telefon",UnitPrice = 1500,UnitInStock = 2},
               new Product{ProductId = 4,CategoryId = 2,ProductName = "Klavye",UnitPrice = 150,UnitInStock = 65},
               new Product{ProductId = 5,CategoryId = 2,ProductName = "Fare",UnitPrice = 85,UnitInStock = 1},
            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - LANGUAGE INTEGRATED QUERY
            //lambda
            
            //foreach gibi id eşit olan değerin referansını!! atar
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan ürün id'sini bul
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitPrice= product.UnitPrice;
            ProductToUpdate.UnitInStock = product.UnitInStock;



        }
    }
}
