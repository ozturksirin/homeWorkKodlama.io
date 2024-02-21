using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day2homeWork.Entities;

namespace day2homeWork.Business.Abstract
{
    public interface IStudentsManager
    {
        List<Students> GetAll();
        void Add(Students student);
        void Remove(Students student);
        void Update(Students student);
        void DeleteById(int id);
    }
}
