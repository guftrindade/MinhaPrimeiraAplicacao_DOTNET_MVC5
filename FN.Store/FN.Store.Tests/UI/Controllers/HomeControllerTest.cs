using FN.Store.UI2.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {
        //Dado o HomeController
        [TestMethod]
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //Arange
            var homeController = new HomeController();

            //Act
            var result = homeController.Index();

            //Assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
