using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using OdeToFood;
using OdeToFood.Controllers;

namespace OdeToFood.Tests.Controllers
{
    [TestFixture]
    public class CuisineControllerTest
    {
        [Test]
        [Ignore("Mock Server needed")]
        public void Search()
        {
            // Arrange
            CuisineController controller = new CuisineController();

            // Act
            var result = controller.Search() as ContentResult;

            // Assert
            Assert.That("*", Is.EqualTo(result.Content));

        }
    }
}
