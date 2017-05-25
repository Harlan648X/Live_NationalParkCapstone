using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void HomeController_IndexAction_ReturnIndexView()
        {
            //string conn = @"Data Source=.\SQLEXPRESS;Initial Catalog=npgeek;User ID=te_student;Password=sqlserver1";
            //Arrange

            //ParkListSqlDAL parkDal = new ParkListSqlDAL(conn);

            //HomeController controller = new HomeController(null);

            //Act
            //ViewResult result = controller.Index() as ViewResult;
                  
            //Assert
            
            //Assert.AreEqual("Index", result.ViewName);
        }
    }
}