
using Core.Utilities.Result;
using Core.Utilities.Result.Absract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetByCategoryId(int id);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();

        IDataResult<List<Product>> GetById(int productId);

        IResult Add(Product product);

        IResult Update(Product product);
       
    }
}
