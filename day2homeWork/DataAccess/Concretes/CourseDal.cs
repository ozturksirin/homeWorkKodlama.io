using day2homeWork.DataAccess.Abstracts;
using day2homeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2homeWork.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {

            Course course1 = new Course();
            course1.id = 1;
            course1.name = "C#";
            course1.description = "C# is a programming language";
            course1.teacher = "Engin Demirog";
            course1.category = "Programming";
            course1.imagePath = "csharp.jpg";

            Course course2 = new Course();
            course2.id = 2;
            course2.name = "Java";
            course2.description = "Java is a programming language";
            course2.teacher = "Engin Demirog";
            course2.category = "Programming";
            course2.imagePath = "java.jpg";

            Course course3 = new Course();
            course3.id = 3;
            course3.name = "Angular";
            course3.description = "Angular is a front-end framework";
            course3.teacher = "Engin Demirog";
            course3.category = "Front-End";
            course3.imagePath = "angular.jpg";

           
            courses = new List<Course> { course1, course2, course3 };

        }

        public void Add(Course course)
        {
            courses.Add(course);
        }
        public void Update(Course course)
        {
            Course courseToUpdate = courses.SingleOrDefault(courseID => courseID.id == course.id);
            courseToUpdate.name = course.name;
            courseToUpdate.description = course.description;
            courseToUpdate.teacher = course.teacher;
            courseToUpdate.category = course.category;
            courseToUpdate.imagePath = course.imagePath;
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Delete(int id)
        {
            Course courseToDelete = courses.SingleOrDefault(courseID => courseID.id == id);
            courses.Remove(courseToDelete);
        }
    }
}
