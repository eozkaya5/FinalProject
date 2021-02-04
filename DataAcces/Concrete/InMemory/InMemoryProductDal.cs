using DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    // InMemory=Bellek
   public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//global değişkendir

        public InMemoryProductDal()//Bellekte referans aldığında çalışır(Contractr)
        {
            _products = new List<Product> 
            {
           new Product{ProductId=1, CategoryId=1, ProductName="Kitap", UnitInStock=15, UnitPrice=15},
           new Product{ProductId=2, CategoryId=2, ProductName="Bardak", UnitInStock=500, UnitPrice=3},
           new Product{ProductId=3, CategoryId=3, ProductName="Klavye", UnitInStock=1500, UnitPrice=2},
           new Product{ProductId=4, CategoryId=4, ProductName="Mause", UnitInStock=150, UnitPrice=65},
           new Product{ProductId=5, CategoryId=5, ProductName="telefon", UnitInStock=85, UnitPrice=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        //Linq Lenguage Integrated Query
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); //SingleOrDefault=Tek tek dolaşmaya yarar
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
           return _products.Where(p => p.CategoryId == categoryId).ToList();//where= yeni bir liste haline getiri onu döndürür
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
