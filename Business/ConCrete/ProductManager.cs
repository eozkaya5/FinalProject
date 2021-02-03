using Business.Abstract;
using DataAccess.Abstract;
using Entiteies.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; //soyut nesneyle bağlantı kurulacak
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            return _productDal.GetAll();
           
        }
    }
}
