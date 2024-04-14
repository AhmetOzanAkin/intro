using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];

    // constructor 
    public CourseManager()
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll()
    {
        return courses;
    }
}
