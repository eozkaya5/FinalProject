
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        // interface' de methodlar public olduğu için public kullanmıyoruz.
        List<ProductDetailDto> GetProductdetails();
    }
}
//Code Refactoring