using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2homeWork.DataAccess.Abstracts
{
    public interface IStudents
    {
        List<Students> GetAll();
        void Add(Students student);
        void Update(Students updatedStudent);

        void Delete(Students student);


    }
}
