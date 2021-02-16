using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private DataBaseContext _context;
        public CourseRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Course GetCourseById(int courseId)
        {
            return _context.Courses.Find(courseId);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
