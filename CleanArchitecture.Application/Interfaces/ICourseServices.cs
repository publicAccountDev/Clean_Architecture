using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseServices
    {
        CourseViewModel GetCourses();
        Course GetCourseById(int courseId);
    }
}
