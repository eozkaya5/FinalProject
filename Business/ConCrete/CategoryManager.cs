
using Business.Abstract;
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

        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll();
        }

        //Select * from Categories where categoryId=3
        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(c => c.CategoryId == categoryId);
        }
    }
}
