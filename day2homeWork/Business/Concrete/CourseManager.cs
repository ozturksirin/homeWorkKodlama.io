using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day2homeWork.Business.Abstract;
using day2homeWork.DataAccess.Abstracts;
using day2homeWork.Entities;


namespace day2homeWork.Business.Concrete
{
    public class CourseManager:ICourseManager
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}
