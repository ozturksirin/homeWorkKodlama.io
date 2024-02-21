using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day2homeWork.DataAccess.Abstracts;

namespace day2homeWork.Business.Abstracts
{
    public class StudentsManager
    {
        private readonly IStudents _students;

        public StudentsManager(IStudents students)
        {
            _students = students;
        }

        public List<Students> GetAll()
        {
            return _students.GetAll();
        }

        public void UpdateStudent(Students updatedStudent)
        {
            _students.Update(updatedStudent);
        }


    }
}
