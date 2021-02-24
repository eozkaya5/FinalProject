
using Core.Utilities.Result.Absract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);

        IDataResult<List<Category>> GetAll();

        IDataResult<List<Category>> GetById(int categoryId);


    }
}
