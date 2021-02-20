using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Test.MoqData;
using CleanArchitecture.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.Test
{
    public class CourseControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            // Arrange
            var moq = new Mock<ICourseServices>();
            moq.Setup(c => c.GetCourses()).Returns(moq.Object.GetCourses());

            CourseController courseController = new CourseController(moq.Object);

            // Act
            var result = courseController.Index();

            // Assert
            var viewResult = result as ViewResult;

            Assert.NotNull(result);
            
            Assert.IsType<ViewResult>(result);
        }
        
        [Theory]
        [InlineData(1)]
        public void ShowCourseTest(int id)
        {
            // Arrange
            var moq = new Mock<ICourseServices>();
            moq.Setup(c => c.GetCourseById(id)).Returns(MoqData.MoqData.GetAllData()
                .FirstOrDefault(d => d.CourseId == id));

            CourseController courseController = new CourseController(moq.Object);

            // Act
            var result = courseController.ShowCourse(id);
            // Assert 
            var viewResult = result as ViewResult;

            Assert.IsType<ViewResult>(result);
            Assert.NotNull(result);
            Assert.IsAssignableFrom<Course>(viewResult.ViewData.Model);

        }
    }
}
