using intro.DataAccess.Abstracts;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Name = "C#";
        course1.Description = ".NET 8";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Name = "Java";
        course2.Description = "Spring";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Name = "Python";
        course3.Description = "Veri bilimi";
        course3.Price = 20;

        courses = new List<Course> { course1,course2,course3};
    }
    public List<Course> GetAll()
    {
        //burada database işlemleri yapılacak.
        return courses;
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
}
