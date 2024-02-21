using day2homeWork.DataAccess.Abstracts;
using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2homeWork.DataAccess.Concretes
{
    public class StudentsDal : IStudents
    {
        List<Students> students;

        public StudentsDal()
        {
            students = new List<Students>();
        }

        public List<Students> GetAll()
        {
            return new List<Students>
            {
                new Students { id = 1, firstName = "John" ,email="john@example.com"},
                new Students { id = 2, firstName = "Doe",email = "doe@example.com" },
                new Students { id = 3, firstName = "Jane",email = "jane@example.com" },
                new Students { id = 4, firstName = "Ali",email = "ali@example.com" }
            };
        }

        public void Add(Students student)
        {
            students.Add(student);
        }


        public void Update(Students student)
        {
            if (students.Any(s => s.id == student.id))
            {
                students.RemoveAll(s => s.id == student.id);
            }

            students.Add(student);
        }


        public List<Students> GetStudents()
        {
            return students;
        }

        public void DeleteById(int id)
        {
            students.RemoveAll(student => student.id == id);
        }

        public void Remove(Students student)
        {
            students.Remove(student);
        }
    }
}
