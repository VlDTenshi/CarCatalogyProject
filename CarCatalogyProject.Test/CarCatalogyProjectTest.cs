using CarCatalogyProject.Controllers;
using CarCatalogyProject.Data;
using CarCatalogyProject.Data.Repository;
using CarCatalogyProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCatalogyProject.Test
{
    public class CarCatalogyProjectTest : UnitTest1
    {
        [Fact]
        public void Check_WithValidModelState_ShouldRedirectToRoot()
        {
            // Arrange
            var contact = new Contact
            {
                Name = "John",
                Surname = "Doe",
                Age = 25,
                Email = "john@example.com",
                Message = "This is a test message."
            };

            var controller = new ContactsController();

            // Act
            var result = controller.Check(contact);

            // Assert
            var redirectResult = Assert.IsType<RedirectResult>(result);
            Assert.Equal("/", redirectResult.Url);
        }

        [Fact]
        public void Check_WithInvalidModelState_ShouldReturnView()
        {
            // Arrange
            var contact = new Contact
            {
                // Omitting required properties to simulate invalid model state
            };

            var controller = new ContactsController();
            controller.ModelState.AddModelError("Name", "Name is required"); // Simulate ModelState error

            // Act
            var result = controller.Check(contact);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("Index", viewResult.ViewName);
        }
    }
}
