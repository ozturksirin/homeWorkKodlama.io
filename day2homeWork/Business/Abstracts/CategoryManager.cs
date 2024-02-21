using day2homeWork.DataAccess.Abstracts;
using day2homeWork.Entities;
using System.Collections.Generic;

namespace day2homeWork.Business.Abstracts
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }


    }
}
