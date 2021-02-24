
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Absract;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }

        //Select * from Categories where categoryId=3
        public IDataResult<List<Category>> GetById(int categoryId)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }

      
    }
}
