using day2homeWork.DataAccess.Abstracts;
using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2homeWork.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            categories = new List<Category>
            {
                new Category { id = 1, name = "Programming" },
                new Category { id = 2, name = "Design" },
                new Category { id = 3, name = "Management" }
            };

            categories.ForEach(x => Console.WriteLine(x.name));
        }

        public void Add(Category categori)
        {
            categories.Add(categori);
        }

       
        public List<Category> GetAll()
        {
            return categories;
        }

        public void Remove(Category category)
        {

            if (categories.Exists(x => x.id == category.id))
            {
                categories.Remove(category);
            }
            else
            {
                throw new Exception("Category not found");
            }

        }

        public void Update(Category category)
        {
            if (categories.Exists(x => x.id == category.id))
            {
                var categoryToUpdate = categories.FirstOrDefault(x => x.id == category.id);
                categoryToUpdate.name = category.name;
            }
            else
            {
                throw new Exception("Category not found");
            }
        }
    }
}
