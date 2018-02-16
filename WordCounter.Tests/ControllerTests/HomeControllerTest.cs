using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using WordCounter.Controllers;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnIfView_True()
        {
            //arrange
            HomeController controller = new HomeController();

            //act
            IActionResult indexView = controller.Index();
            ViewResult result = indexView as ViewResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_True()
        {
            //arrange
            ViewResult indexView = new HomeController().Index() as ViewResult;

            //act
            var result = indexView.ViewData.Model;

            //assert
            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
        }
    }
}
