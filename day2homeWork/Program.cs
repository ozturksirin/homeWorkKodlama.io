using System;
using System.Collections.Generic;
using day2homeWork.Business.Concrete;
using day2homeWork.DataAccess.Concretes;
using day2homeWork.Entities;

class Program
{
    static void Main()
    {
        Console.WriteLine("START");

        CourseManager courseManager = new(new CourseDal());

        List<Course> allCourses = courseManager.GetAll();

        for (int i = 0; i < allCourses?.Count; i++)
        {
            Console.WriteLine($"Course ID: {allCourses[i].id}, Course Name: {allCourses[i].name}");
        }

        Console.WriteLine("------------------------");


        CategoryManager categoryManager = new(new CategoryDal());

        List<Category> allCategories = categoryManager.GetAll();

        for (int i = 0; i < allCategories?.Count; i++)
        {
            Console.WriteLine($"Category ID: {allCategories[i].id}, Category Name: {allCategories[i].name}");
        }

        Console.WriteLine("------------------------");

        StudentsManager studentManager = new(new StudentsDal());

        List<Students> allStudents = studentManager.GetAll();

        for (int i = 0; i < allStudents?.Count; i++)
        {
            Console.WriteLine($"Student ID: {allStudents[i].id}, Student Name: {allStudents[i].firstName}");
        }

       StudentsManager newStudent = new(new StudentsDal());

       newStudent.UpdateStudent(new Students { id = 1, firstName = "John", });
            






    }
}
