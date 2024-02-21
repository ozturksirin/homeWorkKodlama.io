using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2homeWork.Business.Abstract
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
        List<Course> GetAll();

    }
}
