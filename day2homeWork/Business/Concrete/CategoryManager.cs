using day2homeWork.Business.Abstract;
using day2homeWork.DataAccess.Abstracts;
using day2homeWork.DataAccess.Concretes;
using day2homeWork.Entities;
using System.Collections.Generic;

namespace day2homeWork.Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly CategoryDal _categoryDal;
        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
