using CleanArchitecture.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.Test
{
    public class HomeControllerTest
    {
        [Trait("Index Test", "Home Controller Test")]
        [Fact]
        public void IndexTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert

            Assert.IsType<ViewResult>(result);
            Assert.NotNull(result);
        }
    }
}
