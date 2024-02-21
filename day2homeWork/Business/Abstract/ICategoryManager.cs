using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2homeWork.Business.Abstract
{
    public interface ICategoryManager
    {
         List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);

    }
}
