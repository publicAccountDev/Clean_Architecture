using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseServices _courseServices;
        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        public IActionResult Index()
        {
            var model = _courseServices.GetCourses();
            return View(model);
        }
    }
}
