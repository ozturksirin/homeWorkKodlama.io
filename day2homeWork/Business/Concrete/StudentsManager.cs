using day2homeWork.Entities;
using day2homeWork.DataAccess.Abstracts;
using System.Collections.Generic;

namespace day2homeWork.Business.Abstract
{
    public class StudentsManager : IStudentsManager
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

        public void Add(Students student)
        {
            _students.Add(student);
        }

        public void Remove(Students student)
        {
            _students.Remove(student);
        }

        public void Update(Students student)
        {
            _students.Update(student);
        }

        public void DeleteById(int id)
        {
            _students.DeleteById(id);
        }
    }
}
