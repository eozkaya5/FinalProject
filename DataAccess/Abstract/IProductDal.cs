using Entiteies.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntitiyRepository<Product>
    {
        // interface' de methodlar public olduğu için public kullanmıyoruz.
       
    }
}
