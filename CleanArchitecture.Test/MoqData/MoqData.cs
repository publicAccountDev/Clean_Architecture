using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Test.MoqData
{
    public static class MoqData
    {
        public static List<Course> GetAllData()
        {
            List<Course> courses = new List<Course>()
            {
                new Course{CourseId=1, CourseName= "Kotlin", Description="The Tutorial Kotlin", ImageUrl="/Images/test.png"}
            };

            return courses;
        }
    }
}
